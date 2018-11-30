using AutoMapper;
using DojoFitcard.Domain.Entities;
using DojoFitcard.Domain.Filters;
using DojoFitcard.Services;
using DojoFitcard.WebApi.DomainViewModel.Entities;
using DojoFitcard.WebApi.DomainViewModel.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DojoFitcard.WebApi.Controllers
{
    public class EstabelecimentoController : ApiController
    {
        private EstabelecimentoService _estabelecimentoService;

        public EstabelecimentoController()
        {
            _estabelecimentoService = new EstabelecimentoService();
        }

        /// <summary>
        /// Retorna uma lista de registros.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri]EstabelecimentoFilterViewModel filterViewModel)
        {
            try {

                var filter = Mapper.Map<EstabelecimentoFilterViewModel, EstabelecimentoFilter>(filterViewModel);

                var result = _estabelecimentoService.GetByFilter(filter);

                var estabelecimentosViewModel = Mapper.Map<List<Estabelecimento>, List<EstabelecimentoViewModel>>(result);

                return Request.CreateResponse(HttpStatusCode.OK, estabelecimentosViewModel);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }

           
        }

        /// <summary>
        /// Retorna um registro de acordo com id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HttpResponseMessage Get(string id)
        {
            try {

                var estabelecimento = _estabelecimentoService.GetById(id);

                var estabelecimentoViewModel = Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento);

                return Request.CreateResponse(HttpStatusCode.OK, estabelecimentoViewModel);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }            
        }

        /// <summary>
        /// Adiciona um novo registro.
        /// </summary>
        /// <param name="estabelecimentoViewModel"></param>
        /// <returns></returns>               
        public HttpResponseMessage Post([FromBody]EstabelecimentoViewModel estabelecimentoViewModel)
        {
            if (ModelState.IsValid)
            {
                try {

                    var estabelecimento = Mapper.Map<EstabelecimentoViewModel, Estabelecimento>(estabelecimentoViewModel);

                    var result = _estabelecimentoService.Add(estabelecimento);

                    estabelecimentoViewModel = Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento);

                    return Request.CreateResponse(HttpStatusCode.OK, estabelecimentoViewModel);
                }
                catch (Exception e) {

                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
                }                
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

        /// <summary>
        /// Atualiza um registro.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estabelecimentoViewModel"></param>
        /// <returns></returns>
        public HttpResponseMessage Put(string id, [FromBody]EstabelecimentoViewModel estabelecimentoViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var estabelecimento = Mapper.Map<EstabelecimentoViewModel, Estabelecimento>(estabelecimentoViewModel);

                    var result = _estabelecimentoService.Update(estabelecimento);

                    estabelecimentoViewModel = Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento);

                    return Request.CreateResponse(HttpStatusCode.OK, estabelecimentoViewModel);
                }
                catch (Exception e) {

                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
                }                   
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

        /// <summary>
        /// Remove um registro.
        /// </summary>
        /// <param name="id"></param>
        public HttpResponseMessage Delete(string id)
        {
            try {

                _estabelecimentoService.Remove(id);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }            
        }
    }
}
