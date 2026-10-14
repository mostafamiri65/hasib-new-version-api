using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.CostCenter
{
    public enum CostCenterType
    {
        [Description("شرکت مستقل (داخلی)")]
        IndependentCompanyDomestic = 1,
        [Description("شعبه وابسته (داخلی)")]
        AffiliatedBranchDomestic = 2,
        [Description("شرکت مستقل (خارجی) ")]
        IndependentForeign = 3
    }
}
