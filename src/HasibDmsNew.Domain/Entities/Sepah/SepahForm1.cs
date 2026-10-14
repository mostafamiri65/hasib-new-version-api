using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Sepah
{
    [Table("SepahForm1")]
    public class SepahForm1
    {
        [Key]
        public int Id { get; set; }
        public int SepahFormID { get; set; }
        public SepahFormInfo SepahForm { get; set; }
        public string TR_COD { get; set; }
        public string TR_CODHSB { get; set; }
        public string TR_BR { get; set; }
        public string TR_ADMIN { get; set; }
        public string TR_MANOLD { get; set; }
        public string TR_BD { get; set; }
        public string TR_BS { get; set; }
        public string TR_MANNEW { get; set; }
        public string TR_DAT { get; set; }
        public string TR_FLAG { get; set; }
    }
}
