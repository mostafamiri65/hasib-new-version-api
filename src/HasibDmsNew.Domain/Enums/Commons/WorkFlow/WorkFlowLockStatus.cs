using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.WorkFlow
{
    public enum WorkFlowLockStatus
    {
        [Description("قفل نیست")]
        UnLock = 1,

        [Description("قفل کردن گردش کارهای جدید")]
        NewLock
    }
}
