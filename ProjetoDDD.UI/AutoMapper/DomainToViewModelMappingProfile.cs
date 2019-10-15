using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.UI.ViewModels;

namespace ProjetoDDD.UI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}