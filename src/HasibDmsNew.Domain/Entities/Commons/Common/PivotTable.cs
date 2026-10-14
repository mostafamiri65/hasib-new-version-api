using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("PivotTables")]
    public class PivotTable
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Form")]
        public int FormId { get; set; }
        public virtual Form Form { get; set; }
        public string CornerCellValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<PivotTableColumn> Columns { get; set; }
        public virtual ICollection<PivotTableRow> Rows { get; set; }
        public virtual ICollection<PivotTableCell> Cells { get; set; }
    }
}
