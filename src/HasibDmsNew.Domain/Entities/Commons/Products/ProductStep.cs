using System;

namespace HasibDmsNew.Domain.Entities.Commons.Products
{
    /// <summary>
    /// مرحله محصول
    /// </summary>
    public class ProductStep
    {
        public ProductStep()
        {
            CreatedOn = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? NextStepId { get; set; }
        public int? BeforeStepId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal WastesPercent { get; set; }
        public decimal WastesPrice { get; set; }
    }
}
