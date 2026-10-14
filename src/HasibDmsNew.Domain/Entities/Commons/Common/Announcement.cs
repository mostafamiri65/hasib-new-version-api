using System;
using System.ComponentModel.DataAnnotations;
using HasibDmsNew.Domain.Enums.Commons.Common;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    public class Announcement
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "عنوان اطلاعیه الزامی است")]
        [Display(Name = "عنوان اطلاعیه")]
        [MaxLength(200, ErrorMessage = "عنوان نمی‌تواند بیشتر از 200 کاراکتر باشد")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "موضوع اطلاعیه الزامی است")]
        [Display(Name = "موضوع اطلاعیه")]
        [MaxLength(500, ErrorMessage = "موضوع نمی‌تواند بیشتر از 500 کاراکتر باشد")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "نرم‌افزار مرتبط الزامی است")]
        [Display(Name = "نرم‌افزار مرتبط")]
        [MaxLength(100)]
        public string SoftwareName { get; set; } = string.Empty;

        [Required(ErrorMessage = "تاریخ شروع فعال‌سازی الزامی است")]
        [Display(Name = "تاریخ شروع فعال‌سازی")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "تاریخ پایان فعال‌سازی الزامی است")]
        [Display(Name = "تاریخ پایان فعال‌سازی")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "نوع محتوا الزامی است")]
        [Display(Name = "نوع محتوا")]
        public ContentType ContentType { get; set; }

        [Display(Name = "متن اطلاعیه")]
        public string ContentText { get; set; }

        [Display(Name = "نام فایل")]
        [MaxLength(255)]
        public string FileName { get; set; }

        [Display(Name = "مسیر فایل")]
        public string FilePath { get; set; }

        [Display(Name = "فعال است")]
        public bool IsActive { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "تاریخ آخرین بروزرسانی")]
        public DateTime? UpdatedAt { get; set; }

        [Display(Name = "ایجاد کننده")]
        public int CreatedBy { get; set; }
    }
}
