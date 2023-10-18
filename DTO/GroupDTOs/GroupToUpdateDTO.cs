using Entities;

namespace DTO.GroupDTOs
{
    public record GroupToUpdateDTO
    {
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
    }
}
