using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations
{
    public class UserFriendConfiguration : IEntityTypeConfiguration<UserFriend>
    {
        public void Configure(EntityTypeBuilder<UserFriend> builder)
        {
            //builder.HasKey(x =>new { x.UserId, x.FriendId});
            //builder.Property(x => x.UserId).IsRequired();
            //builder.Property(x => x.FriendId).IsRequired();
        }
    }
}
