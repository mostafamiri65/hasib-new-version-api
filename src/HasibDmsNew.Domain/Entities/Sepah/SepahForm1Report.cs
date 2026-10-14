using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Sepah
{
    [Table("SepahForm1Report")]
    public class SepahForm1Report
    {
        [Key]
        public int Id { get; set; }
        public int SepahFormInfoId { get; set; }
        public string TR_CODHSB { get; set; }
        public string TR_BR { get; set; }
        public string TR_ADMIN { get; set; }
        public long TR_MANNEW { get { return TR_MANNEW_R + TR_MANNEW_A; } }
        public long TR_MANNEW_R { get; set; }
        public long TR_MANNEW_A { get; set; }
        public string TR_DAT { get; set; }
    }
}
