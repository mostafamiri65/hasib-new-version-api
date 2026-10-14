using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Entities.Commons.Accounts
{
    [DisplayName("پارامتر")]
    public class AccountingCodeParam
    {
        [Display(Name = "شناسه ")]
        public int Id { get; set; }

        [Display(Name = "عنوان ")]
        public string Title { get; set; }

        [Display(Name = "کد ")]
        public string Code { get; set; }

        [Display(Name = "ماهیت")]
        public bool IsIncrease { get; set; }

        public bool ShowNegative { get; set; }
        public string ColorCode { get; set; }
        public virtual AccountingCodeParamSetting AccountingCodeParamSetting { get; set; }
    }
}
