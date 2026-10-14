namespace HasibDmsNew.Domain.Entities.UserManagement.Personnels
{
    public class PersonnelParticipationShare
    {
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        public int ActivityId { get; set; }
        public int PeriodId { get; set; }
        public decimal ParticipationShare { get; set; }
    }
}
