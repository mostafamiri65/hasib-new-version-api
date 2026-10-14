using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.UserManagement.Personnels
{
    [Table("PersonnelSalaryMoneyUnits")]
    public class PersonnelSalaryMoneyUnit
    {
        [Key]
        [Column(Order = 0)]
        public int PersonnelId { get; set; }

        [Key, Column(Order = 1)]
        public int MoneyUnitId { get; set; }
    }
}
