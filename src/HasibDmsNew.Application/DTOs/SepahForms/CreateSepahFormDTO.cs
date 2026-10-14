using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.Sepah;

namespace HasibDmsNew.Application.DTOs.SepahForms
{
    public class CreateSepahFormDTO
    {
        public CreateSepahFormDTO()
        {
            Items = new List<SepahForm1>();
        }

        public int Id { get; set; }
        public List<SepahForm1> Items { get; set; }
    }
}
