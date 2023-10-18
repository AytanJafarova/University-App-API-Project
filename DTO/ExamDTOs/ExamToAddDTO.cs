using Entities;

namespace DTO.ExamDTOs
{
    public record ExamToAddDTO
    {
        public DateTime? ExamDate { get; set; }
        public int CourseId { get; set; }
    }
}
