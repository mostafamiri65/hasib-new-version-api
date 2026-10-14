using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("YearActivityCalculationStatus")]
    public class YearActivityCalculationStatus
    {
        public int Id { get; set; }
        public int YearId { get; set; }
        public bool ActivityCalculationStatus { get; set; }
    }
}
