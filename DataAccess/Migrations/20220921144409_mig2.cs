using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Rentals",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRentable",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 44, 9, 216, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 44, 9, 216, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 44, 9, 216, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 44, 9, 216, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 44, 9, 216, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 14, 87, 198, 179, 73, 167, 110, 207, 34, 79, 34, 214, 48, 103, 10, 210, 187, 89, 36, 149, 133, 241, 67, 66, 241, 194, 205, 60, 235, 120, 160, 13, 152, 185, 89, 210, 16, 60, 176, 83, 117, 174, 116, 33, 99, 12, 162, 51, 170, 86, 114, 229, 141, 172, 35, 193, 204, 136, 115, 16, 46, 231, 227 }, new byte[] { 47, 184, 225, 167, 97, 248, 86, 204, 63, 59, 111, 239, 109, 131, 130, 65, 41, 122, 167, 37, 216, 249, 245, 46, 65, 137, 100, 36, 234, 164, 103, 86, 190, 22, 149, 246, 150, 16, 188, 27, 86, 226, 93, 59, 1, 7, 3, 248, 109, 9, 85, 238, 10, 67, 170, 107, 68, 189, 128, 186, 253, 3, 147, 45, 233, 215, 250, 242, 218, 47, 60, 192, 81, 175, 141, 251, 196, 57, 156, 135, 211, 190, 217, 77, 119, 80, 90, 8, 111, 189, 57, 192, 115, 169, 92, 86, 4, 210, 67, 13, 115, 195, 18, 175, 3, 99, 195, 119, 111, 41, 148, 20, 214, 52, 3, 58, 202, 162, 56, 238, 9, 61, 23, 124, 179, 103, 181, 153 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRentable",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Cars");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Rentals",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 9, 18, 17, 40, 27, 348, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 18, 17, 40, 27, 348, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 18, 17, 40, 27, 348, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 18, 17, 40, 27, 348, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 18, 17, 40, 27, 348, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 75, 34, 111, 142, 165, 216, 176, 25, 36, 179, 248, 168, 148, 94, 246, 151, 185, 148, 40, 37, 34, 87, 58, 7, 120, 73, 47, 151, 145, 33, 205, 36, 118, 48, 199, 52, 222, 191, 226, 93, 162, 111, 248, 34, 166, 51, 113, 52, 168, 161, 89, 28, 150, 162, 83, 63, 41, 46, 149, 2, 246, 0, 148, 214 }, new byte[] { 21, 122, 172, 11, 118, 182, 139, 245, 29, 227, 10, 85, 93, 3, 217, 228, 33, 121, 144, 228, 13, 31, 179, 44, 139, 239, 247, 162, 86, 80, 139, 83, 153, 83, 108, 70, 65, 76, 193, 142, 252, 72, 142, 186, 224, 107, 96, 159, 18, 58, 40, 59, 37, 98, 130, 7, 61, 199, 253, 155, 241, 204, 20, 154, 126, 25, 127, 197, 96, 71, 27, 68, 120, 57, 114, 188, 254, 186, 230, 39, 100, 25, 134, 1, 138, 160, 219, 158, 146, 34, 143, 80, 16, 242, 189, 3, 214, 20, 132, 183, 208, 65, 196, 189, 85, 114, 240, 168, 11, 34, 36, 143, 180, 14, 201, 91, 195, 215, 132, 29, 107, 203, 128, 159, 27, 58, 224, 99 } });
        }
    }
}
