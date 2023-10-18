using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FName { get; set; }
        public DateTime BirthDate { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public ICollection<Grade>? Grades { get; set; }
        public ICollection<PreExam>? PreExams { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
