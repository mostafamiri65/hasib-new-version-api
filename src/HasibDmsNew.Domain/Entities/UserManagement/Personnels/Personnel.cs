using System;

namespace HasibDmsNew.Domain.Entities.UserManagement.Personnels
{
    public class Personnel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public byte? Gender { get; set; }
        public byte? Married { get; set; }
        public byte? Dependants { get; set; }
        public byte? ChildCount { get; set; }
        public int? TotalScore { get; set; }
        public int? EmployeeScore { get; set; }
        public int? JobScore { get; set; }
        public int? GreatScore { get; set; }
        public bool? IsSelfless { get; set; }
        public byte? GeographicalRegion { get; set; }
        public DateTime? EmployeementDate { get; set; }
        public DateTime? RetirementDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public int? UpgradeScore { get; set; }
        public string OccupationalClass { get; set; }
        public string JobRank { get; set; }
        public string WorkDuty { get; set; }
        public string WorkDutyCode { get; set; }
        public byte? EmploymentStatus { get; set; }
        public byte? JobStatus { get; set; }
        public decimal? OverTimePrice { get; set; }
        public string BranchScore { get; set; }
        public int? DependentChildrenCount { get; set; }
        public string InsuranceName { get; set; }
        public string JobNameJobClassificationScheme { get; set; }
        public int? CalculatedGroup { get; set; }
    }
}
