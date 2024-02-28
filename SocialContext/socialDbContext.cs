using Domain.Configurations;
using Domain.Entities;
//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SocialContext
{
    public class socialDbContext:IdentityDbContext<User,IdentityRole<long>, long>//< IdentityUser<long>, IdentityRole<long>, long>
    {
        public socialDbContext(DbContextOptions<socialDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new PostConfiguration().Configure(modelBuilder.Entity<Post>());
            new LikeConfiguration().Configure(modelBuilder.Entity<Like>());
            new CommentConfiguration().Configure(modelBuilder.Entity<Comment>());
            new ShareConfiguration().Configure(modelBuilder.Entity<Share>());
            new MessageConfiguration().Configure(modelBuilder.Entity<Message>());
            new PostCommmentConfiguration().Configure(modelBuilder.Entity<PostComment>());
            new PostLikesConfiguration().Configure(modelBuilder.Entity<PostLikes>());
            new PostSharesConfiguration().Configure(modelBuilder.Entity<PostShares>());

            base.OnModelCreating(modelBuilder);
          // modelBuilder.Ignore<IdentityUserLogin<Guid>>();
           // modelBuilder.Entity<IdentityUserLogin<Guid>>()
             //  .HasKey(x => x.UserId);
           // modelBuilder.Entity<IdentityUserLogin<long>>().HasNoKey();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostLikes> PostLikes { get; set; }
        public DbSet<PostShares> PostShares { get; set; }



        //public DbSet<UserFriend> Friendships { get; set; }


    }
}
