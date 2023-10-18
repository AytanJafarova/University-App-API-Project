using Entities;

namespace DTO.GradeDTOs
{
    public record GradeToAddDTO
    {
        public int ExamId { get; set; }
        public int PreExamId { get; set; }
        public int StudentId { get; set; }
        public int ExamGrade { get; set; }
    }
}
