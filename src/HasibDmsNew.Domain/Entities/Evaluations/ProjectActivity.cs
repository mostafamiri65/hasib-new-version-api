using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Commons.Years;
using HasibDmsNew.Domain.Entities.Strategics.Goals;

namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class ProjectActivity
    {
        public ProjectActivity()
        {
            Branchs = new List<ProjectActivityBranch>();
            IndicatorGoals = new List<IndicatorGoal>();
            IndicatorStructureWeights = new List<IndicatorStructureWeight>();
            IndicatorCriterionSettings = new List<IndicatorCriterionSetting>();
            IndicatorCriterions = new List<IndicatorCriterion>();
            IndicatorCriterionCostCenters = new List<IndicatorCriterionCostCenters>();
        }

        public int Id { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public int FiscalYearId { get; set; }
        public FiscalYear FiscalYear { get; set; }
        public int GoalTreeTitleId { get; set; }
        public GoalTreeTitle GoalTreeTitle { get; set; }

        public List<ProjectActivityBranch> Branchs { get; set; }
        public List<IndicatorGoal> IndicatorGoals { get; set; }
        public List<IndicatorStructureWeight> IndicatorStructureWeights { get; set; }
        public List<IndicatorCriterionSetting> IndicatorCriterionSettings { get; set; }
        public List<IndicatorCriterion> IndicatorCriterions { get; set; }
        public List<IndicatorCriterionCostCenters> IndicatorCriterionCostCenters { get; set; }
    }
}
