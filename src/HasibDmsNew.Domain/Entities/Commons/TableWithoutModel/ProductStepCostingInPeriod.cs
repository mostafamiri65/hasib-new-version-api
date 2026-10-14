using HasibDmsNew.Domain.Entities.Commons.Products;
using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class ProductStepCostingInPeriod
    {
        public int ProductStepId { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public int PeriodId { get; set; }
        public decimal OneActivityCosting { get; set; }
        public decimal TotalActivityCosting { get; set; }
        public decimal RealOneActivityCosting { get; set; }
        public decimal RealTotalActivityCosting { get; set; }
        public decimal OneDirectCostCosting { get; set; }
        public decimal TotalDirectCostCosting { get; set; }
        public decimal RealOneDirectCostCosting { get; set; }
        public decimal RealTotalDirectCostCosting { get; set; }
        public decimal OneDirectWageCosting { get; set; }
        public decimal TotalDirectWageCosting { get; set; }
        public decimal RealOneDirectWageCosting { get; set; }
        public decimal RealTotalDirectWageCosting { get; set; }
        public decimal OneSupportCenterCosting { get; set; }
        public decimal TotalSupportCenterCosting { get; set; }
        public decimal RealOneSupportCenterCosting { get; set; }
        public decimal RealTotalSupportCenterCosting { get; set; }
        public decimal OneStaffBranchCosting { get; set; }
        public decimal TotalStaffBranchCosting { get; set; }
        public decimal OneCosting { get; set; }
        public decimal TotalCosting { get; set; }
        public decimal RealOneCosting { get; set; }
        public decimal RealTotalCosting { get; set; }
        public decimal Completed { get; set; }
        public decimal Moving { get; set; }
        public decimal WastesPrice { get; set; }

        public virtual Period Period { get; set; }
        public virtual ProductStep ProductStep { get; set; }
    }
}
