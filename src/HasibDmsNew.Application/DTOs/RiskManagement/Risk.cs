using System;
using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Application.DTOs.RiskManagement
{
    public class Risk
    {
        public int Id { get; set; }

        [Display(Name = "فرآیند مرتبط")]
        [Required(ErrorMessage = "لطفاً فرآیند را انتخاب کنید")]
        [MaxLength(200)]
        public string ProcessName { get; set; }

        [Display(Name = "شرح ریسک")]
        [Required(ErrorMessage = "شرح ریسک الزامی است")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "شدت اثر")]
        [Range(1, 5)]
        public int ImpactLevel { get; set; } = 1;

        [Display(Name = "احتمال وقوع")]
        [Range(1, 5)]
        public int ProbabilityLevel { get; set; } = 1;

        [Display(Name = "اولویت (نمره ریسک)")]
        public int RiskScore => ImpactLevel * ProbabilityLevel;

        [Display(Name = "وضعیت")]
        public string Status { get; set; } = "در حال بررسی";

        [Display(Name = "تاریخ شناسایی")]
        [DataType(DataType.Date)]
        public DateTime IdentificationDate { get; set; } = DateTime.Now;

        [Display(Name = "کاربر ایجاد کننده")]
        public string CreatedBy { get; set; }
    }

    public class RiskResponse
    {
        [Key]
        public int Id { get; set; }

        public int RiskId { get; set; }

        [Display(Name = "نوع پاسخ")]
        [Required]
        public string ResponseType { get; set; }

        [Display(Name = "اقدامات پیشنهادی")]
        [DataType(DataType.MultilineText)]
        public string ProposedActions { get; set; }

        [Display(Name = "مسئول اجرا")]
        [MaxLength(200)]
        public string ResponsiblePerson { get; set; }

        [Display(Name = "تاریخ سررسید")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
    }
}
