using AutoMapper;
using DojoFitcard.Domain.Entities;
using DojoFitcard.Domain.Filters;
using DojoFitcard.WebApi.DomainViewModel.Entities;
using DojoFitcard.WebApi.DomainViewModel.Filters;

namespace DojoFitcard.WebApi.Mappers
{
    public class ModelToViewModelMappingProfile : Profile
    {
        protected void Configure()
        {
            CreateMap<Categoria, CategoriaViewModel>();
            CreateMap<Estabelecimento, EstabelecimentoViewModel>();

            CreateMap<CategoriaFilter, CategoriaFilterViewModel>();
            CreateMap<EstabelecimentoFilter, EstabelecimentoFilterViewModel>();
        }
    }
}