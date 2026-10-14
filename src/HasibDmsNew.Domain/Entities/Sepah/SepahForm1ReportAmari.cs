using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Sepah
{
    [Table("SepahForm1ReportAmari")]
    public class SepahForm1ReportAmari
    {
        [Key]
        public int Id { get; set; }
        public int SepahFormInfoId { get; set; }
        public int FormId { get; set; }
        public int AccountingCodeParamId { get; set; }
        public int? BranchId { get; set; }
        public int? CostCenterId { get; set; }
        public long Amount { get; set; }
    }
}
