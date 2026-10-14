using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("FormTagTitles")]
    public class FormTagTitle
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public int TagId { get; set; }
    }
}
