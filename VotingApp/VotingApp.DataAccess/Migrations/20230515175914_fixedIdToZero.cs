using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fixedIdToZero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 608, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 608, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 608, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 608, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 608, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 608, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 608, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 59, 14, 609, DateTimeKind.Local).AddTicks(5155));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 20, 32, 24, 525, DateTimeKind.Local).AddTicks(9611));
        }
    }
}
