using System;

namespace HasibDmsNew.Domain.Entities.Notificationes
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public byte Type { get; set; }
        public int EntityId { get; set; }
        public bool IsNew { get; set; }
        public bool IsAdmin { get; set; }
    }
}
