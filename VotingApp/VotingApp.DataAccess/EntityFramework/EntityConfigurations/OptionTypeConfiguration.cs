using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.EntityConfigurations;
internal class OptionTypeConfiguration : IEntityTypeConfiguration<Option> {
    public void Configure(EntityTypeBuilder<Option> builder) {
        builder.ToTable("options", VotingDbContext.DB_SCHEMA);

        builder.SetId();

        builder.SetColumn(x => x.Value, "nvarchar(50)");

        builder.HasOne(x => x.Poll)
                .WithMany()
                .HasForeignKey(x => x.PollId);
    }
}