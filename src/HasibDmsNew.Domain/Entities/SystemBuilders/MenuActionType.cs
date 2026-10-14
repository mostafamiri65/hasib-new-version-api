using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.SystemBuilders
{
    public class MenuActionType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }  // form, report, workflow, url, dashboard

        public virtual ICollection<Menu> Menus { get; set; }

        public MenuActionType()
        {
            Menus = new HashSet<Menu>();
        }
    }
}
