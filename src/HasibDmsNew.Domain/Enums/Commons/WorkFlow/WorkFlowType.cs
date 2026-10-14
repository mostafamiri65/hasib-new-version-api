using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.WorkFlow
{
    public enum WorkFlowType
    {
        [Description("پیشنهاد و تصویب بودجه")]
        BudgetProposalAndApproved = 1,

        [Description("تامین اعتبار بودجه")]
        BudgetFunding = 3,

        [Description("اصلاح بودجه")]
        BudgetCorrection = 2,

        [Description("متمم بودجه")]
        Supplement = 4,

        [Description("ارزیابی عملکرد")]
        PerformanceEvaluation = 6,

        [Description("فرم صورت وضعیت")]
        BudgetContractStatusForm = 7
    }
}
