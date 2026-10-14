using System;
using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Entities.BPMS
{
    public class BpmsProcess
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "نام فرآیند الزامی است")]
        [StringLength(200)]
        [Display(Name = "نام فرآیند")]
        public string Name { get; set; }

        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "کد فرآیند")]
        [StringLength(50)]
        public string Code { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "تاریخ آخرین ویرایش")]
        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "ایجاد کننده")]
        public string CreatedBy { get; set; }
    }
}
