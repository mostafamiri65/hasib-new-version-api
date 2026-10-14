using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.HashTables
{
    public class UserRoleHash
    {
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key, Column(Order = 1), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        public string RecordHash { get; set; }
    }

    public class TableHash
    {
        [Key]
        public string Id { get; set; }
        public string Hash { get; set; }
    }

    public class UserHash
    {
        [Key]
        public int UserId { get; set; }
        public string RecordHash { get; set; }
    }
}
