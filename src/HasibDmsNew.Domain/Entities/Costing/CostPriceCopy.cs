using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HasibDmsNew.Domain.Entities.Costing
{
    /// <summary>
    /// کپی تخصیص ها بین سال ، دوره و واحد سازمانی ها
    /// </summary>
    public class CostPriceCopy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public int FromFiscalYearId { get; set; }

        [Required]
        public int ToFiscalYearId { get; set; }

        [Required]
        public byte BranchType { get; set; }

        public int? FromBranchId { get; set; }

        [MaxLength(500)]
        public string ToBranchIds { get; set; }

        [Required]
        [MaxLength(500)]
        public string Periods { get; set; }

        [Required]
        public bool CostUnitCapacityCopy { get; set; }

        [Required]
        public bool ActivityUnitCapacityCopy { get; set; }

        [Required]
        public bool TDABCTotalCapacityCopy { get; set; }

        [Required]
        public bool TDABCActivityTimeCopy { get; set; }

        [Required]
        public bool TDABCProductAllocationCopy { get; set; }

        [Required]
        public bool DirectCostAssignedCapacityCopy { get; set; }

        [Required]
        public bool BomCopy { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public int RunCount { get; set; }
    }
}
