using DTO.CourseDTOs;
using Entities;

namespace DTO.ExamDTOs
{
    public record ExamToCourseDTO
    {
        public DateTime? ExamDate { get; set; } = DateTime.Now;
    }
}
