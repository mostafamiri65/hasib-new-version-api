using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Commons.Products
{
    [Table("ProductCostCenters")]
    public class ProductCostCenter
    {
        [Key, Column(Order = 0)]
        public int ProductId { get; set; }

        [Key, Column(Order = 1)]
        public int CostCenterId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
