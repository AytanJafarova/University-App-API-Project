using Entities;

namespace DTO.GroupDTOs
{
    public record GroupToAddDTO
    {
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; } = DateTime.Now;
    }
}
