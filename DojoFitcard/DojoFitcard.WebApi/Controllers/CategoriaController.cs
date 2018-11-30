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
    public class CategoriaController : ApiController
    {
        private CategoriaService _categoriaService;

        public CategoriaController()
        {
            _categoriaService = new CategoriaService();
        }

        /// <summary>
        /// Retorna uma lista de registros.
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri]CategoriaFilterViewModel filterViewModel)
        {
            try
            {
                var filter = Mapper.Map<CategoriaFilterViewModel, CategoriaFilter>(filterViewModel);

                var result = _categoriaService.GetByFilter(filter);

                var categoriasViewModel = Mapper.Map<List<Categoria>, List<CategoriaViewModel>>(result);

                return Request.CreateResponse(HttpStatusCode.OK, categoriasViewModel);
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
            try
            {

                var categoria = _categoriaService.GetById(id);

                var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

                return Request.CreateResponse(HttpStatusCode.OK, categoriaViewModel);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }

        /// <summary>
        /// Adiciona um novo registro.
        /// </summary>
        /// <param name="categoriaViewModel"></param>
        /// <returns></returns>               
        public HttpResponseMessage Post([FromBody]CategoriaViewModel categoriaViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var categoria = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);

                    var result = _categoriaService.Add(categoria);

                    categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

                    return Request.CreateResponse(HttpStatusCode.OK, categoriaViewModel);
                }
                catch (Exception e)
                {

                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
                }
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

        /// <summary>
        /// Atualiza um registro.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoriaViewModel"></param>
        /// <returns></returns>
        public HttpResponseMessage Put(string id, [FromBody]CategoriaViewModel categoriaViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var categoria = Mapper.Map<CategoriaViewModel, Categoria>(categoriaViewModel);

                    var result = _categoriaService.Update(categoria);

                    categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

                    return Request.CreateResponse(HttpStatusCode.OK, categoriaViewModel);
                }
                catch (Exception e)
                {

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
            try
            {
                _categoriaService.Remove(id);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.Message);
            }
        }
    }
}
