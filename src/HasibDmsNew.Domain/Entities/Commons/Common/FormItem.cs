using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("FormItems")]
    public class FormItem
    {
        public int Id { get; set; }
        public int FormId { get; set; }

        [MaxLength(250)]
        public string ItemTitle { get; set; }

        public bool IsActive { get; set; }
    }
}
