using Entities;

namespace DTO.CourseDTOs
{
    public record CourseToUpdateDTO
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public int? Credit { get; set; }
        public double? Duration { get; set; } 
        public int DepartmentId { get; set; }
    }
}
