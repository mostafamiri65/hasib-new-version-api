using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Products
{
    public enum ProductType
    {
        [Description("فنی")]
        Technical = 1,
        [Description("تولیدی")]
        Productive,
        [Description("غیرتولیدی")]
        NonProductive,
        [Description("ستادی پشتیبانی")]
        SupportHeadquarters,
        [Description("خدماتی")]
        Service
    }
}
