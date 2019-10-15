using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.UI.ViewModels;

namespace ProjetoDDD.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        } 

        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto> ();
        }
    }
}