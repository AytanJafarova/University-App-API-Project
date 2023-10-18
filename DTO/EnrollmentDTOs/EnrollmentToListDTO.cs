using DTO.CourseDTOs;
using DTO.GroupDTOs;
using DTO.TeacherDTOs;
using Entities;

namespace DTO.EnrollmentDTOs
{
    public record EnrollmentToListDTO
    {
        public DateTime? EnrollmentDate { get; set; } = DateTime.Now;
        public DateTime? ExpirationDate { get; set; }
        public GroupToStudentDTO Group { get; set; }
        public CourseToDepartmentDTO Course { get; set; }
        public TeacherToDepartmentDTO Teacher { get; set; }
    }
}
