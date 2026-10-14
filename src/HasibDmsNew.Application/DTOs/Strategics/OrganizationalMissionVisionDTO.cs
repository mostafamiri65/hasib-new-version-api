using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Application.DTOs.Strategics
{
    public class OrganizationalMissionVisionDTO
    {
        public int OrganizationalMissionVisionId { get; set; }

        [Display(Name = " تعریف ماموریت سازمان")]
        [Required(ErrorMessage = " لطفا {0} را وارد کنید")]
        public string Mission { get; set; }

        [Display(Name = " تعریف چشم انداز سازمان")]
        [Required(ErrorMessage = " لطفا {0} را وارد کنید")]
        public string Vision { get; set; }

        [Display(Name = " تعریف ارزش های سازمانی")]
        [Required(ErrorMessage = " لطفا {0} را وارد کنید")]
        public string Values { get; set; }

        [Display(Name = " سایر موارد")]
        public string Others { get; set; }

        [Display(Name = " سال")]
        public int FiscalYearId { get; set; }
    }
}
