using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HasibDmsNew.Domain.Entities.Logs
{
    public class LogAction
    {
        [Key]
        public int Id { get; set; }
        public string Level { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string Exception { get; set; }
        public string LogCategory { get; set; }
        public string EventTitle { get; set; }
        public string UrlAddress { get; set; }
        public int? UserId { get; set; }
        public string UserIp { get; set; }
        public string HttpRequestId { get; set; }
        public string LogStatus { get; set; }
        public string UserName { get; set; }
        public string UserAgent { get; set; }
        public DateTime? StartAction { get; set; }
        public DateTime EndAction { get; set; }
        public DateTime StartResult { get; set; }
        public DateTime EndResult { get; set; }
        public TimeSpan TotalAction { get; set; }
        public TimeSpan TotalResult { get; set; }
        public DateTime Total { get; set; }
        public string InputValues { get; set; }
        public string InputValuesWithDisplayName { get; set; }
        public string Description { get; set; }
        public string OutputValues { get; set; }
        public string TypeResult { get; set; }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }

        protected IEnumerable<object> GetEqualityComponents()
        {
            yield return Level;
            yield return TimeStamp;
            yield return Exception;
            yield return LogCategory;
            yield return EventTitle;
            yield return UrlAddress;
            yield return UserId;
            yield return UserIp;
            yield return HttpRequestId;
            yield return LogStatus;
            yield return UserName;
            yield return UserAgent;
            yield return StartAction;
            yield return EndAction;
            yield return StartResult;
            yield return EndResult;
            yield return TotalAction;
            yield return TotalResult;
            yield return Total;
            yield return InputValues;
            yield return InputValuesWithDisplayName;
            yield return Description;
            yield return OutputValues;
            yield return TypeResult;
        }
    }
}
