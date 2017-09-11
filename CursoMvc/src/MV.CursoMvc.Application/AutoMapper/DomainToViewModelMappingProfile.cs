using AutoMapper;
using MV.CursoMvc.Application.ViewModels;
using MV.CursoMvc.Domain.Entities;

namespace MV.CursoMvc.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Cliente, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Endereco, ClienteEnderecoViewModel>();
            Mapper.CreateMap<Endereco, EnderecoViewModel>();
        }
    }
}