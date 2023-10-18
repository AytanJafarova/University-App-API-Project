using Entities;

namespace DTO.EnrollmentDTOs
{
    public record EnrollmentToAddDTO
    {
        public DateTime? EnrollmentDate { get; set; } = DateTime.Now;
        public DateTime? ExpirationDate { get; set; }
        public int GroupId { get; set; }
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
    }
}
