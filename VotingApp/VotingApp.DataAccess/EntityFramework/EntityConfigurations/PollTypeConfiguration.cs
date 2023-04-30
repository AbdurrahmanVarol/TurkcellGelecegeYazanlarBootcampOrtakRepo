using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.EntityConfigurations;
internal class PollTypeConfiguration : IEntityTypeConfiguration<Poll>
{
    public void Configure(EntityTypeBuilder<Poll> builder)
    {
        builder.ToTable("polls", VotingDbContext.DB_SCHEMA);

        builder.SetId();

        builder.SetColumn(x => x.Title, "nvarchar(50)");

        builder.SetColumn(x => x.Description, "nvarchar(250)");

        builder.HasMany(p => p.Options)
          .WithOne(p => p.Poll)
          .HasForeignKey(p => p.PollId)
          .OnDelete(DeleteBehavior.NoAction);
    }
}