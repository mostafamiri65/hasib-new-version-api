using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HasibDmsNew.Domain.Entities.Costing.ABC;
using HasibDmsNew.Domain.Enums.Commons.Drivers;

namespace HasibDmsNew.Domain.Entities.Commons.Drivers
{
    [DisplayName("محرک ")]
    /// <summary>
    /// محرک(واحد)
    /// </summary>
    public class Unit
    {
        [Display(Name = "شناسه ")]
        public int Id { get; set; }

        [Display(Name = "عنوان ")]
        public string Title { get; set; }

        public CalculationMethodDriverFormula CalculationMethodDriverFormula { get; set; }
        public string FormulaStructure { get; set; }
        public string FormulaDescription { get; set; }
        public string Description { get; set; }

        [Display(Name = "نوع ")]
        public UnitType UnitType { get; set; }

        public ICollection<UnitCapacity> UnitCapacites { get; set; }
        public ICollection<UnitItemCapacity> UnitItemCapacites { get; set; }
        public ICollection<UnitItemActivityCapacity> UnitItemActivityCapacites { get; set; }
    }
}
