using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class WorkFlowForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Title { get; set; }
        public byte Type { get; set; }
        public byte ProgramType { get; set; }
        public bool IsDynamic { get; set; }
        public byte? Step { get; set; }

        public virtual ICollection<WorkFlowStepForm> WorkFlowStepForms { get; set; }
    }
}
