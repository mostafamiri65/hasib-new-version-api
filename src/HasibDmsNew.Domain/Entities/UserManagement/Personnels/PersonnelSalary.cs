namespace HasibDmsNew.Domain.Entities.UserManagement.Personnels
{
    public class PersonnelSalary
    {
        public int Id { get; set; }
        public int PeriodId { get; set; }
        public int PersonnelId { get; set; }
        public int SalaryParamId { get; set; }
        public decimal Value { get; set; }
        public bool IsPrice { get; set; }
    }
}
