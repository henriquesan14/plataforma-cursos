using AutoMapper;
using MediatR;
using PlataformaCursos.Core.Entities;
using PlataformaCursos.Core.Repositories;
using PlataformaCursos.Infra.Models.Request;
using PlataformaCursos.Infra.Services;
using Refit;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;

namespace PlataformaCursos.Application.Commands.CreatePaymentSubscription
{
    public class CreatePaymentSubscriptionCommandHandler : IRequestHandler<CreatePaymentSubscriptionCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAsaasService _asaasService;

        public CreatePaymentSubscriptionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IAsaasService asaasService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _asaasService = asaasService;
        }

        public async Task Handle(CreatePaymentSubscriptionCommand request, CancellationToken cancellationToken)
        {
            List<Expression<Func<UserSubscription, object>>> includes = new List<Expression<Func<UserSubscription, object>>>
            {
                u => u.User,
                u => u.Subscription
            };
            var userSubscription = await _unitOfWork.UserSubscriptions.GetByIdAsync(request.UserSubscriptionId, includes);

            var customerId = "";
            var customers = await _asaasService.GetCustomers(userSubscription.User.Document);
            var customerExist = customers.Data.First();

            if (customerExist != null)
            {
                customerId = customerExist.Id;
            }
            else
            {
                var requestCustomer = new CreateCustomerRequest
                {
                    Name = userSubscription.User.Name,
                    CpfCnpj = userSubscription.User.Document,
                    MobilePhone = userSubscription.User.PhoneNumber
                };
                var resultCustomer = await _asaasService.CreateCustomer(requestCustomer);
                customerId = resultCustomer.Id;
            }
            
            var requestPayment = new CreatePaymentRequest
            {
                BillingType = "BOLETO",
                Customer = customerId,
                DueDate = request.DueDate.ToString("yyyy-MM-dd"),
                Value = (double) request.Value
            };

            var resultPayment = await _asaasService.CreatePayment(requestPayment);


            var payment = new PaymentSubscription
            {
                PaymentExternalId = resultPayment.Id,
                PaymentLink = resultPayment.InvoiceUrl,
                DueDate = request.DueDate,
                ProcessingDate = DateTime.UtcNow,
                Status = Core.Enums.StatusPaymentEnum.PENDING,
                Value = request.Value,
                Message = "teste",
                UserSubscription = userSubscription
            };

            await _unitOfWork.PaymentSubscriptions.AddAsync(payment);
            await _unitOfWork.CompleteAsync();
        }
    }
}
