using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing
{
    /// <summary>
    /// انواع هزینه از نظر مدیریت هزینه
    /// </summary>
    [Table("CostManagerTypes")]
    public class CostManagerType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
