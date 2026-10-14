using System;

namespace HasibDmsNew.Domain.Entities.Logs
{
    public class LogClass
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Exception { get; set; }
        public string LogCategory { get; set; }
        public string EventTitle { get; set; }
        public string HttpRequestId { get; set; }
        public DateTime StartMethod { get; set; }
        public string EndMethod { get; set; }
        public string TotalMethod { get; set; }
        public string LogStatus { get; set; }
    }
}
