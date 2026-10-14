using System;

namespace HasibDmsNew.Domain.Entities.SystemBuilders
{
    public class ReportPermission
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public int CostCenterId { get; set; }
        public int PermissionLevel { get; set; }  // 1: مشاهده, 2: ویرایش/اجرا
        public DateTime CreatedAt { get; set; }

        public virtual DynamicReport Report { get; set; }

        public ReportPermission()
        {
            CreatedAt = DateTime.Now;
            PermissionLevel = 1;
        }
    }
}
