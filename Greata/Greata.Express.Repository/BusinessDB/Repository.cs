using System;

namespace Greata.Express.Repository.BusinessDB
{
    using Model.DB;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    using Greata.Express.Repository.Interface;

    /// <summary>
    /// 业务数据库仓库
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity>,IDisposable
        where TEntity : class
    {
        readonly DbContext _DbContext;
        readonly DbSet<TEntity> _DbSet;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Repository()
        {
            _DbContext = new GreataBusinessContext();
            _DbSet = _DbContext.Set<TEntity>();
        }

        TEntity IRepository<TEntity>.Create(TEntity model)
        {
            _DbSet.Add(model);
            _DbContext.SaveChanges();
            return model;
        }

        void IRepository<TEntity>.Delete(TEntity model)
        {
            _DbSet.Remove(model);
            _DbContext.SaveChanges();
        }

        TEntity IRepository<TEntity>.Update(TEntity model)
        {
            _DbContext.Entry<TEntity>(model).State = EntityState.Modified;
            _DbContext.SaveChanges();
            return model;
        }

        TEntity IQuery<TEntity>.Find(params object[] keys)
        {
            return _DbSet.Find(keys);
        }

        IQueryable<TEntity> IQuery<TEntity>.AsQueryable()
        {
            return _DbSet.AsQueryable();
        }

        List<TEntity> IQuery<TEntity>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 实现IDispose接口，释放数据库上下文
        /// </summary>
        public void Dispose()
        {
            _DbContext.Dispose();
        }
    }
}
