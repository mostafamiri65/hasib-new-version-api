using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager
{
    [Table("CostManagerProfit")]
    public class CostManagerProfit
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int FiscalYearId { get; set; }
        public decimal ReturnedRateWithoutRisk { get; set; }
        public decimal ReturnedRateOfMarket { get; set; }
        public decimal Profit { get; set; }
        public decimal TotalAssetsValue { get; set; }
        public decimal ReturnRateOfOrganization { get; set; }
    }
}
