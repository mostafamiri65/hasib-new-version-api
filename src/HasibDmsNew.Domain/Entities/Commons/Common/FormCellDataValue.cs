using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    [Table("FormCellDataValue")]
    public class FormCellDataValue
    {
        public int Id { get; set; }
        public int CellId { get; set; }
        public int BudgetProposalId { get; set; }
        public int StepId { get; set; }
        public string DataValue { get; set; }
    }
}
