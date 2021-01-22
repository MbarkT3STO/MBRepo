using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MBRepo
{

    /// <typeparam name="TContext"></typeparam>
    public class Repo<TContext> : IRepo<TContext> where TContext : DbContext, new()
    {


        #region Repository properties

        /// <summary>
        /// Private DBContext property
        /// </summary>
        private DbContext _Context { get; } = null;
        

        #endregion






        #region Construcors

        public Repo()
        {
            _Context = new TContext();
        }


        #endregion





        #region Select

        /// <summary>
        /// Get All records from a table
        /// </summary>
        /// <typeparam name="TEntity">The entity to select from</typeparam>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            return _Context.Set<TEntity>().ToList();
        }



        /// <summary>
        /// Asynchronously, Get All records from a table
        /// </summary>
        /// <typeparam name="TEntity">The entity to select from</typeparam>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> GetAllAsync<TEntity>() where TEntity : class
        {
            return Task.Factory.StartNew(() => GetAll<TEntity>());
        }




        /// <summary>
        /// Get One record from a table, based on the primary key value
        /// </summary>
        /// <typeparam name="TEntity">The entity to select from</typeparam>
        /// <param name="pkValue">The primary key value</param>
        /// <returns></returns>
        public TEntity GetOne<TEntity>(object pkValue) where TEntity : class
        {
            return _Context.Set<TEntity>().Find(pkValue);
        }



        /// <summary>
        /// Asynchronously, Get One record from a table, based on the primary key value
        /// </summary>
        /// <typeparam name="TEntity">The entity to select from</typeparam>
        /// <param name="pkValue">The primary key value</param>
        /// <returns></returns>
        public Task<TEntity> GetOneAsync<TEntity>(object pkValue) where TEntity : class
        {
            return Task.Factory.StartNew(() => GetOne<TEntity>(pkValue));
        }


        #endregion




        #region Insert



        /// <summary>
        /// Insert one record into the database table
        /// </summary>
        /// <typeparam name="TEntity">Entity to add into</typeparam>
        /// <param name="record">The record to be added</param>
        public void Insert<TEntity>(TEntity record) where TEntity : class
        {
            _Context.Set<TEntity>().Add(record);
        }



        /// <summary>
        /// Asynchronously, Insert one record into the database table
        /// </summary>
        /// <typeparam name="TEntity">Entity to add into</typeparam>
        /// <param name="record">The record to be added</param>
        public Task InsertAsync<TEntity>(TEntity record) where TEntity : class
        {
            return Task.Factory.StartNew(() => Insert(record));
        }



        /// <summary>
        /// Insert a range of reords in a table
        /// </summary>
        /// <typeparam name="TEntity">Entity to insert into</typeparam>
        /// <param name="records">Records to be inserted</param>
        public void InsertRange<TEntity>(List<TEntity> records) where TEntity : class
        {
            _Context.Set<TEntity>().AddRange(records);
        }



        /// <summary>
        /// Asynchronously, Insert a range of reords in a table
        /// </summary>
        /// <typeparam name="TEntity">Entity to insert into</typeparam>
        /// <param name="records">Records to be inserted</param>
        public Task InsertRangeAsync<TEntity>(List<TEntity> records) where TEntity : class
        {
            return Task.Factory.StartNew(() => InsertRange(records));
        }



        #endregion




        #region Delete

        /// <summary>
        /// Delete One record from a database table
        /// </summary>
        /// <typeparam name="TEntity">Entity to remove from</typeparam>
        /// <param name="record">The record to be removed</param>
        public void Delete<TEntity>(TEntity record) where TEntity : class
        {
            this._Context.Set<TEntity>().Remove(record);
        }



        /// <summary>
        /// Asynchronously, Delete One record from a database table
        /// </summary>
        /// <typeparam name="TEntity">Entity to remove from</typeparam>
        /// <param name="record">The record to be removed</param>
        public Task DeleteAsync<TEntity>(TEntity record) where TEntity : class
        {
            return Task.Factory.StartNew(() => Delete(record));
        }


        #endregion



        /// <summary>
        /// Save the repository changes
        /// </summary>
        public void Save()
        {
            _Context.SaveChanges();
        }

    }
}