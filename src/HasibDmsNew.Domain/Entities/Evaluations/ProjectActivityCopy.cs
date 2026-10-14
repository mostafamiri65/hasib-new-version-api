using System;

namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class ProjectActivityCopy
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationTime { get; set; }
        public int FromFiscalYearId { get; set; }
        public int ToFiscalYearId { get; set; }
        public string FromProjects { get; set; }
        public byte BranchType { get; set; }
        public int? FromBranchId { get; set; }
        public string ToBranchIds { get; set; }
        public string Periods { get; set; }
        public bool HasCopy1 { get; set; }
        public bool HasCopy2 { get; set; }
        public bool HasCopy3 { get; set; }
        public bool HasCopy4 { get; set; }
        public bool HasCopy5 { get; set; }
        public short RunCount { get; set; }
    }
}
