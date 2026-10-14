namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class WorkFlowStepActivityForm
    {
        public WorkFlowStepActivity WorkFlowStepActivity { get; set; }
        public int WorkFlowStepActivityId { get; set; }

        public WorkFlowStep WorkFlowStep { get; set; }
        public int WorkFlowStepId { get; set; }

        public WorkFlowForm WorkFlowForm { get; set; }
        public int WorkFlowFormId { get; set; }

        public string Value { get; set; }
    }
}
