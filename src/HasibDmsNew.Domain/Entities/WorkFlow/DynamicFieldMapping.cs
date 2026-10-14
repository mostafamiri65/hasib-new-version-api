using System;
using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Commons.Common;

namespace HasibDmsNew.Domain.Entities.WorkFlow
{
    public class DynamicFieldMapping
    {
        public int Id { get; set; }
        public int TargetCellId { get; set; }
        public int FormId { get; set; }
        public int StepId { get; set; }
        public string Expression { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual PivotTableCell TargetCell { get; set; }
        public virtual Form Form { get; set; }
        public virtual ICollection<DynamicFieldSource> Sources { get; set; }
    }

    public class DynamicFieldSource
    {
        public int Id { get; set; }
        public int MappingId { get; set; }
        public int FormId { get; set; }
        public int StepId { get; set; }
        public int CellId { get; set; }
        public string CellAddress { get; set; }
        public string CellValue { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DynamicFieldMapping Mapping { get; set; }
        public virtual Form Form { get; set; }
        public virtual PivotTableCell Cell { get; set; }
    }
}
