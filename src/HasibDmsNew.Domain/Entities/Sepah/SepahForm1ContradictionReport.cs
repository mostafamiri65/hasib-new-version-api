using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Sepah
{
    [Table("SepahForm1ContradictionReport")]
    public class SepahForm1ContradictionReport
    {
        [Key]
        public int Id { get; set; }
        public int SepahFormInfoId { get; set; }
        public string TR_CODHSB { get; set; }
        public decimal Report185Price { get; set; }
        public decimal Positive_Report185Price
        {
            get { return Report185Price < 0 ? -Report185Price : Report185Price; }
        }
        public decimal ReportMergePrice { get; set; }
        public decimal Positive_ReportMergePrice
        {
            get { return ReportMergePrice < 0 ? -ReportMergePrice : ReportMergePrice; }
        }
        public decimal ReportMergePriceNoAmari { get; set; }
        public decimal Positive_ReportMergePriceNoAmari
        {
            get { return ReportMergePriceNoAmari < 0 ? -ReportMergePriceNoAmari : ReportMergePriceNoAmari; }
        }
        public decimal Difference
        {
            get { return Positive_Report185Price - Positive_ReportMergePriceNoAmari; }
        }
    }
}
