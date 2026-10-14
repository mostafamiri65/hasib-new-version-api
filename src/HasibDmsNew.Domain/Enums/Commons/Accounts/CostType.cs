using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Accounts
{
    /// <summary>
    /// نوع هزینه
    /// </summary>
    public enum CostType
    {
        [Description("مواد مستقیم")]
        DirectMaterial = 1,

        [Description("دستمزد مستقیم")]
        DirectWage = 2,

        [Description("هزینه غیر مستقیم")]
        IndirectCost = 3,

        [Description("هزینه غیر مستقیم - دستمزد")]
        IndirectCostSalary = 10,

        [Description("مراکز پشتیبانی")]
        SupportCenter = 4,

        [Description("دارایی ها")]
        Assets = 5,

        [Description("درآمدها")]
        Revenues = 6,

        [Description("بدهی ها")]
        Debts = 7,

        [Description("حقوق مالکانه")]
        OwnershipRights = 8,

        [Description("هزینه های سرمایه ای")]
        CapitalCost = 9,

        [Description("سایر")]
        Other = 0
    }
}
