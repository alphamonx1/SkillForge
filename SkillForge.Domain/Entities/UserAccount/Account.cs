using SkillForge.Domain.Enums.UserAccount;

using System.ComponentModel.DataAnnotations;

namespace SkillForge.Domain.Entities.UserAccount
{
    public class Account
    {
        [Key]
        public Guid AccountID { get; set; }
        public Guid UserId { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public AccountStatus AccountStatus { get; set; }

        public required User User { get; set; }
    }
}
