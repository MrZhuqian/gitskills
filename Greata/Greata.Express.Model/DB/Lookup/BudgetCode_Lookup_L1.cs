namespace Greata.Express.Model.DB.Lookup
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 一级预算编码
    /// </summary>
    public partial class BudgetCode_Lookup_L1
    {
        /// <summary>
        /// 系统序号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? Created { get; set; }
        
        /// <summary>
        /// 子类ID
        /// </summary>
        public byte[] ContentTypeId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// 预算编码编号
        /// </summary>
        [StringLength(255)]
        public string Lookup_Code { get; set; }

        /// <summary>
        /// 预算编码名称
        /// </summary>
        [StringLength(255)]
        public string Lookup_Name { get; set; }

        /// <summary>
        /// 所属项目工作区ID
        /// </summary>
        [StringLength(255)]
        public string Project_Id { get; set; }
    }
}
