using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.DAL.Repositorios.Base
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Save();
        void Remove(Func<TEntity, bool> predicate);
    }
}
