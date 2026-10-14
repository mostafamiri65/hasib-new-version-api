using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Domain.Enums.Commons.Common
{
    public enum ContentType
    {
        [Display(Name = "متن")]
        Text = 0,

        [Display(Name = "فایل PDF")]
        PDF = 1
    }
}
