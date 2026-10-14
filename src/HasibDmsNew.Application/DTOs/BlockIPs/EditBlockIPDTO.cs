using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Application.DTOs.BlockIPs
{
    public class EditBlockIPDTO
    {
        [Display(Name = " شناسه ")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "IP")]
        public string IP { get; set; }
    }
}
