namespace HasibDmsNew.Domain.Entities.UserManagement.Permissions
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Title { get; set; }
        public int Code { get; set; }
        public int? ParentId { get; set; }
        public string Value { get; set; }
        public bool IsLeaf { get; set; }
    }
}
