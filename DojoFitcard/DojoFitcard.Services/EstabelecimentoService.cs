using DojoFitcard.Data.Repositories;
using DojoFitcard.Domain.Entities;
using DojoFitcard.Domain.Filters;
using System.Collections.Generic;

namespace DojoFitcard.Services
{
    public class EstabelecimentoService
    {
        private EstabelecimentoRepository _estabelecimentoRepository;

        public EstabelecimentoService()
        {
            _estabelecimentoRepository = new EstabelecimentoRepository();
        }

        public IEnumerable<Estabelecimento> GetAll()
        {
            var result = _estabelecimentoRepository.GetAll();

            return result;
        }

        public Estabelecimento Add(Estabelecimento estabelecimento)
        {
            var result = _estabelecimentoRepository.Add(estabelecimento);

            return result;
        }

        public Estabelecimento Update(Estabelecimento estabelecimento)
        {
            var result = _estabelecimentoRepository.Update(estabelecimento);

            return result;
        }

        public Estabelecimento GetById(string id)
        {
            var result = _estabelecimentoRepository.GetById(id);

            return result;
        }

        public List<Estabelecimento> GetByFilter(EstabelecimentoFilter filter)
        {
            var estabelecimentos = _estabelecimentoRepository.GetByFilter(filter);
            return estabelecimentos;
        }

        public void Remove(string id)
        {

            var estabelecimento = _estabelecimentoRepository.GetById(id);
            _estabelecimentoRepository.Remove(estabelecimento);
        }
    }
}
