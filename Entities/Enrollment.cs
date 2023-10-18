using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        public DateTime? EnrollmentDate { get; set; } = DateTime.Now;
        public DateTime? ExpirationDate { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
