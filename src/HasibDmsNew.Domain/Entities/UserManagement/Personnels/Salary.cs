namespace HasibDmsNew.Domain.Entities.UserManagement.Personnels
{
    public class SalaryParam
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int SalaryType { get; set; }
        public int? CostId { get; set; }
    }
}
