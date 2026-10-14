using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Activities
{
    [Table("TypeActivities")]
    public class TypeActivity
    {
        public int Id { get; set; }
        public int TreeTitleId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsLeaf { get; set; }
        public int? ParentId { get; set; }
        public int ActivityTypeId { get; set; }
        public int? ActivityDriverId { get; set; }
        public int? BenchMarkId { get; set; }
        public int? Type { get; set; }
    }
}
