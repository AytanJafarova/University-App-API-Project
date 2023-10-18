using DTO.AccountDTOs;
using DTO.GradeDTOs;
using DTO.GroupDTOs;
using DTO.PreExamDTOs;
using Entities;
using System.ComponentModel.DataAnnotations;

namespace DTO.StudentDTOs
{
    public record StudentToListDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public AccountToRelationsDTO Account { get; set; }
        public GroupToStudentDTO Group { get; set; }
        public ICollection<GradeToListDTO>? Grades { get; set; }
    }
}
