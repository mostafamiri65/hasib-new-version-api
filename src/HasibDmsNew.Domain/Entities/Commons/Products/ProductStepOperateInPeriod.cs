using HasibDmsNew.Domain.Entities.Commons.Years;

namespace HasibDmsNew.Domain.Entities.Commons.Products
{
    /// <summary>
    /// اقدام به عملیات در دوره
    /// </summary>
    public class ProductStepOperateInPeriod
    {
        public int Id { get; set; }
        public int ProductStepId { get; set; }
        public ProductStep ProductStep { get; set; }
        public int PeriodId { get; set; }
        public Period Period { get; set; }
        public decimal Completed { get; set; }
        public decimal Operated { get; set; }
        public int GoodCompleted { get; set; }
        public int FirstGoodDuringConstruction { get; set; }
        public int LastGoodDuringConstruction { get; set; }
        public int Wastes { get; set; }
        public int Reworked { get; set; }
        public int GoodProduced { get; set; }
        public decimal NormalWastes { get; set; }
        public decimal UnNormalWastes { get; set; }
        public int BranchId { get; set; }
        public decimal? InProgressStartPercent { get; set; }
        public decimal? InProgressEndPercent { get; set; }
        public decimal? WasteAndReworkPercent { get; set; }
    }
}
