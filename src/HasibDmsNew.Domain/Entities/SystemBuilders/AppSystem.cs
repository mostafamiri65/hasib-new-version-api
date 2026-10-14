using System;
using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.SystemBuilders
{
    public class AppSystem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
        public string SelectedLayout { get; set; }  // modern, classic, dark, corporate
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<DynamicReport> DynamicReports { get; set; }

        public AppSystem()
        {
            Menus = new HashSet<Menu>();
            DynamicReports = new HashSet<DynamicReport>();
            IsActive = true;
            CreatedAt = DateTime.Now;
            SelectedLayout = "modern";
        }
    }
}
