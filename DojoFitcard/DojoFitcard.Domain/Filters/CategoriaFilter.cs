using DojoFitcard.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace DojoFitcard.Domain.Filters
{
    public class CategoriaFilter : BaseFilter<Categoria>
    {
        public string Nome { get; set; }

        public bool? Ativo { get; set; }

        public override Expression<Func<Categoria, bool>> Predicate
        {
            get
            {
                return (u =>
                    (string.IsNullOrEmpty(Nome) || u.Nome.ToLower().Contains(Nome.ToLower()))
                    && (Ativo == null || u.Ativo == Ativo)
                    && (u.Excluido == false)
                );
            }
        }
    }
}
