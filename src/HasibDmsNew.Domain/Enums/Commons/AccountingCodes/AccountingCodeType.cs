using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Enums.Commons.AccountingCodes
{
    public enum AccountingCodeType
    {
        [Description("کل")]
        [Display(Name = "کل")]
        Kool = 1,

        [Description("معین")]
        [Display(Name = "معین")]
        Moein = 2,

        [Description("تفصیلی")]
        [Display(Name = "تفصیلی")]
        Tafzili = 3
    }
}
