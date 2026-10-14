using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Settings
{
    public enum CostAssignComputationType : byte
    {
        [Description("تخصیص هزینه های پرسنلی از طریق محرک هزینه")]
        AssignWithCostDriver = 1,
        [Description("تخصیص هزینه پرسنلی ازطریق سهم دهی به فعالیت ها")]
        AssignWithPersonnelActivityShare = 2
    }
}
