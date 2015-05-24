using System;
using System.Linq;

namespace PortalConhecimento.Domain
{
    public interface IBaseRepository<T, TKey> : IDisposable
        where T : class
        where TKey : struct
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(TKey id);
        T Get(TKey id);
        IQueryable<T> List();
    }
}