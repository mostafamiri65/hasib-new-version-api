using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.WorkFlow
{
    public enum WorkFlowShowType
    {
        [Description("ویرایش")]
        Edit = 1,
        [Description("جزئیات")]
        Detail,
        [Description("گزارش")]
        Report,
        [Description("باز")]
        BeachEdit,
        [Description("ویرایش مدیریت")]
        ManageEdit
    }
}
