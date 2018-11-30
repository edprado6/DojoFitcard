using DojoFitcard.Domain.Filters;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DojoFitcard.Data.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        protected Database Db = new Database();

        public TEntity Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
            return obj;
        }

        public TEntity GetById(string id)
        {
            Db.Configuration.AutoDetectChangesEnabled = false;
            Db.Set<TEntity>().AsNoTracking();
            return Db.Set<TEntity>().Find(id);            
        }

        public IEnumerable<TEntity> GetAll()
        {
            Db.Configuration.AutoDetectChangesEnabled = false;
            return Db.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
            return obj;           
        }

        public void Remove(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Deleted;
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }
          
        public List<TEntity> GetByFilter(BaseFilter<TEntity> filter) {

            var query = Db.Set<TEntity>().AsNoTracking().Where(filter.Predicate.Compile());
            var quantidadeRegistros = query.Count();
            var registros = query.Skip((filter.Pagina - 1) * filter.RegistrosPorPagina).Take(filter.RegistrosPorPagina);
            return registros.ToList();
        }
    }
}
