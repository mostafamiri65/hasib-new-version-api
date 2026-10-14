using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Sepah
{
    [Table("SepahForm1Edgami")]
    public class SepahForm1Edgami
    {
        [Key]
        public int Id { get; set; }
        public int SepahFormID { get; set; }
        public SepahFormInfo SepahForm { get; set; }
        public string NewBranchName { get; set; }
        public string UnitCode { get; set; }
        public string BankName { get; set; }
        public string AccountingCode { get; set; }
        public long DebtorBalance { get; set; }
        public long CreditBalance { get; set; }
        public string OldBranchCode { get; set; }
        public string AccountingName { get; set; }
        public string OldAccountingCode { get; set; }
        public string OldAccountingName { get; set; }
        public long Debtor { get; set; }
        public long Creditor { get; set; }
    }
}
