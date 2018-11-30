using DojoFitcard.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DojoFitcard.Data.Repositories
{
    public class EstabelecimentoRepository : BaseRepository<Estabelecimento>
    {
        public new Estabelecimento GetById(string id)
        {
            Expression<Func<Estabelecimento, bool>> predicate;
            predicate = (l => l.Id == id);

            var estabelecimento = Db.Estabelecimento
                                    .Include("Categoria")
                                    .Where(predicate.Compile())
                                    .FirstOrDefault();

            return estabelecimento;
        }
    }
}
