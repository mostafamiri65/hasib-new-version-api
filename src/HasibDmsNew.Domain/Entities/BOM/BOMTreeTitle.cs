using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using HasibDmsNew.Domain.Entities.Commons.Accounts;

namespace HasibDmsNew.Domain.Entities.BOM
{
    public class BOMTreeTitle
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int AccountTreeTitleId { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(AccountTreeTitleId))]
        public AccountTreeTitle AccountTreeTitle { get; set; }

        public ICollection<BOM> BOMs { get; set; }
    }
}
