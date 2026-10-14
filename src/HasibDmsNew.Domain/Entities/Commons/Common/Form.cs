using System;
using System.Collections.Generic;
using HasibDmsNew.Domain.Enums.Budgets;
using HasibDmsNew.Domain.Enums.Commons.Common;
using HasibDmsNew.Domain.Enums.Commons.WorkFlow;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    public class Form
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public FormTypeEnum FormType { get; set; } = FormTypeEnum.General;
        public WorkFlowType WorkFlowType { get; set; }
        public Guid FormBatchId { get; set; }
        public int RowsCount { get; set; }
        public int ColumnsCount { get; set; }
        public string FormNumber { get; set; }
        public BudgetFormProposalTypeEnum BudgetFormProposalType { get; set; } = BudgetFormProposalTypeEnum.None;
        public bool UsedInWorkFlow { get; set; }
        public List<FormField> FormFields { get; set; }
        public string LayoutJson { get; set; }
        public string CustomHeader { get; set; }
        public string StaticImage { get; set; }
        public bool BorderEnabled { get; set; }
        public string BorderStyle { get; set; }
        public string BorderColor { get; set; }
        public string BorderWidth { get; set; }
    }
}
