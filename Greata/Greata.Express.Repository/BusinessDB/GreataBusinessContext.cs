namespace Greata.Express.Repository.BusinessDB
{
    using Greata.Express.Model.DB;
    using Model.DB.Lookup;
    using System;
    using System.Data.Entity;
    using System.Linq;

    /// <summary>
    /// Greata业务数据库操作上下文
    /// </summary>
    public class GreataBusinessContext : DbContext
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public GreataBusinessContext()
            : base("name=GreataBusinessDB")
        {
            //Database.SetInitializer<GreataBusinessModel>(new CreateDatabaseIfNotExists<GreataBusinessModel>());
            //Database.SetInitializer<GreataBusinessModel>(null);
        }

        /// <summary>
        /// GCard_Exp_Contract的数据实体集
        /// </summary>
        public virtual DbSet<GCard_Exp_Contract> GCard_Exp_Contract { get; set; }
        /// <summary>
        /// AccessToken的数据实体集
        /// </summary>
        public virtual DbSet<AccessToken> AccessToken { get; set; }

        /// <summary>
        /// OnModelCreating事件，设置实体属性
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.DB.GCard_Exp_Contract>()
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}