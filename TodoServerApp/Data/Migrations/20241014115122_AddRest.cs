using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FinishDate",
                table: "TaskItems",
                newName: "FinishTDate");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "TaskItems",
                newName: "CreateTDate");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 14, 16, 51, 21, 943, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 14, 16, 51, 21, 943, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 14, 16, 51, 21, 943, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 14, 16, 51, 21, 943, DateTimeKind.Local).AddTicks(2304));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FinishTDate",
                table: "TaskItems",
                newName: "FinishDate");

            migrationBuilder.RenameColumn(
                name: "CreateTDate",
                table: "TaskItems",
                newName: "CreateDate");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 7, 18, 24, 18, 512, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 7, 18, 24, 18, 512, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 7, 18, 24, 18, 512, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 7, 18, 24, 18, 512, DateTimeKind.Local).AddTicks(9212));
        }
    }
}
