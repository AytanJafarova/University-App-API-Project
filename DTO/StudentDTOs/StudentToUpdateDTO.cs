using Entities;
using System.ComponentModel.DataAnnotations;

namespace DTO.StudentDTOs
{
    public record StudentToUpdateDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FName { get; set; }
        public DateTime BirthDate { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public int GroupId { get; set; }
    }
}
