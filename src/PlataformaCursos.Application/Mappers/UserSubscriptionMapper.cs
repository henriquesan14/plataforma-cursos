using AutoMapper;
using PlataformaCursos.Application.Commands.CreateUserSubscription;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Application.Mappers
{
    public class UserSubscriptionMapper : Profile
    {
        public UserSubscriptionMapper()
        {
            CreateMap<CreateUserSubscriptionCommand, UserSubscription>();
        }
    }
}
