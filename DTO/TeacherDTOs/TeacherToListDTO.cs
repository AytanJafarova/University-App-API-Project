using DTO.AccountDTOs;
using DTO.DepartmentDTOs;
using DTO.EnrollmentDTOs;
using Entities;
using System.ComponentModel.DataAnnotations;

namespace DTO.TeacherDTOs
{
    public record TeacherToListDTO
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
        public AccountToRelationsDTO Account { get; set; }
        public DepartmentToRelationsDTO Department { get; set; }
        public ICollection<EnrollmentToRelationsDTO>? Enrollments { get; set; }
    }
}
