using Greata.Express.Model.DB;
using Greata.Express.Repository.Interface;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greata.Express.Repository.Factory
{
    /// <summary>
    /// Query的工厂类，用于生成IQuery对象。
    /// </summary>
    public class Query
    {
        /// <summary>
        /// 根据数据实体类型，返回默认的IQuery对象
        /// </summary>
        /// <typeparam name="TEntity">数据实体类型</typeparam>
        /// <returns></returns>
        public static IQuery<TEntity> Create<TEntity>()
            where TEntity : class
        {
            return Create<TEntity>("BusinessDB");
        }

        /// <summary>
        /// 根据数据实体类型，和指定的配置，返回IQuery对象。
        /// </summary>
        /// <typeparam name="TEntity">数据实体类型</typeparam>
        /// <param name="name">配置名称，如：BusinessDB或ContentDB</param>
        /// <returns></returns>
        public static IQuery<TEntity> Create<TEntity>(String name)
            where TEntity : class
        {
            IUnityContainer container = new UnityContainer();
            
            container.RegisterType<IQuery<GCard_Exp_Contract>, ContentDB.Repository<GCard_Exp_Contract>>("ContentDB");
            container.RegisterType<IQuery<GCard_Exp_Contract>, BusinessDB.Query<GCard_Exp_Contract>>("BusinessDB");

            return container.Resolve<IQuery<TEntity>>(name);
        }
    }
}
