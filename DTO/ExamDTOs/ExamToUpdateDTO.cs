using Entities;

namespace DTO.ExamDTOs
{
    public record ExamToUpdateDTO
    {
        public DateTime? ExamDate { get; set; } = DateTime.Now;
        public int CourseId { get; set; }
    }
}
