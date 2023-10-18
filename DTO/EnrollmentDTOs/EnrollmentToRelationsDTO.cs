using DTO.GroupDTOs;
using DTO.TeacherDTOs;
using Entities;

namespace DTO.EnrollmentDTOs
{
    public record EnrollmentToRelationsDTO
    {
        public DateTime? EnrollmentDate { get; set; } = DateTime.Now;
        public DateTime? ExpirationDate { get; set; }
        public GroupToStudentDTO Group { get; set; }
    }
}
