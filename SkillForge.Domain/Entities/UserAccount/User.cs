using SkillForge.Domain.Enums.UserAccount;

using System.ComponentModel.DataAnnotations;

namespace SkillForge.Domain.Entities.UserAccount
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; }
        public string ProfilePicture { get; set; } = string.Empty;

        public required Account Account { get; set; }
    }
}
