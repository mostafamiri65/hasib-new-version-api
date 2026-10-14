using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("PivotTableRows")]
    public class PivotTableRow
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PivotTable")]
        public int PivotTableId { get; set; }
        public virtual PivotTable PivotTable { get; set; }

        public int RowNumber { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        public string RowName { get; set; }
        public int Order { get; set; }
    }
}
