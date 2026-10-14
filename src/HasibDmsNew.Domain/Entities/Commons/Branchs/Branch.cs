using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Costing.ABC;
using HasibDmsNew.Domain.Enums.Commons.Branchs;
using HasibDmsNew.Domain.Enums.Commons.CostCenter;

namespace HasibDmsNew.Domain.Entities.Commons.Branchs
{
    //واحد سازمانی
    public class Branch
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public BranchOperationType OperationTypeId { get; set; }
        public int BranchParameterId { get; set; }
        public int? CostCenterTreeTitleId { get; set; }
        public CostCenterType CostCenterType { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<UnitCapacity> UnitCapacites { get; set; }
        public ICollection<UnitItemCapacity> UnitItemCapacites { get; set; }
        public ICollection<UnitItemActivityCapacity> UnitItemActivityCapacites { get; set; }
    }
}
