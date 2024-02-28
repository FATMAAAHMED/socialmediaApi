
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class User : IdentityUser<long> //<Guid, IdentityUserLogin<Guid>, IdentityUserRole<Guid>, IdentityUserClaim<Guid>>
    {
        public User() {
            ProfilePicture = "";
        }
        //public long Id { get; set; }
        public string Name { get; set; }
        //public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public string? Bio { get; set; }
        public DateTime DateJoined { get; set; } = DateTime.Now;
        public ICollection<Post>? Posts { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Share>? Shares { get; set; }
        //public ICollection<Message>? sentMessages { get; set; }
        //public ICollection<Message>? receivedMessages { get; set; }
        public ICollection<Message>? Messages { get; set; }
        public ICollection<User>? Friends { get; set; }

    }
}
