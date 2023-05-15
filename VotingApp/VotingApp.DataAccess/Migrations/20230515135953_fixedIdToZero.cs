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
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "vote_db",
                table: "votes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "vote_db",
                table: "users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "vote_db",
                table: "polls",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "vote_db",
                table: "options",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 666, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(53));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(7575), "Tokgöz" });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 667, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 15, 16, 59, 53, 668, DateTimeKind.Local).AddTicks(1984));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "vote_db",
                table: "votes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "vote_db",
                table: "users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "vote_db",
                table: "polls",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "vote_db",
                table: "options",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastName" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(4351), "Tekgöz" });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6578));
        }
    }
}
