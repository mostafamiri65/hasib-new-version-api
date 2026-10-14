using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Enums.Commons.Drivers
{
    //نوع محرک
    public enum UnitType
    {
        [Description("محرک هزینه")]
        [Display(Name = "محرک هزینه")]
        CostDriver = 1,

        [Description("محرک فعالیت")]
        [Display(Name = "محرک فعالیت")]
        ActivityDriver = 2,

        [Description("محرک هزینه و فعالیت")]
        [Display(Name = "محرک هزینه و فعالیت")]
        ActivityCostDriver = 3
    }

    public enum CalculationMethodDriverFormula
    {
        [Description("ساده")]
        [Display(Name = "ساده")]
        Normal = 1,

        [Description("دارای فرمول")]
        [Display(Name = "دارای فرمول")]
        HaveFormula = 2
    }
}
