using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.UserManagement.Users;

namespace HasibDmsNew.Domain.Entities.Sepah
{
    [Table("SepahFormInfo")]
    public class SepahFormInfo
    {
        public SepahFormInfo()
        {
            SepahForms1 = new List<SepahForm1>();
        }

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime Date { get; set; }
        public List<SepahForm1> SepahForms1 { get; set; }
    }
}
