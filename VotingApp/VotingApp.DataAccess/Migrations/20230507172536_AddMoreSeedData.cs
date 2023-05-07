using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VotingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2704), "Seçenek 1" });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2714), "Seçenek 2" });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "polls",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Description", "Title" },
                values: new object[] { 2, new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(5372), 1, "DenemeAciklama 2", "Deneme 2" });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "options",
                columns: new[] { "Id", "CreatedAt", "PollId", "Value" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2716), 2, "Seçenek 1" },
                    { 4, new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2717), 2, "Seçenek 2" },
                    { 5, new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2718), 2, "Seçenek 3" }
                });

            migrationBuilder.InsertData(
                schema: "vote_db",
                table: "votes",
                columns: new[] { "Id", "CreatedAt", "OptionId", "UserId" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7391), 3, 1 },
                    { 6, new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7392), 4, 2 },
                    { 7, new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7393), 5, 3 },
                    { 8, new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7394), 5, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2023, 5, 4, 20, 55, 54, 883, DateTimeKind.Local).AddTicks(7016), "Seçenek1" });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2023, 5, 4, 20, 55, 54, 883, DateTimeKind.Local).AddTicks(7027), "Seçenek2" });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 20, 55, 54, 883, DateTimeKind.Local).AddTicks(9731));

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

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 20, 55, 54, 885, DateTimeKind.Local).AddTicks(2197));
        }
    }
}
