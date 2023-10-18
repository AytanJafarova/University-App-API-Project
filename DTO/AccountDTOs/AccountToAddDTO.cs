using Core.Enums;

namespace DTO.AccountDTOs
{
    public record AccountToAddDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public EAccountStatus Status { get; set; }
    }
}
