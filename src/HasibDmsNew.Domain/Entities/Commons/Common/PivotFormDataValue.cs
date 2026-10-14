using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("PivotFormDataValues")]
    public class PivotFormDataValue
    {
        public int Id { get; set; }
        public int WorkFlowFormId { get; set; }
        public int BudgetProposalRequestId { get; set; }
    }
}
