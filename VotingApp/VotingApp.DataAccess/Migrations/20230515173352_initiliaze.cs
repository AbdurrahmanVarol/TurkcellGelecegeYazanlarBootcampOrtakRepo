using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VotingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initiliaze : Migration
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PollId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsDeleted", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 15, 20, 33, 51, 886, DateTimeKind.Local).AddTicks(8246), null, "abdurrahman@gmail.com", "Abdurrahman", false, "Varol", "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==", "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=", "abdurrahman" },
                    { 2, new DateTime(2023, 5, 15, 20, 33, 51, 886, DateTimeKind.Local).AddTicks(8255), null, "bertan@gmail.com", "Bertan", false, "Tokgöz", "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==", "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=", "bertan" },
                    { 3, new DateTime(2023, 5, 15, 20, 33, 51, 886, DateTimeKind.Local).AddTicks(8257), null, "yalcin@gmail.com", "Yalçın", false, "Selçuk", "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==", "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=", "yalcin" },
                    { 4, new DateTime(2023, 5, 15, 20, 33, 51, 886, DateTimeKind.Local).AddTicks(8259), null, "orhan@gmail.com", "Orhan", false, "Onar", "WMA4dhrMhW2ZW3+8wIlpzcew0pVATmgSq4WZ+tjmiOW1R09J5lKdcxR16RIT1ds44FjeYM0o+ksAeTzSX6aXZQ==", "8qjYoxBQ2SgvH7vcbDsPbus2YFpicja5cDbz9IL6hJIgS4gTgr5uq1ADDLy7GHsIEY+0otBju+h74HRuNuFnU25/HWCXOjdKqPlksusj7mNjAR6rk9K9Oy4s1wIySzCoy3xi205Kqhgb4NJ0UcryFCvT6G/9QDQ63A9NyNVQ8s0=", "orhan" }
                });

            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "polls",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "DeletedAt", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 15, 20, 33, 51, 886, DateTimeKind.Local).AddTicks(1908), 1, null, "DenemeAciklama", false, "Deneme" },
                    { 2, new DateTime(2023, 5, 15, 20, 33, 51, 886, DateTimeKind.Local).AddTicks(1917), 1, null, "DenemeAciklama 2", false, "Deneme 2" }
                });

            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "options",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "PollId", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 15, 20, 33, 51, 885, DateTimeKind.Local).AddTicks(7049), null, false, 1, "Seçenek 1" },
                    { 2, new DateTime(2023, 5, 15, 20, 33, 51, 885, DateTimeKind.Local).AddTicks(7063), null, false, 1, "Seçenek 2" },
                    { 3, new DateTime(2023, 5, 15, 20, 33, 51, 885, DateTimeKind.Local).AddTicks(7064), null, false, 2, "Seçenek 1" },
                    { 4, new DateTime(2023, 5, 15, 20, 33, 51, 885, DateTimeKind.Local).AddTicks(7066), null, false, 2, "Seçenek 2" },
                    { 5, new DateTime(2023, 5, 15, 20, 33, 51, 885, DateTimeKind.Local).AddTicks(7067), null, false, 2, "Seçenek 3" }
                });

            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "votes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "OptionId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 15, 20, 33, 51, 887, DateTimeKind.Local).AddTicks(899), null, false, 1, 1 },
                    { 2, new DateTime(2023, 5, 15, 20, 33, 51, 887, DateTimeKind.Local).AddTicks(905), null, false, 1, 2 },
                    { 3, new DateTime(2023, 5, 15, 20, 33, 51, 887, DateTimeKind.Local).AddTicks(907), null, false, 1, 3 },
                    { 4, new DateTime(2023, 5, 15, 20, 33, 51, 887, DateTimeKind.Local).AddTicks(908), null, false, 2, 4 },
                    { 5, new DateTime(2023, 5, 15, 20, 33, 51, 887, DateTimeKind.Local).AddTicks(909), null, false, 3, 1 },
                    { 6, new DateTime(2023, 5, 15, 20, 33, 51, 887, DateTimeKind.Local).AddTicks(910), null, false, 4, 2 },
                    { 7, new DateTime(2023, 5, 15, 20, 33, 51, 887, DateTimeKind.Local).AddTicks(911), null, false, 5, 3 },
                    { 8, new DateTime(2023, 5, 15, 20, 33, 51, 887, DateTimeKind.Local).AddTicks(913), null, false, 5, 4 }
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
