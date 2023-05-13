using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedSoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                schema: "vote_db",
                table: "votes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "vote_db",
                table: "votes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                schema: "vote_db",
                table: "users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "vote_db",
                table: "users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                schema: "vote_db",
                table: "polls",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "vote_db",
                table: "polls",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                schema: "vote_db",
                table: "options",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "vote_db",
                table: "options",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6156), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6233), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6236), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6238), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(6240), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(9523), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 625, DateTimeKind.Local).AddTicks(9529), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(4345), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(4351), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(4353), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(4355), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6565), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6570), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6571), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6575), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6576), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6577), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6578), null, false });

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "IsDeleted" },
                values: new object[] { new DateTime(2023, 5, 13, 10, 51, 22, 626, DateTimeKind.Local).AddTicks(6578), null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                schema: "vote_db",
                table: "votes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "vote_db",
                table: "votes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                schema: "vote_db",
                table: "users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "vote_db",
                table: "users");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                schema: "vote_db",
                table: "polls");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "vote_db",
                table: "polls");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                schema: "vote_db",
                table: "options");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "vote_db",
                table: "options");

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 431, DateTimeKind.Local).AddTicks(5372));

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

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7391));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 7, 20, 25, 36, 432, DateTimeKind.Local).AddTicks(7394));
        }
    }
}
