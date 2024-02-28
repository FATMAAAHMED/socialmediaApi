using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialContext
{
    public static class RelationMapping
    {
        public static void MapRelations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(x => x.Posts)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<User>()
                   .HasMany(x => x.Likes)
                    .WithOne(x => x.User)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                   .HasMany(x => x.Comments)
                    .WithOne(x => x.User)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    ;

            modelBuilder.Entity<User>()
                .HasMany(x => x.Shares)
                 .WithOne(x => x.User)
                 .HasForeignKey(x => x.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

            

            modelBuilder.Entity<User>()
              .HasMany(x => x.Messages)
               .WithOne(x => x.User)
               .HasForeignKey(x => x.User_Id)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
              .HasMany(x => x.Friends)
               .WithMany()
               .UsingEntity(j => j.ToTable("UserFriends"));




            //modelBuilder.Entity<Post>()
            //    .HasMany(x => x.Likes)
            //    .WithOne(x => x.Post)
            //    .HasForeignKey(x => x.PostId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Post>()
            //    .HasMany(x => x.Comments)
            //    .WithOne(x => x.Post)
            //    .HasForeignKey(x => x.PostId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Post>()
            //    .HasMany(x => x.Shares)
            //    .WithOne(x => x.Post)
            //    .HasForeignKey(x => x.PostId)
            //    .OnDelete(DeleteBehavior.NoAction);

           

            modelBuilder.Entity<PostComment>()
                .HasOne(pc => pc.Post)
                .WithMany(pc => pc.PostComments)
                .HasForeignKey(pc => pc.PostId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            modelBuilder.Entity<PostComment>()
               .HasOne(pc => pc.Comment)
               .WithMany(pc => pc.PostComments)
               .HasForeignKey(pc => pc.CommentId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired(true);

            modelBuilder.Entity<PostLikes>()
                .HasOne(pc => pc.Post)
                .WithMany(pc => pc.PostLikes)
                .HasForeignKey(pc => pc.PostId);

            modelBuilder.Entity<PostLikes>()
               .HasOne(pc => pc.Like)
               .WithMany(pc => pc.PostLikes)
               .HasForeignKey(pc => pc.LikeId);

            modelBuilder.Entity<PostShares>()
                .HasOne(pc => pc.Post)
                .WithMany(pc => pc.PostShares)
                .HasForeignKey(pc => pc.PostId);

            modelBuilder.Entity<PostShares>()
               .HasOne(pc => pc.Share)
               .WithMany(pc => pc.PostShares)
               .HasForeignKey(pc => pc.ShareId);

        }
    }
}
