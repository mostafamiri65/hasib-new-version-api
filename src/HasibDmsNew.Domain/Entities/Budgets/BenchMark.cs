namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BenchMark
    {
        public int BenchMarkId { get; set; }
        public byte Type { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
