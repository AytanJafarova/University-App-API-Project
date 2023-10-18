using Entities;
using System.ComponentModel.DataAnnotations;

namespace DTO.TeacherDTOs
{
    public record TeacherToUpdateDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FName { get; set; }
        public DateTime BirthDate { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string Degree { get; set; }
        public int AccountId { get; set; }
        public int DepartmentId { get; set; }
    }
}
