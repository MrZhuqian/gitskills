using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greata.Express.Repository.Interface
{
    /// <summary>
    /// 查询接口，提供针对仓库的查询方法。 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IQuery<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// 通过主键，获取数据实体
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        TEntity Find(params Object[] keys);

        /// <summary>
        /// 返回针对数据实体的IQueryable对象
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> AsQueryable();

        /// <summary>
        /// 使用T-SQL查询数据实体集，返回满足要求的数据实体集
        /// </summary>
        /// <param name="sql">T-SQL语句</param>
        /// <param name="parameters">T-SQL语句中所需要的参数</param>
        /// <returns></returns>
        List<TEntity> SqlQuery(String sql, params Object[] parameters);
    }
}
