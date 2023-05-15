﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VotingApp.DataAccess.EntityFramework.Contexts;

#nullable disable

namespace VotingApp.DataAccess.Migrations
{
    [DbContext(typeof(VotingDbContext))]
    partial class VotingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VotingApp.Entities.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PollId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PollId");

                    b.ToTable("options", "vote_db");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4203),
                            IsDeleted = false,
                            PollId = 1,
                            Value = "Seçenek 1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4221),
                            IsDeleted = false,
                            PollId = 1,
                            Value = "Seçenek 2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4223),
                            IsDeleted = false,
                            PollId = 2,
                            Value = "Seçenek 1"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4225),
                            IsDeleted = false,
                            PollId = 2,
                            Value = "Seçenek 2"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4227),
                            IsDeleted = false,
                            PollId = 2,
                            Value = "Seçenek 3"
                        });
                });

            modelBuilder.Entity("VotingApp.Entities.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("polls", "vote_db");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(41),
                            CreatedById = 1,
                            Description = "DenemeAciklama",
                            IsDeleted = false,
                            Title = "Deneme"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(53),
                            CreatedById = 1,
                            Description = "DenemeAciklama 2",
                            IsDeleted = false,
                            Title = "Deneme 2"
                        });
                });

            modelBuilder.Entity("VotingApp.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "UK_Users_Email")
                        .IsUnique();

                    b.ToTable("users", "vote_db");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(7562),
                            Email = "abdurrahman@gmail.com",
                            FirstName = "Abdurrahman",
                            IsDeleted = false,
                            LastName = "Varol",
                            PasswordHash = "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==",
                            PasswordSalt = "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=",
                            UserName = "abdurrahman"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(7575),
                            Email = "bertan@gmail.com",
                            FirstName = "Bertan",
                            IsDeleted = false,
                            LastName = "Tokgöz",
                            PasswordHash = "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==",
                            PasswordSalt = "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=",
                            UserName = "bertan"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(7577),
                            Email = "yalcin@gmail.com",
                            FirstName = "Yalçın",
                            IsDeleted = false,
                            LastName = "Selçuk",
                            PasswordHash = "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==",
                            PasswordSalt = "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=",
                            UserName = "yalcin"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(7580),
                            Email = "orhan@gmail.com",
                            FirstName = "Orhan",
                            IsDeleted = false,
                            LastName = "Onar",
                            PasswordHash = "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==",
                            PasswordSalt = "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=",
                            UserName = "orhan"
                        });
                });

            modelBuilder.Entity("VotingApp.Entities.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OptionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OptionId");

                    b.HasIndex("UserId");

                    b.ToTable("votes", "vote_db");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1806),
                            IsDeleted = false,
                            OptionId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1813),
                            IsDeleted = false,
                            OptionId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1815),
                            IsDeleted = false,
                            OptionId = 1,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1816),
                            IsDeleted = false,
                            OptionId = 2,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1818),
                            IsDeleted = false,
                            OptionId = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1819),
                            IsDeleted = false,
                            OptionId = 4,
                            UserId = 2
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1820),
                            IsDeleted = false,
                            OptionId = 5,
                            UserId = 3
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1984),
                            IsDeleted = false,
                            OptionId = 5,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("VotingApp.Entities.Option", b =>
                {
                    b.HasOne("VotingApp.Entities.Poll", "Poll")
                        .WithMany("Options")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("VotingApp.Entities.Poll", b =>
                {
                    b.HasOne("VotingApp.Entities.User", "CreatedBy")
                        .WithMany("Polls")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("VotingApp.Entities.Vote", b =>
                {
                    b.HasOne("VotingApp.Entities.Option", "Option")
                        .WithMany("Votes")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VotingApp.Entities.User", "User")
                        .WithMany("Votes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VotingApp.Entities.Option", b =>
                {
                    b.Navigation("Votes");
                });

            modelBuilder.Entity("VotingApp.Entities.Poll", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("VotingApp.Entities.User", b =>
                {
                    b.Navigation("Polls");

                    b.Navigation("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}
