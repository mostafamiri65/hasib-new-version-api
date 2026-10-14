namespace HasibDmsNew.Domain.Entities.Strategics
{
    public class OrganizationalMissionVision
    {
        public int OrganizationalMissionVisionId { get; set; }
        public string Mission { get; set; }
        public string Vision { get; set; }
        public string Values { get; set; }
        public string Others { get; set; }
        public int FiscalYearId { get; set; }
    }
}
