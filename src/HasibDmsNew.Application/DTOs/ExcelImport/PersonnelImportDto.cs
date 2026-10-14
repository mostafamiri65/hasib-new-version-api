using System;

namespace HasibDmsNew.Application.DTOs.ExcelImport
{
    public class PersonnelImportDto
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string BranchCode { get; set; }
        public string CostCenterCode { get; set; }
        public int BranchId { get; set; }
        public int CostCenterId { get; set; }
        public byte? Gender { get; set; }
        public byte? Married { get; set; }
        public byte? Dependants { get; set; }
        public int? JobScore { get; set; }
        public byte? IsSelflessVal { get; set; }
        public bool? IsSelfless { get { return IsSelflessVal == null ? (bool?)null : IsSelflessVal == 1; } }
        public byte? GeographicalRegion { get; set; }
        public DateTime? EmployeementDate { get; set; }
        public DateTime? RetirementDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public string WorkDuty { get; set; }
        public string WorkDutyCode { get; set; }
        public byte? EmploymentStatus { get; set; }
        public byte? JobStatus { get; set; }
        public int? DependentChildrenCount { get; set; }
        public string InsuranceName { get; set; }
        public string JobNameJobClassificationScheme { get; set; }
        public int? CalculatedGroup { get; set; }
    }
}
