using System;

namespace HasibDmsNew.Domain.Entities.Commons.Settings
{
    public class IPAddressUser
    {
        public int IPAddressId { get; set; }
        public string UserIP { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int DayActive { get; set; }
    }
}
