using DTO.ExamDTOs;
using DTO.PreExamDTOs;
using DTO.StudentDTOs;
using Entities;

namespace DTO.GradeDTOs
{
    public record GradeToListDTO
    {
        public ExamToCourseDTO Exam { get; set; }
        public PreExamToRelationsDTO PreExam { get; set; }
        public StudentToGroupDTO Student { get; set; }
        public int ExamGrade { get; set; }
        public int TotalGrade { get; set; }
    }
}
