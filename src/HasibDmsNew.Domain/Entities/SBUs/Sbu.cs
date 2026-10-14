using System;

namespace HasibDmsNew.Domain.Entities.SBUs
{
    public class Sbu
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int SbuTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int TreeLevel { get; set; } = 0;
        public string TreePath { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CompanyCode { get; set; }
    }
}
