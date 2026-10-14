using System.ComponentModel.DataAnnotations;

namespace HasibDmsNew.Application.DTOs.BlockIPs
{
    public class DisplayBlockIPDTO
    {
        [Display(Name = " شناسه ")]
        public int Id { get; set; }

        [Display(Name = "IP")]
        public string IP { get; set; }
    }
}
