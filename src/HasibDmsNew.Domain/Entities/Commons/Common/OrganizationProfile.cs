using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("OrganizationProfiles")]
    public class OrganizationProfile
    {
        public int Id { get; set; }
        public string SoftwareCode { get; set; }
        public int CurrentFiscalYearId { get; set; }
        public int NextBudgetProposalFiscalYearId { get; set; }
        public bool CentrallyControl { get; set; }
        public bool CanRequestBudgetProposal { get; set; }
        public string LicenseCode { get; set; }
        public string OrganizationAddress { get; set; }
        public string OrganizationNumber { get; set; }
        public string NationalId { get; set; }
        public string PostalCode { get; set; }
    }
}
