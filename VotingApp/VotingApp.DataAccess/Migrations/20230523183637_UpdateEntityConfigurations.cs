using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VotingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntityConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_options_polls_PollId",
                schema: "vote_db",
                table: "options");

            migrationBuilder.DropForeignKey(
                name: "FK_polls_users_CreatedById",
                schema: "vote_db",
                table: "polls");

            migrationBuilder.DropForeignKey(
                name: "FK_votes_options_OptionId",
                schema: "vote_db",
                table: "votes");

            migrationBuilder.DropForeignKey(
                name: "FK_votes_users_UserId",
                schema: "vote_db",
                table: "votes");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                schema: "vote_db",
                table: "votes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 530, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 530, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 530, DateTimeKind.Local).AddTicks(5836));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 530, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "options",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 530, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 530, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "polls",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 530, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                schema: "vote_db",
                table: "votes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 23, 21, 36, 37, 531, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.AddForeignKey(
                name: "FK_options_polls_PollId",
                schema: "vote_db",
                table: "options",
                column: "PollId",
                principalSchema: "vote_db",
                principalTable: "polls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_polls_users_CreatedById",
                schema: "vote_db",
                table: "polls",
                column: "CreatedById",
                principalSchema: "vote_db",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_votes_options_OptionId",
                schema: "vote_db",
                table: "votes",
                column: "OptionId",
                principalSchema: "vote_db",
                principalTable: "options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_votes_users_UserId",
                schema: "vote_db",
                table: "votes",
                column: "UserId",
                principalSchema: "vote_db",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_options_polls_PollId",
                schema: "vote_db",
                table: "options");

            migrationBuilder.DropForeignKey(
                name: "FK_polls_users_CreatedById",
                schema: "vote_db",
                table: "polls");

            migrationBuilder.DropForeignKey(
                name: "FK_votes_options_OptionId",
                schema: "vote_db",
                table: "votes");

            migrationBuilder.DropForeignKey(
                name: "FK_votes_users_UserId",
                schema: "vote_db",
                table: "votes");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                schema: "vote_db",
                table: "votes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_options_polls_PollId",
                schema: "vote_db",
                table: "options",
                column: "PollId",
                principalSchema: "vote_db",
                principalTable: "polls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_polls_users_CreatedById",
                schema: "vote_db",
                table: "polls",
                column: "CreatedById",
                principalSchema: "vote_db",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_votes_options_OptionId",
                schema: "vote_db",
                table: "votes",
                column: "OptionId",
                principalSchema: "vote_db",
                principalTable: "options",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_votes_users_UserId",
                schema: "vote_db",
                table: "votes",
                column: "UserId",
                principalSchema: "vote_db",
                principalTable: "users",
                principalColumn: "Id");
        }
    }
}
