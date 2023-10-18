using Entities;

namespace DTO.GradeDTOs
{
    public record GradeToUpdateDTO
    {
        public int ExamId { get; set; }
        public int PreExamId { get; set; }
        public int StudentId { get; set; }
    }
}
