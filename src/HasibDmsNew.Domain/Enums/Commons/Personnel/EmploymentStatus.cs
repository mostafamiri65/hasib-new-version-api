using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Personnel
{
    public enum EmploymentStatus
    {
        [Description("قرارداد دائم")]
        PermanentContract = 1,
        [Description("قرارداد معین")]
        DefiniteContract = 2,
        [Description("قرارداد تامین نیرو")]
        PowerSupplyContract = 3,
        [Description("قرارداد حجمی")]
        VolumeContract = 4,
        [Description("قرارداد فنی و بهره برداری")]
        TechnicalAndOperationContract = 5
    }
}
