using DTO.CourseDTOs;
using DTO.StudentDTOs;
using Entities;
using System.ComponentModel.DataAnnotations;

namespace DTO.PreExamDTOs
{
    public record PreExamToListDTO
    {
        public int? Quiz { get; set; }
        public int? Activity { get; set; } 
        public int? Attendance { get; set; } 
        public int? Midterm { get; set; } 
        public int? Presentation { get; set; }
        public CourseToDepartmentDTO Course { get; set; }
        public StudentToGroupDTO Student { get; set; }
    }
}
