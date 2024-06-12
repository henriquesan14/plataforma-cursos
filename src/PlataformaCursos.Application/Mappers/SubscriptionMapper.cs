using AutoMapper;
using PlataformaCursos.Application.Commands.CreateSubscription;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Application.Mappers
{
    public class SubscriptionMapper : Profile
    {
        public SubscriptionMapper()
        {
            CreateMap<CreateSubscriptionCommand, Subscription>();
        }
    }
}
