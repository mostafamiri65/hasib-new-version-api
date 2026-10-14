using System;
using System.Collections.Generic;
using HasibDmsNew.Domain.Enums.Commons.Accounts;

namespace HasibDmsNew.Domain.Entities.Commons.Accounts
{
    /// <summary>
    /// هزینه ها
    /// </summary>
    public class Cost
    {
        public Cost()
        {
            IsLeaf = true;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public DateTime CreatedOn { get; set; }
        public CostType CostType { get; set; }
        public bool IsLeaf { get; set; }
        public string Path { get; set; }

        public int? ParentId { get; set; }
        public int? CostDriverId { get; set; }
        public int TreeTitleId { get; set; }
        public int? CostManagerTypeId { get; set; }
        public int? CostManagerMatrixTypeId { get; set; }
        public int MoneyUnitId { get; set; }
        public byte CostGroupClassificationId { get; set; }

        public ICollection<CostRateInPeriod> CostRateInPeriods { get; set; }
        public ICollection<CostMainCostCenter> MainCostCenters { get; set; }
    }
}
