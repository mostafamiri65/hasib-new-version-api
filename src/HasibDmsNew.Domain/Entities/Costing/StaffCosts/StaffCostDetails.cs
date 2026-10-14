namespace HasibDmsNew.Domain.Entities.Costing.StaffCosts
{
    public class StaffCostDetails
    {
        public long StaffCostDetailsId { get; set; }
        public long StaffCostId { get; set; }
        public int StaffPartTotalCostId { get; set; }

        /// <summary>
        /// هزینه عددی نسبت درصد به کل مبلغ
        /// </summary>
        public decimal Cost { get; set; }

        public StaffCost StaffCost { get; set; }
        public StaffPartTotalCost StaffPartTotalCost { get; set; }
    }
}
