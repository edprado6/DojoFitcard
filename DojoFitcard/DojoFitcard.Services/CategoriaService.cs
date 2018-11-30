using DojoFitcard.Data.Repositories;
using DojoFitcard.Domain.Entities;
using DojoFitcard.Domain.Filters;
using System;
using System.Collections.Generic;

namespace DojoFitcard.Services
{
    public class CategoriaService
    {
        private CategoriaRepository _categoriaRepository;

        public CategoriaService()
        {
            _categoriaRepository = new CategoriaRepository();
        }

        public IEnumerable<Categoria> GetAll()
        {
            var result = _categoriaRepository.GetAll();
           
            return result;
        }

        public Categoria Add(Categoria categoria)
        {
            var result = _categoriaRepository.Add(categoria);

            return result;
        }

        public Categoria Update(Categoria categoria)
        {
            var result = _categoriaRepository.Update(categoria);

            return result;
        }

        public Categoria GetById(string id)
        {
            var result = _categoriaRepository.GetById(id);

            return result;
        }
        
        public List<Categoria> GetByFilter(BaseFilter<Categoria> filter)
        {
            var categorias = _categoriaRepository.GetByFilter(filter);
            return categorias;
        }

        public void Remove(string id) {

            var categoria = _categoriaRepository.GetById(id);
            _categoriaRepository.Remove(categoria);
        }
    }
}
