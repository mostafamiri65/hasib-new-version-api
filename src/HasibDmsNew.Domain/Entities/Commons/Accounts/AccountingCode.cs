using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Entities.Commons.Accounts
{
    [DisplayName("کد تراز")]
    public class AccountingCode
    {
        [Display(Name = "شناسه ")]
        public int Id { get; set; }

        [Display(Name = "عنوان ")]
        public string Title { get; set; }

        [Display(Name = "کد ")]
        public string Code { get; set; }

        [Display(Name = "نوع ")]
        public byte TypeId { get; set; }

        [Display(Name = "ماهیت")]
        public bool IsIncrease { get; set; }
    }
}
