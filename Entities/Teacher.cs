using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FName { get; set; }
        public DateTime BirthDate { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string Degree { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
