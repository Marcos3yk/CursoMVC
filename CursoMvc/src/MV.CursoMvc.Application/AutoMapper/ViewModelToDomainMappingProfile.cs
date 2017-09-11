using AutoMapper;
using MV.CursoMvc.Application.ViewModels;
using MV.CursoMvc.Domain.Entities;

namespace MV.CursoMvc.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Cliente>();
            Mapper.CreateMap<EnderecoViewModel, Endereco>();
            Mapper.CreateMap<ClienteEnderecoViewModel, Endereco>();
           
        }
    }
}