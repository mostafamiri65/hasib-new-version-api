using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("PivotTableCells")]
    public class PivotTableCell
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PivotTable")]
        public int PivotTableId { get; set; }
        public virtual PivotTable PivotTable { get; set; }

        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        [MaxLength(50)]
        public string Type { get; set; } // text, number, formula

        [MaxLength(4000)]
        public string Value { get; set; }

        [MaxLength(2000)]
        public string Formula { get; set; }

        [MaxLength(4000)]
        public string RawValue { get; set; }

        public bool IsRequired { get; set; }

        public string Category { get; set; } // 'none', 'product_service', 'contract'
        public string CategoryType { get; set; } // 'product', 'service'

        public bool IsDynamic { get; set; }
        public string DynamicOperation { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string FormatJson { get; set; }
    }
}
