using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.EntityConfigurations;
internal class UserTypeConfiguration : IEntityTypeConfiguration<User> {
    public void Configure(EntityTypeBuilder<User> builder) {
        builder.ToTable("users", VotingDbContext.DB_SCHEMA);

        builder.SetId();

        builder.SetColumn(x => x.UserName, "nvarchar(50)");
        builder.SetColumn(x => x.FirstName, "nvarchar(50)");
        builder.SetColumn(x => x.LastName, "nvarchar(50)");
        builder.SetColumn(x => x.Email, "nvarchar(255)")
                .Property(x => x.Email)
                .IsRequired(true);

        builder.HasIndex(x => x.Email, "UK_Users_Email")
                .IsUnique(true);


        builder.SetColumn(x => x.PasswordHash, "varbinary(MAX)")
                .Property(x => x.PasswordHash).IsRequired(true);

        builder.SetColumn(x => x.PasswordSalt, "varbinary(MAX)")
                .Property(x => x.PasswordSalt).IsRequired(true);
    }
}