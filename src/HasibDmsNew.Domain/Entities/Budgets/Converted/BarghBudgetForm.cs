using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace HasibDmsNew.Domain.Entities.Budgets.Converted
{
    [Table("BarghBudgetForms")]
    public class BarghBudgetForm
    {
        public int Id { get; set; }
        public int YearId { get; set; }
        public string FormNumber { get; set; }
        public string FormName { get; set; }
        public string FileName { get; set; }
        public string CompanyName { get; set; }
        public string PreparedBy { get; set; }
        public string ResponsibleUnit { get; set; }
        public string AmountUnit { get; set; } // ارقام به میلیون ریال
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<BarghFormSheet> Sheets { get; set; } = new List<BarghFormSheet>();
    }

    [Table("BarghFormSheets")]
    public class BarghFormSheet
    {
        public int Id { get; set; }
        public int BudgetFormId { get; set; }
        public string SheetName { get; set; }
        public string Description { get; set; }
        public int TotalRows { get; set; }
        public int TotalColumns { get; set; }

        public BarghBudgetForm BudgetForm { get; set; }
        public ICollection<BarghFormRow> Rows { get; set; } = new List<BarghFormRow>();
        public ICollection<BarghColumnDefinition> ColumnDefinitions { get; set; } = new List<BarghColumnDefinition>();
    }

    [Table("BarghColumnDefinitions")]
    public class BarghColumnDefinition
    {
        public int Id { get; set; }
        public int SheetId { get; set; }
        public int ColumnIndex { get; set; }
        public string ColumnName { get; set; }
        public string HeaderName { get; set; }
        public string DataType { get; set; }
        public bool IsRequired { get; set; }
        public bool IsMetadata { get; set; }

        public BarghFormSheet Sheet { get; set; }
    }

    [Table("BarghFormRows")]
    public class BarghFormRow
    {
        public int Id { get; set; }
        public int BudgetFormId { get; set; }
        public int SheetId { get; set; }
        public int RowNumber { get; set; }
        public string RowCode { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsHeader { get; set; }
        public bool IsTotal { get; set; }
        public bool IsSubtotal { get; set; }
        public string Notes { get; set; }
        public string Unit { get; set; }

        public string DataJson { get; set; }
        public string ColA { get; set; }
        public string ColB { get; set; }
        public string ColC { get; set; }

        [NotMapped]
        public Dictionary<string, string> DataDictionary
        {
            get => JsonSerializer.Deserialize<Dictionary<string, string>>(DataJson ?? "{}");
            set => DataJson = JsonSerializer.Serialize(value);
        }

        public BarghBudgetForm BudgetForm { get; set; }
        public BarghFormSheet Sheet { get; set; }
    }

    public class BarghExcelCell
    {
        public int Id { get; set; }
        public int BudgetFormId { get; set; }
        public int SheetId { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public string CellAddress { get; set; }
        public string Value { get; set; }
        public string DataType { get; set; }
        public string Formula { get; set; }
        public string Format { get; set; }
        public string BackgroundColor { get; set; }
        public string FontColor { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic { get; set; }
        public bool IsMerged { get; set; }
        public string MergedRange { get; set; }
        public bool IsMergedCell { get; set; }
        public int? MergedStartRow { get; set; }
        public int? MergedStartColumn { get; set; }
        public int? MergedEndRow { get; set; }
        public int? MergedEndColumn { get; set; }
        public int? RowSpan { get; set; }
        public int? ColSpan { get; set; }
        public bool IsFormula { get; set; }
        public decimal? NumericValue { get; set; }
        public DateTime? DateValue { get; set; }
        public string Comments { get; set; }
        public string Hyperlink { get; set; }

        [ForeignKey("BudgetFormId")]
        public BarghBudgetForm BudgetForm { get; set; }

        [ForeignKey("SheetId")]
        public BarghFormSheet Sheet { get; set; }
    }
}
