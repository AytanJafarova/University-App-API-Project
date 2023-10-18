using DTO.CourseDTOs;
using DTO.TeacherDTOs;

namespace DTO.DepartmentDTOs
{
    public record DepartmentToListDTO
    {
        public string DepartmentName { get; set; }
        public ICollection<TeacherToDepartmentDTO>? Teachers { get; set; }
        public ICollection<CourseToDepartmentDTO>? Courses { get; set; }
    }
}
