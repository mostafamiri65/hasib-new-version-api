using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Sepah
{
    [Table("SepahForm1Setting")]
    public class SepahForm1Setting
    {
        [Key]
        public int Id { get; set; }
        public int Priority { get; set; }
        public int SepahFormInfoId { get; set; }
        public int MasterCodeId { get; set; }
        public string RelatedCodeIds { get; set; }
        public byte BaseTypeId { get; set; }
    }
}
