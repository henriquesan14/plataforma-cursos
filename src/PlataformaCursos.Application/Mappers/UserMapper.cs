using AutoMapper;
using PlataformaCursos.Application.Commands.CreateUser;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Application.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<CreateUserCommand, User>();
        }
    }
}
