namespace HasibDmsNew.Application.DTOs.ExcelImport
{
    public class PersonnelSalaryImportDto
    {
        public string PersonnelCode { get; set; }
        public string SalaryCode { get; set; }
        public decimal Price { get; set; }
        public bool IsPrice => true;
        public int PersonnelId { get; set; }
        public int SalaryParamId { get; set; }
        public string FiscalYearId { get; set; }
        public string PeriodId { get; set; }
    }
}
