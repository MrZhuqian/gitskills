namespace Greata.Express.Model.DB.Lookup
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// һ��Ԥ�����
    /// </summary>
    public partial class BudgetCode_Lookup_L1
    {
        /// <summary>
        /// ϵͳ���
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// �������ʱ��
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? Created { get; set; }
        
        /// <summary>
        /// ����ID
        /// </summary>
        public byte[] ContentTypeId { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// Ԥ�������
        /// </summary>
        [StringLength(255)]
        public string Lookup_Code { get; set; }

        /// <summary>
        /// Ԥ���������
        /// </summary>
        [StringLength(255)]
        public string Lookup_Name { get; set; }

        /// <summary>
        /// ������Ŀ������ID
        /// </summary>
        [StringLength(255)]
        public string Project_Id { get; set; }
    }
}
