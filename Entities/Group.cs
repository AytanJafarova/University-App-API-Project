using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public ICollection<Student> Students { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
