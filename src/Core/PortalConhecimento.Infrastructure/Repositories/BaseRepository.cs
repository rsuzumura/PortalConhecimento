using PortalConhecimento.Domain;
using PortalConhecimento.Infrastructure.Contexts;
using System;
using System.Data.Entity;
using System.Linq;

namespace PortalConhecimento.Infrastructure
{
    public class BaseRepository<T, TKey> : IBaseRepository<T, TKey>
        where T : class
        where TKey : struct
    {
        protected PortalConhecimentoContext _context;
        public BaseRepository()
        {
            _context = new PortalConhecimentoContext();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void Delete(TKey id)
        {
            var entity = Get(id);
            Delete(entity);
        }

        public T Get(TKey id)
        {
            var entity = _context.Set<T>().Find(id);
            return entity;
        }

        public IQueryable<T> List()
        {
            var entities = _context.Set<T>();
            return entities.AsQueryable();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
            }
        }
    }
}