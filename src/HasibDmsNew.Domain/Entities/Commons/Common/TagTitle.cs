using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("TagTitles")]
    public class TagTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
