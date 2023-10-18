using DTO.DepartmentDTOs;
using DTO.EnrollmentDTOs;
using DTO.ExamDTOs;
using DTO.PreExamDTOs;
using Entities;

namespace DTO.CourseDTOs
{
    public record CourseToListDTO
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? Credit { get; set; } 
        public double? Duration { get; set; } 
        public DepartmentToCourseDTO Department { get; set; }
        public ICollection<ExamToCourseDTO>? Exams { get; set; }
        public ICollection<PreExamToRelationsDTO>? PreExams { get; set; }
        public ICollection<EnrollmentToRelationsDTO>? Enrollments { get; set; }
    }
}
