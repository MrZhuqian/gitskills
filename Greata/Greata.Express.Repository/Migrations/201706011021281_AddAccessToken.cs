namespace Greata.Express.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccessToken : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccessTokens",
                c => new
                    {
                        Token = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(),
                        LastAccess = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Token);
            
            CreateTable(
                "dbo.GCard_Exp_Contract",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modified = c.DateTime(),
                        Created = c.DateTime(),
                        ContentTypeId = c.Binary(),
                        Title = c.String(maxLength: 255),
                        Author_Company_Logo_URL = c.String(maxLength: 255),
                        Author_Project_Logo_URL = c.String(maxLength: 255),
                        Display_Name = c.String(maxLength: 255),
                        Distributed = c.Boolean(),
                        Doc_Subtype_Name = c.String(maxLength: 255),
                        GCard_Attach_Desc = c.String(),
                        GCard_Description = c.String(),
                        GCard_Language = c.String(maxLength: 255),
                        General_Participant = c.String(),
                        Imported_GCard = c.Boolean(),
                        Initiating_Participant = c.String(maxLength: 255),
                        Number = c.String(maxLength: 255),
                        Project_Id = c.String(maxLength: 255),
                        Receiving_Participant = c.String(maxLength: 255),
                        Source_Company = c.String(maxLength: 255),
                        Source_Contact = c.String(maxLength: 255),
                        Con_Actual_Del_Date = c.DateTime(),
                        Con_Actual_Start_Date = c.DateTime(),
                        Con_Approved_CO = c.Double(),
                        Con_Approved_Date = c.DateTime(),
                        Con_Assoc_Contract = c.Boolean(),
                        Con_Bank_Code = c.Int(),
                        Con_Bck_Charge_Rules = c.String(),
                        Con_Billing_Rule = c.String(maxLength: 255),
                        Con_CCIP_Active = c.Boolean(),
                        Con_Closed_Date = c.DateTime(),
                        Con_Commitment_Type = c.String(maxLength: 255),
                        Con_Cost_Period = c.Int(),
                        Con_Curr_Invoiced = c.Double(),
                        Con_Currency = c.String(maxLength: 255),
                        Con_Currency_Prec = c.Double(),
                        Con_Current_Comp_Date = c.DateTime(),
                        Con_Final_Act_Days_To = c.Double(),
                        Con_Final_Cur_Days_To = c.Double(),
                        Con_Final_Org_Days_To = c.Double(),
                        Con_Internal_Period = c.Int(),
                        Con_Inv_option = c.String(maxLength: 255),
                        Con_Inv_Upto_Pct = c.Double(),
                        Con_Is_Using_Ret = c.Boolean(),
                        Con_Issued_Date = c.DateTime(),
                        Con_Markup_Code = c.Int(),
                        Con_Max_Amt = c.Double(),
                        Con_Minority_Class = c.Int(),
                        Con_Notice_Date = c.DateTime(),
                        Con_OCIP_Active = c.Boolean(),
                        Con_Official_Date = c.DateTime(),
                        Con_Org_Value = c.Double(),
                        Con_Orig_Duration = c.Double(),
                        Con_Pay_When_Paid = c.Boolean(),
                        Con_Pymt_Allowed = c.Boolean(),
                        Con_Pymt_Terms = c.String(),
                        Con_Scope_Of_Work = c.String(),
                        Con_Shw_Adv_Date = c.Boolean(),
                        Con_Shw_Unit_Price = c.Boolean(),
                        Con_Sign_Received = c.Boolean(),
                        Con_Source_Bid_Package = c.String(maxLength: 255),
                        Con_Std_Clauses = c.String(),
                        Con_Vendor_Code = c.String(maxLength: 255),
                        Con_Work_Class = c.Int(),
                        GCard_Contract_Current_State = c.String(maxLength: 255),
                        GCard_Contract_Next_Action = c.String(maxLength: 255),
                        Con_Curr_Retainage = c.Double(),
                        Con_Inv_Allowed = c.Boolean(),
                        Workflow_CC = c.String(maxLength: 255),
                        Workflow_Custom_Msg = c.String(maxLength: 255),
                        Workflow_HCC = c.String(maxLength: 255),
                        Workflow_HTo = c.String(maxLength: 255),
                        Workflow_Next_Action = c.String(maxLength: 255),
                        Workflow_Priority = c.String(maxLength: 255),
                        Workflow_Recipient_Action = c.String(maxLength: 255),
                        Workflow_To = c.String(maxLength: 255),
                        ExpConWF = c.String(maxLength: 255),
                        CM_Awarding_Comp = c.String(maxLength: 255),
                        CM_Awarding_Contact = c.String(maxLength: 255),
                        CM_Managing_Comp = c.String(maxLength: 255),
                        CM_Managing_Contact = c.String(maxLength: 255),
                        CM_Receiving_Comp = c.String(maxLength: 255),
                        CM_Receiving_Contact = c.String(maxLength: 255),
                        Con_Exp_Memo = c.String(),
                        Con_exp_Note = c.String(),
                        Con_Exp_Inscopenumber = c.Double(),
                        Contract_Exp_sorts = c.String(maxLength: 255),
                        Con_exp_Description = c.String(),
                        Con_Exp_Cashinternalperiod = c.String(maxLength: 255),
                        Con_Exp_Cashcostperiod = c.String(maxLength: 255),
                        Exp_Con_Parties_Note = c.String(),
                        ReviewStatus = c.String(maxLength: 255),
                        Exp_Contract_Closed = c.Boolean(),
                        GCard_Curr_RS_Info = c.String(maxLength: 255),
                        Con_Comstatus = c.String(maxLength: 255),
                        SendedToXT = c.Boolean(),
                        Exp_Con_category2 = c.Int(),
                        Exp_Con_Paytype = c.Int(),
                        Exp_Con_Type1 = c.Int(),
                        Con_Category = c.String(maxLength: 255),
                        CM_Receiving_Comp1 = c.String(maxLength: 255),
                        CM_Receiving_Contact1 = c.String(maxLength: 255),
                        XietongRecordStatus = c.String(maxLength: 255),
                        RelatedProject = c.Int(),
                        Declaration_ProjectName = c.String(maxLength: 255),
                        Declaration_Number = c.String(maxLength: 255),
                        Declaration_Attach = c.String(maxLength: 255),
                        Declaration_ProjectName0 = c.String(maxLength: 255),
                        Xietong_ReviewStatus = c.String(maxLength: 255),
                        FirstApproveResult = c.String(maxLength: 255),
                        SecondApproveResult = c.String(maxLength: 255),
                        StateAuditResult = c.String(maxLength: 255),
                        ConstructionType = c.String(maxLength: 255),
                        XietongDestructionStatus = c.String(maxLength: 255),
                        AgreementStatus = c.String(maxLength: 255),
                        ConstructorOpinion = c.String(),
                        supervisorOpinion = c.String(),
                        Con_Orig_Del_Date = c.DateTime(),
                        Con_Orig_Start_Date = c.DateTime(),
                        Con_Pending_Change = c.Double(),
                        Con_Practical_Act_Days_To = c.Double(),
                        Con_Practical_Cur_Days_To = c.Double(),
                        Con_Practical_Org_Days_To = c.Double(),
                        Con_Pymt_Due = c.Double(),
                        Con_Req_Date = c.DateTime(),
                        Con_Ret_Gen_Work = c.Double(),
                        Con_Sch_Comp_Date = c.DateTime(),
                        Con_Sch_Del_Date = c.DateTime(),
                        Con_Substantial_Act = c.DateTime(),
                        Con_Substantial_Cur = c.DateTime(),
                        Con_Substantial_Org = c.DateTime(),
                        Con_To_Date_Change = c.Double(),
                        Workflow_Due_Date = c.DateTime(),
                        Con_Exp_Exscopenumber = c.Double(),
                        Con_exp_schedule_Amount = c.Double(),
                        Con_exp_Number = c.Double(),
                        Con_Exp_Alscopenumber = c.Double(),
                        Exp_Contract_Closed_Date = c.DateTime(),
                        Exp_Con_BudgetAMT = c.Double(),
                        Exp_Con_ApplyAMT = c.Double(),
                        FirstApprovePrice = c.Double(),
                        SecondApprovePrice = c.Double(),
                        StateAuditPrice = c.Double(),
                        AuditUpdateTime = c.DateTime(),
                        QualityGuaranteeStartDate = c.DateTime(),
                        QualityGuaranteeEndDate = c.DateTime(),
                        HasReview = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GCard_Exp_Contract");
            DropTable("dbo.AccessTokens");
        }
    }
}
