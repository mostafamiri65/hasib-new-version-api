using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    public class Activity
    {
        public Activity()
        {
            IsLeaf = true;
            ActivityCostCenters = new List<ActivityCostCenter>();
            ActivityActivityItems = new List<ActivityActivityItem>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public bool IsLeaf { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Path { get; set; }
        public int? Type { get; set; }
        public int? Alternation { get; set; }

        public int? ActivityDriverId { get; set; }
        public int? BenchMarkID { get; set; }
        public int? ParentId { get; set; }
        public int? ActivityTypeId { get; set; }
        public Activity Parent { get; set; }
        public int TreeTitleId { get; set; }

        public ICollection<ActivityCostCenter> ActivityCostCenters { get; set; }
        public ICollection<ActivityActivityItem> ActivityActivityItems { get; set; }

        [ForeignKey(nameof(ActivityTypeId))]
        public ActivityType ActivityType { get; set; }
    }
}
