using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greata.Express.Repository.Interface
{
    /// <summary>
    /// Repository接口，提供针对数据集的增删改操作
    /// </summary>
    /// <typeparam name="TEntity">数据实体类型</typeparam>
    public interface IRepository<TEntity> : IQuery<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// 创建数据实体，并保存到仓库
        /// </summary>
        /// <param name="model">数据实体</param>
        /// <returns></returns>
        TEntity Create(TEntity model);

        /// <summary>
        /// 更新仓库中的数据实体
        /// </summary>
        /// <param name="model">数据实体</param>
        /// <returns></returns>
        TEntity Update(TEntity model);

        /// <summary>
        /// 从仓库中删除数据实体
        /// </summary>
        /// <param name="model">数据实体</param>
        void Delete(TEntity model);
    }
}
