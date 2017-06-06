using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Greata.Express.Repository.Interface;

namespace Greata.Express.Repository.BusinessDB
{
    /// <summary>
    /// 业务数据库的仓库查询
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Query<TEntity> : Interface.IQuery<TEntity>
        where TEntity : class
    {
        readonly DbContext _DbContext;
        readonly DbSet<TEntity> _DbSet;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Query()
        {
            _DbContext = new GreataBusinessContext();
            _DbSet = _DbContext.Set<TEntity>();
        }

        IQueryable<TEntity> IQuery<TEntity>.AsQueryable()
        {
            return _DbSet.AsQueryable();
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
