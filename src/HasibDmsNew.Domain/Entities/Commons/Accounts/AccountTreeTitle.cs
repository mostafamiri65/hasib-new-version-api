using System.Collections.Generic;
using HasibDmsNew.Domain.Entities.BOM;

namespace HasibDmsNew.Domain.Entities.Commons.Accounts
{
    public class AccountTreeTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<BOMTreeTitle> BOMTreeTitles { get; set; }
    }
}
