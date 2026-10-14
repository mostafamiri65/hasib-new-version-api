namespace HasibDmsNew.Domain.Entities.Policies.LogPolicies
{
    public class LogPolicy
    {
        public int LogPolicyId { get; set; }
        public int ThresholdCount { get; set; }
        public int FinalCount { get; set; }
    }
}
