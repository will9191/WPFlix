using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flix.Migrations
{
    public partial class criandobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "152408e1-ebae-4341-89a7-ff0eea20eb57");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2701258d-2b09-4e01-91f0-011e5ab18152");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2cf01b70-cc17-4077-8b54-590ed3aa68f4", "4421698e-9ee2-4245-87f2-849f395d4e9c" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2cf01b70-cc17-4077-8b54-590ed3aa68f4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4421698e-9ee2-4245-87f2-849f395d4e9c");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8f0e0c97-7ed6-41fa-a97a-057c49f4be70", "12d8541f-ba49-4fb1-bce8-df3cac1efb5a", "Administrador", "ADMINISTRADOR" },
                    { "ba85201e-2f62-4516-b2fe-6598387fe52b", "bea30b03-bc3b-46f5-9be4-1ed99e4be58f", "Mod", "MOD" },
                    { "c06bc3ca-64e7-4e54-8a1d-ef4df9324915", "d02d0aaa-2ff3-4999-b0c3-d79e7e47627d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dbbea9c3-f5bb-4f55-a7e6-930ddbf650ac", 0, "bdbaa50e-26af-47bc-af8c-d225d3ffeb81", new DateTime(2005, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "willian.fernando040@gmail.com", true, false, null, "Willian", "WILLIAN.FERNANDO040@GMAIL.COM", "WILL", "AQAAAAEAACcQAAAAENM7CwDKtiUNlVDR30Zb9cePZnAtcPrviQEoxvxAqKbrRg8qn7T6XiWENIdPcv4jjg==", "14982260514", true, "/img/users/avatar.png", "8c1e7b33-beba-4c59-893f-2ff9660f6a41", false, "Will" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8f0e0c97-7ed6-41fa-a97a-057c49f4be70", "dbbea9c3-f5bb-4f55-a7e6-930ddbf650ac" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ba85201e-2f62-4516-b2fe-6598387fe52b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c06bc3ca-64e7-4e54-8a1d-ef4df9324915");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f0e0c97-7ed6-41fa-a97a-057c49f4be70", "dbbea9c3-f5bb-4f55-a7e6-930ddbf650ac" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8f0e0c97-7ed6-41fa-a97a-057c49f4be70");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dbbea9c3-f5bb-4f55-a7e6-930ddbf650ac");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "152408e1-ebae-4341-89a7-ff0eea20eb57", "7ded9858-7c2d-44df-aa08-5d6f9c6ec634", "Moderador", "MODERADOR" },
                    { "2701258d-2b09-4e01-91f0-011e5ab18152", "c4caf69f-3199-42bb-be53-14b5ebf330fb", "Usuário", "USUÁRIO" },
                    { "2cf01b70-cc17-4077-8b54-590ed3aa68f4", "d76eb97a-4475-4adc-add7-5f0615a22203", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4421698e-9ee2-4245-87f2-849f395d4e9c", 0, "648f6e42-2fe9-43aa-befa-38482e587d4a", new DateTime(2005, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "willian.fernando040@gmail.com", true, false, null, "Willian", "WILLIAN.FERNANDO040@GMAIL.COM", "WILL", "AQAAAAEAACcQAAAAEGfS5lIHVrIHlRnT5Q0Xw/GxBqClWcW54Yj2Q7wxPirIe1KpI4EiJxypfjY/enDfuw==", "14982260514", true, "/img/users/avatar.png", "58df18a6-2025-4124-9c94-0500a4536d3a", false, "Will" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2cf01b70-cc17-4077-8b54-590ed3aa68f4", "4421698e-9ee2-4245-87f2-849f395d4e9c" });
        }
    }
}
