using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("PivotFormDataValueDetails")]
    public class PivotFormDataValueDetail
    {
        public int Id { get; set; }
        public int PivotFormDataValueId { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public string Value { get; set; }
        public string RawValue { get; set; }
    }
}
