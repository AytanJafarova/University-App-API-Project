using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public Exam Exam { get; set; }
        public int ExamId { get; set; }
        public int ExamGrade { get; set; }
        public PreExam PreExam { get; set; }
        public int PreExamId { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public int TotalGrade { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
