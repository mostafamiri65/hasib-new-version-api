using System.ComponentModel;

namespace HasibDmsNew.Domain.Enums.Commons.Personnel
{
    public enum JobStatus
    {
        [Description("مامور به خدمت")]
        Agent = 1,
        [Description("اشتغال")]
        Active = 2,
        [Description("مرخصی بدون حقوق")]
        DeActive = 3,
        [Description("غیبت")]
        Absence = 4,
        [Description("انفصال")]
        Separation = 5
    }
}
