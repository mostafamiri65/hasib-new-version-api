namespace HasibDmsNew.Domain.Entities.Commons.Branchs
{
    /// <summary>
    /// پارامتر واحد سازمانی
    /// </summary>
    public class BranchParameter
    {
        public int BranchParameterId { get; set; }
        public string Title { get; set; }
        public int ParameterTypeId { get; set; }
        public int? ParentId { get; set; }
        public bool HasBranch { get; set; }
    }
}
