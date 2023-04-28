using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.EntityConfigurations;
internal class VoteTypeConfiguration : IEntityTypeConfiguration<Vote> {
    public void Configure(EntityTypeBuilder<Vote> builder) {
        builder.ToTable("votes", VotingDbContext.DB_SCHEMA);

        builder.SetId();


        builder.HasOne(x => x.Option)
                .WithMany()
                .HasForeignKey(x => x.OptionId);

        builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);
    }
}