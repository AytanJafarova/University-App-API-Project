using Entities;
using System.ComponentModel.DataAnnotations;

namespace DTO.TeacherDTOs
{
    public record TeacherToDepartmentDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string Degree { get; set; }
    }
}
