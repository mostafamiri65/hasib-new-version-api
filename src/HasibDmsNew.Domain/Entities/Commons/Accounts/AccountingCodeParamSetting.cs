using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Entities.Commons.Accounts
{
    [DisplayName("تنظیمات پارامتر")]
    public class AccountingCodeParamSetting
    {
        [Display(Name = "شناسه ")]
        public int AccountingCodeParamId { get; set; }
        public virtual AccountingCodeParam AccountingCodeParam { get; set; }

        [Display(Name = "کدهای واسطه ")]
        public string RelatedCodeIds { get; set; }

        [Display(Name = "پارامتر می باشد")]
        public bool IsParam { get; set; }
    }
}
