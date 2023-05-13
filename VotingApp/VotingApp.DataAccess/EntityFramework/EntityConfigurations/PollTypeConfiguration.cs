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

        builder.HasData(
            new Poll { Id = 1, CreatedAt = DateTime.Now, CreatedById = 1, Title = "Deneme", Description = "DenemeAciklama" },
            new Poll { Id = 2, CreatedAt = DateTime.Now, CreatedById = 1, Title = "Deneme 2", Description = "DenemeAciklama 2" }
            );
    }
}