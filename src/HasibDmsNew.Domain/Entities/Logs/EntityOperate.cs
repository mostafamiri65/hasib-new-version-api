using System;

namespace HasibDmsNew.Domain.Entities.Logs
{
    public class EntityOperate
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Exception { get; set; }
        public string Properties { get; set; }
        public string MessagePersian { get; set; }
        public string EntityNamePersian { get; set; }
        public string LogCategory { get; set; }
        public string EntityName { get; set; }
        public long EntityId { get; set; }
        public string OperationType { get; set; }
        public int UserId { get; set; }
        public string HttpRequestId { get; set; }
    }
}
