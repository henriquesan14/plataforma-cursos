using AutoMapper;
using PlataformaCursos.Application.Commands.CreateModule;
using PlataformaCursos.Core.Entities;

namespace PlataformaCursos.Application.Mappers
{
    public class ModuleMapper : Profile
    {
        public ModuleMapper()
        {
            CreateMap<CreateModuleCommand, Module>();
        }
    }
}
