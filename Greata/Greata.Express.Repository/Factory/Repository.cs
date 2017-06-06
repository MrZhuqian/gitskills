using Greata.Express.Model.DB;
using Greata.Express.Repository.Interface;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greata.Express.Repository.Factory
{
    /// <summary>
    /// Repository的工厂类，用于生成IRepository对象
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// 根据数据实体类型，返回默认的IRepository对象
        /// </summary>
        /// <typeparam name="TEntity">数据实体类型</typeparam>
        /// <returns></returns>
        public static IRepository<TEntity> Create<TEntity>()
            where TEntity : class
        {
            return Create<TEntity>("ContentDB");
        }

        /// <summary>
        /// 根据数据实体类型，和指定的配置，返回IRepository对象。
        /// </summary>
        /// <typeparam name="TEntity">数据实体类型</typeparam>
        /// <param name="name">配置名称，如：BusinessDB或ContentDB</param>
        /// <returns></returns>
        public static IRepository<TEntity> Create<TEntity>(String name)
            where TEntity : class
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IRepository<Model.DB.GCard_Exp_Contract>, ContentDB.Repository<Model.DB.GCard_Exp_Contract>>("ContentDB");

            container.RegisterType<IRepository<AccessToken>, BusinessDB.Repository<AccessToken>>("BusinessDB");

            return container.Resolve<IRepository<TEntity>>(name);
        }
    }
}
