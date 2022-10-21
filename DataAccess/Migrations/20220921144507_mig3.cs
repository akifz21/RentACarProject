using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { true, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { true, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { true, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { true, 1 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { true, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 48, 200, 91, 229, 131, 36, 121, 101, 182, 121, 71, 223, 239, 158, 79, 4, 212, 61, 9, 131, 252, 131, 226, 2, 246, 90, 167, 161, 65, 156, 7, 63, 195, 217, 130, 3, 61, 36, 151, 175, 0, 154, 52, 126, 240, 151, 104, 85, 93, 85, 23, 112, 58, 72, 200, 16, 130, 155, 61, 157, 48, 89, 111, 148 }, new byte[] { 194, 114, 170, 22, 61, 234, 38, 114, 179, 13, 149, 14, 127, 157, 86, 82, 153, 215, 48, 143, 173, 211, 56, 162, 173, 101, 190, 8, 207, 131, 255, 208, 208, 71, 174, 22, 213, 30, 124, 102, 170, 125, 249, 56, 221, 28, 89, 108, 177, 149, 67, 112, 221, 184, 65, 226, 148, 159, 47, 84, 121, 48, 222, 11, 235, 7, 128, 152, 139, 235, 163, 240, 150, 188, 223, 117, 191, 186, 37, 202, 63, 79, 92, 33, 12, 155, 35, 157, 247, 154, 163, 93, 72, 182, 229, 182, 179, 11, 176, 87, 88, 103, 172, 222, 254, 224, 51, 193, 112, 235, 26, 234, 107, 32, 206, 90, 203, 247, 99, 41, 4, 147, 90, 60, 25, 85, 60, 158 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5,
                columns: new[] { "IsRentable", "OwnerId" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 226, 14, 87, 198, 179, 73, 167, 110, 207, 34, 79, 34, 214, 48, 103, 10, 210, 187, 89, 36, 149, 133, 241, 67, 66, 241, 194, 205, 60, 235, 120, 160, 13, 152, 185, 89, 210, 16, 60, 176, 83, 117, 174, 116, 33, 99, 12, 162, 51, 170, 86, 114, 229, 141, 172, 35, 193, 204, 136, 115, 16, 46, 231, 227 }, new byte[] { 47, 184, 225, 167, 97, 248, 86, 204, 63, 59, 111, 239, 109, 131, 130, 65, 41, 122, 167, 37, 216, 249, 245, 46, 65, 137, 100, 36, 234, 164, 103, 86, 190, 22, 149, 246, 150, 16, 188, 27, 86, 226, 93, 59, 1, 7, 3, 248, 109, 9, 85, 238, 10, 67, 170, 107, 68, 189, 128, 186, 253, 3, 147, 45, 233, 215, 250, 242, 218, 47, 60, 192, 81, 175, 141, 251, 196, 57, 156, 135, 211, 190, 217, 77, 119, 80, 90, 8, 111, 189, 57, 192, 115, 169, 92, 86, 4, 210, 67, 13, 115, 195, 18, 175, 3, 99, 195, 119, 111, 41, 148, 20, 214, 52, 3, 58, 202, 162, 56, 238, 9, 61, 23, 124, 179, 103, 181, 153 } });
        }
    }
}
