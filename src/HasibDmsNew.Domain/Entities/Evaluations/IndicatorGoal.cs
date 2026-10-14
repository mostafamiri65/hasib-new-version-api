namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class IndicatorGoal
    {
        public int IndicatorGoalId { get; set; }
        public int IndicatorId { get; set; }
        public int GoalId { get; set; }
        public int ProjectActivityId { get; set; }
    }
}
