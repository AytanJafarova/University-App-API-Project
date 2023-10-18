using DTO.CourseDTOs;
using Entities;

namespace DTO.ExamDTOs
{
    public record ExamToListDTO
    {
        public DateTime? ExamDate { get; set; } = DateTime.Now;
        public CourseToExamDTO Course { get; set; }
    }
}
