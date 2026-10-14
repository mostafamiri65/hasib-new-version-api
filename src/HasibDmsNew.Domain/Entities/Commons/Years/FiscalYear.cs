using System;

namespace HasibDmsNew.Domain.Entities.Commons.Years
{
    /// <summary>
    /// سال مالی
    /// </summary>
    public class FiscalYear
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? BeforeYearId { get; set; }
        public int Year { get; set; }
        public bool IsMain { get; set; }
        public bool IsOpen { get; set; }
    }
}
