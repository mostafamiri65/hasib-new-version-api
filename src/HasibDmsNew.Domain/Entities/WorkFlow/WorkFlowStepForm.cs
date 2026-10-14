using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    [Table("WorkFlowStepForms")]
    public class WorkFlowStepForm
    {
        [Key, Column(Order = 1)]
        [ForeignKey("WorkFlowStep")]
        [Required(ErrorMessage = "شناسه مرحله الزامی است")]
        [Display(Name = "شناسه مرحله")]
        public int WorkFlowStepId { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("WorkFlowForm")]
        [Required(ErrorMessage = "شناسه فرم الزامی است")]
        [Display(Name = "شناسه فرم")]
        public int WorkFlowFormId { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual WorkFlowStep WorkFlowStep { get; set; }
        public virtual WorkFlowForm WorkFlowForm { get; set; }

        public WorkFlowStepForm()
        {
            CreatedDate = DateTime.Now;
        }

        public WorkFlowStepForm(int stepId, int formId)
        {
            WorkFlowStepId = stepId;
            WorkFlowFormId = formId;
            CreatedDate = DateTime.Now;
        }
    }
}
