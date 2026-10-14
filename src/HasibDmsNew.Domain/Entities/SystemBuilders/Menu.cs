using System;
using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.SystemBuilders
{
    public class Menu
    {
        public int Id { get; set; }
        public int AppSystemId { get; set; }
        public int? ParentMenuId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
        public int ActionTypeId { get; set; }

        public int? FormId { get; set; }
        public int? ReportId { get; set; }
        public int? WorkflowId { get; set; }
        public string Url { get; set; }

        public bool OpenInNewTab { get; set; }
        public bool IsActive { get; set; }
        public int RequiredPermissionLevel { get; set; }  // 1: مشاهده, 2: اجرا
        public DateTime CreatedAt { get; set; }

        public virtual AppSystem System { get; set; }
        public virtual Menu ParentMenu { get; set; }
        public virtual MenuActionType ActionType { get; set; }
        public virtual ICollection<Menu> SubMenus { get; set; }
        public virtual ICollection<MenuPermission> Permissions { get; set; }

        public Menu()
        {
            SubMenus = new HashSet<Menu>();
            Permissions = new HashSet<MenuPermission>();
            IsActive = true;
            RequiredPermissionLevel = 1;
            CreatedAt = DateTime.Now;
        }
    }
}
