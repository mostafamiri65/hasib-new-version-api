using System;
using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.UserManagement.Users;

namespace HasibDmsNew.Domain.Entities.Costing
{
    [Table("CostPriceCopyHistory")]
    public class CostPriceCopyHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CopyId { get; set; }
        public DateTime CreationTime { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }
}
