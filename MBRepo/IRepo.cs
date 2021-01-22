using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBRepo
{
    interface IRepo<Tcontext> where  Tcontext : DbContext, new()
    {
        IEnumerable<TEntity> GetAll<TEntity>() where TEntity : class;

        TEntity GetOne<TEntity>(object pkValue) where TEntity : class;

        void Insert<TEntity>(TEntity record) where TEntity : class;

        void InsertRange<TEntity>(List<TEntity> records) where TEntity:class;

        void Delete<TEntity>(TEntity record) where TEntity : class;

        void Save();
    }
}
