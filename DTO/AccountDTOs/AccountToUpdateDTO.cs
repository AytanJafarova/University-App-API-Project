using Entities;

namespace DTO.AccountDTOs
{
    public record AccountToUpdateDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
