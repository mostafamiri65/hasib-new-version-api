using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.Commons.Accounts;
using HasibDmsNew.Domain.Entities.Budgets;

namespace HasibDmsNew.Domain.Entities.BOM
{
    public class BOM
    {
        public int Id { get; set; }
        public int BenchMarkId { get; set; }
        public int BOMTreeTitleId { get; set; }
        public int CostId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(BOMTreeTitleId))]
        public BOMTreeTitle BOMTreeTitle { get; set; }

        [ForeignKey(nameof(BenchMarkId))]
        public BenchMark BenchMark { get; set; }

        [ForeignKey(nameof(CostId))]
        public Cost Cost { get; set; }
    }
}
