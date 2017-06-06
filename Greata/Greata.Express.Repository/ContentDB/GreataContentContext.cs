namespace Greata.Express.Repository.ContentDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Model.DB;

    /// <summary>
    /// Greata�������ݿ�(SharePoint)������
    /// </summary>
    public partial class GreataContentContext : DbContext
    {
        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        public GreataContentContext()
            : base("name=GreataDBServer")
        {
        }        
        
        /// <summary>
        /// GCard_Exp_Contractʵ�弯
        /// </summary>
        public virtual DbSet<GCard_Exp_Contract> GCard_Exp_Contract { get; set; }

        /// <summary>
        /// OnModelCreating�¼�������ʵ�����ԺͶ�Ӧ��
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Greata.Express.Model.DB.GCard_Exp_Contract>()
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Greata.Express.Model.DB.GCard_Exp_Contract>()
                .ToTable("vw_sp_list_GCard_Exp_Contract");
        }
    }
}
