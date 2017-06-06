using System;

namespace Greata.Express.Repository.ContentDB
{
    using Model.DB;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    using Greata.Express.Repository.Interface;

    /// <summary>
    /// 内容数据库的仓库具体实现类
    /// </summary>
    /// <typeparam name="TEntity">数据实体类型</typeparam>
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
            _DbContext = new GreataContentContext();
            _DbSet = _DbContext.Set<TEntity>();
        }

        IQueryable<TEntity> IQuery<TEntity>.AsQueryable()
        {
            return _DbSet.AsQueryable();
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

        /// <summary>
        /// 实现IDispose接口，关闭数据库上下文。
        /// </summary>
        public void Dispose()
        {
            _DbContext.Dispose(); ;
        }

        TEntity IQuery<TEntity>.Find(params object[] keys)
        {
            return _DbSet.Find(keys);
        }

        List<TEntity> IQuery<TEntity>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
