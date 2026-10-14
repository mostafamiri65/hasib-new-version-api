using System;
using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.SystemBuilders
{
    public class DynamicReport
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AppSystemId { get; set; }
        public string Description { get; set; }
        public int ReportType { get; set; }  // 1: جدولی, 2: نموداری, 3: خلاصه

        public string SourceJson { get; set; }
        public string FilterJson { get; set; }
        public string ColumnConfigJson { get; set; }

        public bool IsPublic { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual AppSystem System { get; set; }
        public virtual ICollection<ReportPermission> Permissions { get; set; }

        public DynamicReport()
        {
            Permissions = new HashSet<ReportPermission>();
            IsPublic = true;
            CreatedAt = DateTime.Now;
            ReportType = 1;
        }
    }
}
