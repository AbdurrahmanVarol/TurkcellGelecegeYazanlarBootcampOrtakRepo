using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.EntityConfigurations;
internal class VoteTypeConfiguration : IEntityTypeConfiguration<Vote>
{
    public void Configure(EntityTypeBuilder<Vote> builder)
    {
        builder.ToTable("votes", VotingDbContext.DB_SCHEMA);

        builder.SetId();

        builder.HasData(
                new Vote { Id = 1, CreatedAt = DateTime.Now, UserId = 1, OptionId = 1 },
                new Vote { Id = 2, CreatedAt = DateTime.Now, UserId = 2, OptionId = 1 },
                new Vote { Id = 3, CreatedAt = DateTime.Now, UserId = 3, OptionId = 1 },
                new Vote { Id = 4, CreatedAt = DateTime.Now, UserId = 4, OptionId = 2 },
                new Vote { Id = 5, CreatedAt = DateTime.Now, UserId = 1, OptionId = 3 },
                new Vote { Id = 6, CreatedAt = DateTime.Now, UserId = 2, OptionId = 4 },
                new Vote { Id = 7, CreatedAt = DateTime.Now, UserId = 3, OptionId = 5 },
                new Vote { Id = 8, CreatedAt = DateTime.Now, UserId = 4, OptionId = 5 }
                );
    }
}