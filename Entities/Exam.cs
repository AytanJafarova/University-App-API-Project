using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        public DateTime? ExamDate { get; set; } = DateTime.Now;
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public Grade Grade { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
