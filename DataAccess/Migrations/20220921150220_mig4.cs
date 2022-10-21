using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RentDate",
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
                value: new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 76, 145, 155, 123, 143, 217, 23, 13, 172, 174, 73, 235, 177, 103, 84, 23, 250, 158, 229, 179, 163, 15, 121, 133, 86, 88, 104, 46, 81, 197, 61, 226, 200, 96, 153, 31, 136, 192, 178, 142, 30, 218, 26, 93, 242, 194, 126, 27, 145, 222, 45, 134, 18, 114, 210, 172, 108, 152, 187, 16, 242, 69, 242, 153 }, new byte[] { 229, 64, 172, 188, 93, 27, 148, 149, 195, 157, 71, 146, 228, 143, 88, 229, 174, 186, 233, 167, 238, 176, 180, 4, 34, 38, 8, 70, 207, 40, 204, 30, 0, 254, 16, 252, 194, 19, 46, 105, 131, 185, 29, 130, 195, 45, 196, 193, 166, 151, 183, 21, 236, 233, 82, 44, 16, 218, 223, 41, 37, 63, 242, 155, 255, 52, 6, 114, 61, 183, 252, 236, 85, 148, 144, 27, 181, 33, 226, 197, 59, 14, 101, 142, 169, 176, 33, 39, 245, 241, 12, 216, 214, 240, 185, 112, 196, 62, 21, 18, 17, 186, 116, 175, 142, 225, 66, 182, 84, 81, 243, 89, 133, 41, 29, 14, 98, 167, 111, 87, 34, 56, 0, 47, 249, 22, 126, 208 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RentDate",
                table: "Rentals",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 45, 7, 454, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 45, 7, 454, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 45, 7, 454, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 45, 7, 454, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "CarImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2022, 9, 21, 17, 45, 7, 454, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 48, 200, 91, 229, 131, 36, 121, 101, 182, 121, 71, 223, 239, 158, 79, 4, 212, 61, 9, 131, 252, 131, 226, 2, 246, 90, 167, 161, 65, 156, 7, 63, 195, 217, 130, 3, 61, 36, 151, 175, 0, 154, 52, 126, 240, 151, 104, 85, 93, 85, 23, 112, 58, 72, 200, 16, 130, 155, 61, 157, 48, 89, 111, 148 }, new byte[] { 194, 114, 170, 22, 61, 234, 38, 114, 179, 13, 149, 14, 127, 157, 86, 82, 153, 215, 48, 143, 173, 211, 56, 162, 173, 101, 190, 8, 207, 131, 255, 208, 208, 71, 174, 22, 213, 30, 124, 102, 170, 125, 249, 56, 221, 28, 89, 108, 177, 149, 67, 112, 221, 184, 65, 226, 148, 159, 47, 84, 121, 48, 222, 11, 235, 7, 128, 152, 139, 235, 163, 240, 150, 188, 223, 117, 191, 186, 37, 202, 63, 79, 92, 33, 12, 155, 35, 157, 247, 154, 163, 93, 72, 182, 229, 182, 179, 11, 176, 87, 88, 103, 172, 222, 254, 224, 51, 193, 112, 235, 26, 234, 107, 32, 206, 90, 203, 247, 99, 41, 4, 147, 90, 60, 25, 85, 60, 158 } });
        }
    }
}
