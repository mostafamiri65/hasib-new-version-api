using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Accounts
{
    //نوع پیش‌فرض بایستی مقدار 1 داشته باشد چون در دیتابیس نیز با این مقدار کوئری زده شده است.
    public enum CostManagerTypes
    {
        [Description("نوع پیش‌فرض")]
        CostManagerType1 = 1,

        [Description("نوع 2")]
        CostManagerType2 = 2,

        [Description("نوع 3")]
        CostManagerType3 = 3,

        [Description("نوع 4")]
        CostManagerType4 = 4
    }
}
