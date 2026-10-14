using System;
using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class OfferToPay
    {
        public int Id { get; set; }
        public decimal TotalOffer { get; set; }
        public decimal Liquidity { get; set; }
        public DateTime Date { get; set; }
        public List<OfferToPayItem> Items { get; set; }
    }
}
