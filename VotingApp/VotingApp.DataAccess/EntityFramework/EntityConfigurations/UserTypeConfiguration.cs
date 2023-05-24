using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.Entities;

namespace VotingApp.DataAccess.EntityFramework.EntityConfigurations;
internal class UserTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
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


        builder.SetColumn(x => x.PasswordHash, "nvarchar(MAX)")
                .Property(x => x.PasswordHash).IsRequired(true);

        builder.SetColumn(x => x.PasswordSalt, "nvarchar(MAX)")
                .Property(x => x.PasswordSalt).IsRequired(true);

        builder.HasMany(p => p.Votes)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(p => p.Polls)
            .WithOne(p => p.CreatedBy)
            .HasForeignKey(p => p.CreatedById)
            .OnDelete(DeleteBehavior.Cascade);

        var passwordSalt = "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=";
        var passwordHash = "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==";
        builder.HasData(
            new User { Id = 1, CreatedAt = DateTime.Now, FirstName = "Abdurrahman", LastName = "Varol", Email = "abdurrahman@gmail.com", UserName = "abdurrahman", PasswordSalt = passwordSalt, PasswordHash = passwordHash },
            new User { Id = 2, CreatedAt = DateTime.Now, FirstName = "Bertan", LastName = "Tokgöz", Email = "bertan@gmail.com", UserName = "bertan", PasswordSalt = passwordSalt, PasswordHash = passwordHash },
            new User { Id = 3, CreatedAt = DateTime.Now, FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcin@gmail.com", UserName = "yalcin", PasswordSalt = passwordSalt, PasswordHash = passwordHash },
            new User { Id = 4, CreatedAt = DateTime.Now, FirstName = "Orhan", LastName = "Onar", Email = "orhan@gmail.com", UserName = "orhan", PasswordSalt = passwordSalt, PasswordHash = passwordHash }
            );
    }
}