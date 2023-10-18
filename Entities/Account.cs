using Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string  Username { get; set; }
        public string  Password { get; set; }
        public EAccountStatus Status { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
