using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Commons.Products
{
    public class ProcessActivityAccountStructure
    {
        public ProcessActivityAccountStructure()
        {
            Details = new List<ProcessActivityAccountStructureDetails>();
        }

        public int ProcessActivityAccountStructureId { get; set; }
        public string Title { get; set; }
        public bool HasActivity { get; set; }
        public int AccountTreeTitleId { get; set; }
        public int CostCenterCostMainId { get; set; }
        public int? ActivityTreeTitleId { get; set; }
        public int? ActivityTypeId { get; set; }
        public List<ProcessActivityAccountStructureDetails> Details { get; set; }
    }
}
