using System;

namespace HasibDmsNew.Application.DTOs.SepahForms
{
    public class ListSepahFormDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime Date { get; set; }
        public byte FormId { get; set; }
        public string Type { get { return $"فرم {FormId}"; } }
    }
}
