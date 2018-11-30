using System;
using System.Linq.Expressions;

namespace DojoFitcard.Domain.Filters
{
    public abstract class BaseFilter<TEntity> where TEntity : class
    {
        public int RegistrosPorPagina { get; set; }

        public int Pagina { get; set; }

        public virtual Expression<Func<TEntity, bool>> Predicate { get; }
    }
}
