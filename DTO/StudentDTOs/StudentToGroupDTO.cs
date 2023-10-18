using DTO.AccountDTOs;
using DTO.GroupDTOs;
using Entities;
using System.ComponentModel.DataAnnotations;

namespace DTO.StudentDTOs
{
    public record StudentToGroupDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FName { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
    }
}
