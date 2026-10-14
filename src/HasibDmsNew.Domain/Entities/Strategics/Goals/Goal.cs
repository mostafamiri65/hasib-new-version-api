using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Strategics.Goals
{
    public class Goal
    {
        public Goal()
        {
            GoalCostCenters = new List<GoalCostCenter>();
        }

        public int GoalId { get; set; }
        public string Title { get; set; }
        public int? ParentId { get; set; }
        public bool IsLeaf { get; set; }
        public int GoalTypeId { get; set; }
        public int GoalTreeTitleId { get; set; }
        public string Code { get; set; }
        public List<GoalCostCenter> GoalCostCenters { get; set; }
    }
}
