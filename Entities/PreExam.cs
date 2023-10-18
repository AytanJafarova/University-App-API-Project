using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class PreExam
    {
        [Key]
        public int PreExamId { get; set; }
        [Range(0, 5)]
        public int? Quiz { get; set; } = 0;
        [Range(0, 5)]
        public int? Activity { get; set; } = 0;
        [Range(0, 5)]
        public int? Attendance { get; set; } = 0;
        [Range(0, 25)]
        public int? Midterm { get; set; } = 0;
        [Range(0, 10)]
        public int? Presentation { get; set; } = 0;
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public Grade Grade { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
