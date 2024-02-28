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
    public class PostSharesConfiguration : IEntityTypeConfiguration<PostShares>
    {
        public void Configure(EntityTypeBuilder<PostShares> builder)
        {
            builder.HasKey(pc => new { pc.PostId, pc.ShareId });
        }
    }
}
