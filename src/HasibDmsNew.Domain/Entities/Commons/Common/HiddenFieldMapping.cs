using System;

namespace HasibDmsNew.Domain.Entities.Commons.Common
{
    public class HiddenFieldMapping
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public int FormId { get; set; }
        public int FieldId { get; set; }
        public string SourceType { get; set; }  // "static", "field", "formula"
        public int? SourceStepId { get; set; }
        public int? SourceFormId { get; set; }
        public int? SourceFieldId { get; set; }
        public string StaticValue { get; set; }
        public string FormulaExpression { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
