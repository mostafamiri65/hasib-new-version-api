using System;
using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    public class ActivityItem
    {
        public ActivityItem()
        {
            IsLeaf = true;
            ActivityItemCostCenters = new List<ActivityItemCostCenter>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ParentCode { get; set; }
        public bool IsLeaf { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Path { get; set; }
        public int? ParentId { get; set; }
        public Activity Parent { get; set; }
        public int TreeTitleId { get; set; }
        public int ActivityTypeId { get; set; }
        public ICollection<ActivityItemCostCenter> ActivityItemCostCenters { get; set; }
    }
}
