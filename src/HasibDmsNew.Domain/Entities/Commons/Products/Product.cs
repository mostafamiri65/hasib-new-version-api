using System;
using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Commons.Products
{
    /// <summary>
    /// برنامه یا محصول
    /// </summary>
    public class Product
    {
        public Product()
        {
            CreatedOn = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsLeaf { get; set; }
        public string Code { get; set; }
        public int? ParentId { get; set; }
        public Product parent { get; set; }
        public int ProcessId { get; set; }
        public Process Process { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? MoneyUnitId { get; set; }
        public int? BenchMarkID { get; set; }
        public bool HasSubset { get; set; }
        public ICollection<ProductStep> ProductSteps { get; set; }
    }
}
