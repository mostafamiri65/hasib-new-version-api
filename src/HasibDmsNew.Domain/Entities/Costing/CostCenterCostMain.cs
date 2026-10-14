using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Costing
{
    public class CostCenterCostMain
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AccountTreeTitleId { get; set; }
        public int CostCenterTreeTitleId { get; set; }
        public List<CostCenterCost> CostCenterCosts { get; set; }
    }
}
