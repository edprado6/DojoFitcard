using AutoMapper;
using DojoFitcard.Domain.Entities;
using DojoFitcard.Domain.Filters;
using DojoFitcard.WebApi.DomainViewModel.Entities;
using DojoFitcard.WebApi.DomainViewModel.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DojoFitcard.WebApi.Mappers
{
    public class ViewModelToModelMappingProfile : Profile
    {
        protected void Configure()
        {
            CreateMap<CategoriaViewModel, Categoria>();
            CreateMap<EstabelecimentoViewModel, Estabelecimento>();

            CreateMap<CategoriaFilterViewModel, CategoriaFilter>();
            CreateMap<EstabelecimentoFilterViewModel, EstabelecimentoFilter>();
        }
    }
}