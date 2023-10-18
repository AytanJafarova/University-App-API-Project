using DTO.StudentDTOs;
using Entities;

namespace DTO.GroupDTOs
{
    public record GroupToListDTO
    {
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public ICollection<StudentToGroupDTO> Students { get; set; }
    }
}
