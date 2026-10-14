using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    [Table("ActivityType")]
    public class ActivityType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? DriverId { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
