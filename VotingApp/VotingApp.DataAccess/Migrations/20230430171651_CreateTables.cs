using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VotingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "vote_db");

            migrationBuilder.CreateTable(
                name: "users",
                schema: "vote_db",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "polls",
                schema: "vote_db",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_polls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_polls_users_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "vote_db",
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "options",
                schema: "vote_db",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PollId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_options_polls_PollId",
                        column: x => x.PollId,
                        principalSchema: "vote_db",
                        principalTable: "polls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "votes",
                schema: "vote_db",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    OptionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_votes_options_OptionId",
                        column: x => x.OptionId,
                        principalSchema: "vote_db",
                        principalTable: "options",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_votes_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "vote_db",
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 30, 20, 16, 51, 771, DateTimeKind.Local).AddTicks(8483), "abdurrahman@gmail.com", "Abdurrahman", "Varol", "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==", "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=", "abdurrahman" },
                    { 2, new DateTime(2023, 4, 30, 20, 16, 51, 771, DateTimeKind.Local).AddTicks(8497), "bertan@gmail.com", "Bertan", "Tekgöz", "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==", "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=", "bertan" },
                    { 3, new DateTime(2023, 4, 30, 20, 16, 51, 771, DateTimeKind.Local).AddTicks(8499), "yalcin@gmail.com", "Yalçın", "Selçuk", "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==", "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=", "yalcin" },
                    { 4, new DateTime(2023, 4, 30, 20, 16, 51, 771, DateTimeKind.Local).AddTicks(8501), "orhan@gmail.com", "Orhan", "Onar", "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==", "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=", "orhan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_options_Id",
                schema: "vote_db",
                table: "options",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_options_PollId",
                schema: "vote_db",
                table: "options",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_polls_CreatedById",
                schema: "vote_db",
                table: "polls",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_polls_Id",
                schema: "vote_db",
                table: "polls",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_Id",
                schema: "vote_db",
                table: "users",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Users_Email",
                schema: "vote_db",
                table: "users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_votes_Id",
                schema: "vote_db",
                table: "votes",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_votes_OptionId",
                schema: "vote_db",
                table: "votes",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_votes_UserId",
                schema: "vote_db",
                table: "votes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "votes",
                schema: "vote_db");

            migrationBuilder.DropTable(
                name: "options",
                schema: "vote_db");

            migrationBuilder.DropTable(
                name: "polls",
                schema: "vote_db");

            migrationBuilder.DropTable(
                name: "users",
                schema: "vote_db");
        }
    }
}
