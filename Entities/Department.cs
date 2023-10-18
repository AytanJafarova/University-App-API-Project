using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Teacher>? Teachers { get; set; }
        public ICollection<Course>? Courses { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
