using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Evaluations
{
    public class IndicatorStructure
    {
        public int IndicatorStructureId { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Path { get; set; }
        public int? ParentId { get; set; }
        public bool HasIndicator { get; set; }
        public List<Indicator> Indicators { get; set; }

        public string GetPath
        {
            get { return ParentId == null ? $",{IndicatorStructureId}," : $",{Path.Trim().Trim(',')},{IndicatorStructureId},"; }
        }
    }
}
