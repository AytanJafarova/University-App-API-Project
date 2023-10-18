using Entities;
using System.ComponentModel.DataAnnotations;

namespace DTO.PreExamDTOs
{
    public record PreExamToRelationsDTO
    {
        public int? Quiz { get; set; }
        public int? Activity { get; set; } 
        public int? Attendance { get; set; } 
        public int? Midterm { get; set; } 
        public int? Presentation { get; set; }
    }
}
