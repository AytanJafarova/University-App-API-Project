using Core.Enums;
using Entities;

namespace DTO.AccountDTOs
{
    public record AccountToListDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public EAccountStatus Status { get; set; }
    }
}
