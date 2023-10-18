using Entities;

namespace DTO.EnrollmentDTOs
{
    public record EnrollmentToUpdateDTO
    {
        public DateTime? EnrollmentDate { get; set; } = DateTime.Now;
        public DateTime? ExpirationDate { get; set; }
        public int GroupId { get; set; }
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
    }
}
