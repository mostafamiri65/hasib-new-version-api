using System;

namespace HasibDmsNew.Domain.Entities.SystemBuilders
{
    public class MenuPermission
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int CostCenterId { get; set; }
        public int PermissionLevel { get; set; }  // 1: مشاهده, 2: اجرا/ویرایش
        public int? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Menu Menu { get; set; }

        public MenuPermission()
        {
            CreatedAt = DateTime.Now;
            PermissionLevel = 1;
        }
    }
}
