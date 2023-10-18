using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        [Range(1, 9)]
        public int? Credit { get; set; } = 1;
        [Range(1, 6)]
        public int? Duration { get; set; } = 1;
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Exam>? Exams { get; set; }
        public ICollection<PreExam>? PreExams { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
