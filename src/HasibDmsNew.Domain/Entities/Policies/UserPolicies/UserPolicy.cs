namespace HasibDmsNew.Domain.Entities.Policies.UserPolicies
{
    public class UserPolicy
    {
        public int UserPolicyId { get; set; }
        public int UserSessionCount { get; set; }
        public int WrongPasswordCount { get; set; }
        public int UnauthorizedAccessCount { get; set; }
        public int ExpireCookie { get; set; }
        public string Licence { get; set; }
        public byte LoginType { get; set; }
        public int LockedAfterEnteringWrongPassword { get; set; }
        public int LockTimeInMinute { get; set; }
        public bool UsedCaptcha { get; set; }
    }
}
