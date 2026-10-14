using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    [Table("WorkFlowFormValue")]
    public class WorkFlowFormValue
    {
        public int Id { get; set; }
        public int WorkFlowStepActivityId { get; set; }
        public int WorkFlowFormId { get; set; }
        public int FormFieldId { get; set; }
        public string Value { get; set; }
    }
}
