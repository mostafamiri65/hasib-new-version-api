using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Application.DTOs.BlockIPs
{
    public class CreateBlockIPDTO
    {
        [Required]
        [Display(Name = "IP")]
        public string IP { get; set; }
    }
}
