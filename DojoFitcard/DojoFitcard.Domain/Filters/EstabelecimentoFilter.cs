using DojoFitcard.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace DojoFitcard.Domain.Filters
{   
    public class EstabelecimentoFilter : BaseFilter<Estabelecimento>
    {
        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public string Cnpj { get; set; }

        public bool? Ativo { get; set; }

        public override Expression<Func<Estabelecimento, bool>> Predicate
        {
            get
            {
                return (u =>
                    (string.IsNullOrEmpty(RazaoSocial) || u.RazaoSocial.ToLower().Contains(RazaoSocial.ToLower()))
                    && (string.IsNullOrEmpty(NomeFantasia) || u.NomeFantasia.ToLower().Contains(NomeFantasia.ToLower()))
                    && (string.IsNullOrEmpty(Cnpj) || u.CNPJ.ToLower().Contains(Cnpj.ToLower()))
                    && (Ativo == null || u.Ativo == Ativo)
                    && (u.Excluido == false)
                );
            }
        }
    }
}
