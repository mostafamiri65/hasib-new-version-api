namespace HasibDmsNew.Domain.Entities.Reports
{
    /// <summary>
    /// تنظیمات گزارشات
    /// </summary>
    public class ReportSetting
    {
        /// <summary>
        /// آی دی
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string ReportSettingTitle { get; set; }
        /// <summary>
        /// آیا کاربر نمایش داده شود؟
        /// </summary>
        public bool ShowUser { get; set; }
        /// <summary>
        /// آیا زمان نمایش داده شود؟
        /// </summary>
        public bool ShowTime { get; set; }
        /// <summary>
        /// آیا تاریخ نمایش داده شود؟
        /// </summary>
        public bool ShowDate { get; set; }
        /// <summary>
        /// آیا واحد سازمانی نمایش داده شود؟
        /// </summary>
        public bool ShowBranch { get; set; }
        /// <summary>
        /// آیا سازمان نمایش داده شود؟
        /// </summary>
        public bool ShowOrganization { get; set; }
        /// <summary>
        /// آیا امضاها نمایش داده شود؟
        /// </summary>
        public bool ShowSignature { get; set; }
    }
}
