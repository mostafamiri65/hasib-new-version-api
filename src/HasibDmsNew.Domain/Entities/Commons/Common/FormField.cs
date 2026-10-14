using HasibDmsNew.Domain.Enums.Commons.Common;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    public class FormField
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Label { get; set; }
        public FieldType Type { get; set; }
        public string Options { get; set; }
        public string Formula { get; set; }
        public int Order { get; set; }
        public bool IsRequired { get; set; }
        public string DataSource { get; set; }
        public string CustomOptions { get; set; }
        public string LabelPosition { get; set; }
        public string JsonId { get; set; }
        public Form Form { get; set; }
    }
}
