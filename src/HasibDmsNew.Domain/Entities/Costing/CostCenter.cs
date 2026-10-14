using System;
using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Costing.ABC;

namespace HasibDmsNew.Domain.Entities.Costing
{
    public class CostCenter
    {
        public CostCenter()
        {
            IsLeaf = true;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public bool IsLeaf { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Path { get; set; }
        public int? ParentId { get; set; }
        public CostCenter Parent { get; set; }
        public int TreeTitleId { get; set; }
        public byte? Type { get; set; }

        public ICollection<UnitItemActivityCapacity> UnitItemActivityCapacites { get; set; }
    }
}
