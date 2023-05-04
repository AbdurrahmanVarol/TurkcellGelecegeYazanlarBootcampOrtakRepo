using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VotingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "polls",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Description", "Title" },
                values: new object[] { 1, new DateTime(2023, 5, 4, 20, 55, 54, 883, DateTimeKind.Local).AddTicks(9731), 1, "DenemeAciklama", "Deneme" });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "options",
                columns: new[] { "Id", "CreatedAt", "PollId", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 4, 20, 55, 54, 883, DateTimeKind.Local).AddTicks(7016), 1, "Seçenek1" },
                    { 2, new DateTime(2023, 5, 4, 20, 55, 54, 883, DateTimeKind.Local).AddTicks(7027), 1, "Seçenek2" }
                });

            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "votes",
                columns: new[] { "Id", "CreatedAt", "OptionId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(2189), 1, 1 },
                    { 2, new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(2194), 1, 2 },
                    { 3, new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(2196), 1, 3 },
                    { 4, new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(2197), 2, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 20, 16, 51, 771, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 20, 16, 51, 771, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 20, 16, 51, 771, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 30, 20, 16, 51, 771, DateTimeKind.Local).AddTicks(8501));
        }
    }
}
