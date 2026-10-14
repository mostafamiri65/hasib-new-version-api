namespace HasibDmsNew.Domain.Entities.Policies.PasswordPolicies
{
    public class PasswordPolicy
    {
        public int PasswordPolicyId { get; set; }
        public bool UpperCase { get; set; }
        public bool LowerCase { get; set; }
        public bool NumberUsage { get; set; }
        public bool SpecialCharacters { get; set; }
        public int Length { get; set; }
        public int? MaxLength { get; set; }
        public string Regex { get; set; }
    }
}
