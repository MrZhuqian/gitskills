namespace Greata.Express.Model.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    

    public partial class GCard_Exp_Contract
    {
        /// <summary>
        /// 系统序号
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 最近修改时间
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
        /// Title
        /// </summary>
        [StringLength(255)]
        public string Title { get; set; }

        /// <summary>
        /// 公司徽标
        /// </summary>
        [StringLength(255)]
        public string Author_Company_Logo_URL { get; set; }

        /// <summary>
        /// 项目徽标
        /// </summary>
        [StringLength(255)]
        public string Author_Project_Logo_URL { get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [StringLength(255)]
        public string Display_Name { get; set; }

        /// <summary>
        /// Distributed
        /// </summary>
        public bool? Distributed { get; set; }

        /// <summary>
        /// 之类名称
        /// </summary>
        [StringLength(255)]
        public string Doc_Subtype_Name { get; set; }

        /// <summary>
        /// 智讯卡附件描述
        /// </summary>
        public string GCard_Attach_Desc { get; set; }

        /// <summary>
        /// GCard_Description
        /// </summary>
        public string GCard_Description { get; set; }

        /// <summary>
        /// GCard_Language
        /// </summary>
        [StringLength(255)]
        public string GCard_Language { get; set; }

        /// <summary>
        /// General_Participant
        /// </summary>
        public string General_Participant { get; set; }

        /// <summary>
        /// Imported_GCard
        /// </summary>
        public bool? Imported_GCard { get; set; }

        /// <summary>
        /// Initiating_Participant
        /// </summary>
        [StringLength(255)]
        public string Initiating_Participant { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [StringLength(255)]
        public string Number { get; set; }

        /// <summary>
        /// 所属项目ID
        /// </summary>
        [StringLength(255)]
        public string Project_Id { get; set; }

        /// <summary>
        /// Receiving_Participant
        /// </summary>
        [StringLength(255)]
        public string Receiving_Participant { get; set; }

        /// <summary>
        /// Source_Company
        /// </summary>
        [StringLength(255)]
        public string Source_Company { get; set; }

        /// <summary>
        /// Source_Contact
        /// </summary>
        [StringLength(255)]
        public string Source_Contact { get; set; }

        /// <summary>
        /// 实际交付日期
        /// </summary>
        public DateTime? Con_Actual_Del_Date { get; set; }

        /// <summary>
        /// 实际开工日期
        /// </summary>
        public DateTime? Con_Actual_Start_Date { get; set; }

        /// <summary>
        /// 已批准的变更总额
        /// </summary>
        public double? Con_Approved_CO { get; set; }

        /// <summary>
        /// 合同批准日期
        /// </summary>
        public DateTime? Con_Approved_Date { get; set; }

        /// <summary>
        /// 关联合同
        /// </summary>
        public bool? Con_Assoc_Contract { get; set; }

        /// <summary>
        /// 银行代码
        /// </summary>
        public int? Con_Bank_Code { get; set; }

        /// <summary>
        /// 扣减规则
        /// </summary>
        public string Con_Bck_Charge_Rules { get; set; }

        /// <summary>
        /// 支付规则
        /// </summary>
        [StringLength(255)]
        public string Con_Billing_Rule { get; set; }

        /// <summary>
        /// 承包人控制保险程序
        /// </summary>
        public bool? Con_CCIP_Active { get; set; }

        /// <summary>
        /// 合同关闭日期
        /// </summary>
        public DateTime? Con_Closed_Date { get; set; }

        /// <summary>
        /// 合同承诺类型
        /// </summary>
        [StringLength(255)]
        public string Con_Commitment_Type { get; set; }

        /// <summary>
        /// 费用报告期（申请月份）
        /// </summary>
        public int? Con_Cost_Period { get; set; }

        /// <summary>
        /// 累计已支付（不含保留金）
        /// </summary>
        public double? Con_Curr_Invoiced { get; set; }

        /// <summary>
        /// 合同货币
        /// </summary>
        [StringLength(255)]
        public string Con_Currency { get; set; }

        /// <summary>
        /// 合同货币百分比
        /// </summary>
        public double? Con_Currency_Prec { get; set; }

        /// <summary>
        /// 当前预计完成时间
        /// </summary>
        public DateTime? Con_Current_Comp_Date { get; set; }

        /// <summary>
        /// 实际完成剩余天数
        /// </summary>
        public double? Con_Final_Act_Days_To { get; set; }

        /// <summary>
        /// 当前完成剩余天数
        /// </summary>
        public double? Con_Final_Cur_Days_To { get; set; }

        /// <summary>
        /// 原定完成剩余天数
        /// </summary>
        public double? Con_Final_Org_Days_To { get; set; }

        /// <summary>
        /// 内部报告期
        /// </summary>
        public int? Con_Internal_Period { get; set; }

        /// <summary>
        /// 支付申请选项
        /// </summary>
        [StringLength(255)]
        public string Con_Inv_option { get; set; }

        public double? Con_Inv_Upto_Pct { get; set; }

        public bool? Con_Is_Using_Ret { get; set; }

        public DateTime? Con_Issued_Date { get; set; }

        public int? Con_Markup_Code { get; set; }

        public double? Con_Max_Amt { get; set; }

        public int? Con_Minority_Class { get; set; }

        public DateTime? Con_Notice_Date { get; set; }

        public bool? Con_OCIP_Active { get; set; }

        public DateTime? Con_Official_Date { get; set; }

        public double? Con_Org_Value { get; set; }

        public double? Con_Orig_Duration { get; set; }

        public bool? Con_Pay_When_Paid { get; set; }

        public bool? Con_Pymt_Allowed { get; set; }
        
        public string Con_Pymt_Terms { get; set; }

        
        public string Con_Scope_Of_Work { get; set; }

        public bool? Con_Shw_Adv_Date { get; set; }

        public bool? Con_Shw_Unit_Price { get; set; }

        public bool? Con_Sign_Received { get; set; }

        [StringLength(255)]
        public string Con_Source_Bid_Package { get; set; }

        
        public string Con_Std_Clauses { get; set; }

        [StringLength(255)]
        public string Con_Vendor_Code { get; set; }

        public int? Con_Work_Class { get; set; }

        [StringLength(255)]
        public string GCard_Contract_Current_State { get; set; }

        [StringLength(255)]
        public string GCard_Contract_Next_Action { get; set; }

        public double? Con_Curr_Retainage { get; set; }

        public bool? Con_Inv_Allowed { get; set; }

        [StringLength(255)]
        public string Workflow_CC { get; set; }

        [StringLength(255)]
        public string Workflow_Custom_Msg { get; set; }

        [StringLength(255)]
        public string Workflow_HCC { get; set; }

        [StringLength(255)]
        public string Workflow_HTo { get; set; }

        [StringLength(255)]
        public string Workflow_Next_Action { get; set; }

        [StringLength(255)]
        public string Workflow_Priority { get; set; }

        [StringLength(255)]
        public string Workflow_Recipient_Action { get; set; }

        [StringLength(255)]
        public string Workflow_To { get; set; }

        [StringLength(255)]
        public string ExpConWF { get; set; }

        [StringLength(255)]
        public string CM_Awarding_Comp { get; set; }

        [StringLength(255)]
        public string CM_Awarding_Contact { get; set; }

        [StringLength(255)]
        public string CM_Managing_Comp { get; set; }

        [StringLength(255)]
        public string CM_Managing_Contact { get; set; }

        [StringLength(255)]
        public string CM_Receiving_Comp { get; set; }

        [StringLength(255)]
        public string CM_Receiving_Contact { get; set; }

        
        public string Con_Exp_Memo { get; set; }

        
        public string Con_exp_Note { get; set; }

        public double? Con_Exp_Inscopenumber { get; set; }

        [StringLength(255)]
        public string Contract_Exp_sorts { get; set; }

        
        public string Con_exp_Description { get; set; }

        [StringLength(255)]
        public string Con_Exp_Cashinternalperiod { get; set; }

        [StringLength(255)]
        public string Con_Exp_Cashcostperiod { get; set; }

        
        public string Exp_Con_Parties_Note { get; set; }

        [StringLength(255)]
        public string ReviewStatus { get; set; }

        public bool? Exp_Contract_Closed { get; set; }

        [StringLength(255)]
        public string GCard_Curr_RS_Info { get; set; }

        [StringLength(255)]
        public string Con_Comstatus { get; set; }

        public bool? SendedToXT { get; set; }

        public int? Exp_Con_category2 { get; set; }

        public int? Exp_Con_Paytype { get; set; }

        public int? Exp_Con_Type1 { get; set; }

        [StringLength(255)]
        public string Con_Category { get; set; }

        [StringLength(255)]
        public string CM_Receiving_Comp1 { get; set; }

        [StringLength(255)]
        public string CM_Receiving_Contact1 { get; set; }

        [StringLength(255)]
        public string XietongRecordStatus { get; set; }

        public int? RelatedProject { get; set; }

        [StringLength(255)]
        public string Declaration_ProjectName { get; set; }

        [StringLength(255)]
        public string Declaration_Number { get; set; }

        [StringLength(255)]
        public string Declaration_Attach { get; set; }

        [StringLength(255)]
        public string Declaration_ProjectName0 { get; set; }

        [StringLength(255)]
        public string Xietong_ReviewStatus { get; set; }

        [StringLength(255)]
        public string FirstApproveResult { get; set; }

        [StringLength(255)]
        public string SecondApproveResult { get; set; }

        [StringLength(255)]
        public string StateAuditResult { get; set; }

        [StringLength(255)]
        public string ConstructionType { get; set; }

        [StringLength(255)]
        public string XietongDestructionStatus { get; set; }

        [StringLength(255)]
        public string AgreementStatus { get; set; }

        
        public string ConstructorOpinion { get; set; }

        
        public string supervisorOpinion { get; set; }

        public DateTime? Con_Orig_Del_Date { get; set; }

        public DateTime? Con_Orig_Start_Date { get; set; }

        public double? Con_Pending_Change { get; set; }

        public double? Con_Practical_Act_Days_To { get; set; }

        public double? Con_Practical_Cur_Days_To { get; set; }

        public double? Con_Practical_Org_Days_To { get; set; }

        public double? Con_Pymt_Due { get; set; }

        public DateTime? Con_Req_Date { get; set; }

        public double? Con_Ret_Gen_Work { get; set; }

        public DateTime? Con_Sch_Comp_Date { get; set; }

        public DateTime? Con_Sch_Del_Date { get; set; }

        public DateTime? Con_Substantial_Act { get; set; }

        public DateTime? Con_Substantial_Cur { get; set; }

        public DateTime? Con_Substantial_Org { get; set; }

        public double? Con_To_Date_Change { get; set; }

        public DateTime? Workflow_Due_Date { get; set; }

        public double? Con_Exp_Exscopenumber { get; set; }

        public double? Con_exp_schedule_Amount { get; set; }

        public double? Con_exp_Number { get; set; }

        public double? Con_Exp_Alscopenumber { get; set; }

        public DateTime? Exp_Contract_Closed_Date { get; set; }

        public double? Exp_Con_BudgetAMT { get; set; }

        public double? Exp_Con_ApplyAMT { get; set; }

        public double? FirstApprovePrice { get; set; }

        public double? SecondApprovePrice { get; set; }

        public double? StateAuditPrice { get; set; }

        public DateTime? AuditUpdateTime { get; set; }

        public DateTime? QualityGuaranteeStartDate { get; set; }

        public DateTime? QualityGuaranteeEndDate { get; set; }

        public bool? HasReview { get; set; }
    }
}
