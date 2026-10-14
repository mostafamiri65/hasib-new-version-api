using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.CostNew
{
    public enum EconomicClassificationCost
    {
        [Description("جبران خدمات کارکنان")]
        CompensationOfEmployees = 1,
        [Description("استفاده از کالا و خدمات")]
        UseOfGoodsAndServices = 2,
        [Description("هزینه های اموال و دارایی")]
        CostsOfPropertyAndAssets = 3,
        [Description("یارانه ها")]
        Subsidies = 4,
        [Description("کمک های بلاعوض")]
        Grants = 5,
        [Description("رفاه اجتماعی")]
        SocialWelfare = 6,
        [Description("مصرف سرماه های ثابت (استهلاک)")]
        ConsumptionOfFixedCapital = 7,
        [Description("سایر هزینه ها")]
        OtherCosts = 8
    }
}
