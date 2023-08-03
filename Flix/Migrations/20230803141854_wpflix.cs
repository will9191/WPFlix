using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flix.Migrations
{
    public partial class wpflix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "132dbe3c-221a-43d0-8e98-675c617fe421", "cb904ca5-555c-49db-b392-5535159592b2", "Administrador", "ADMINISTRADOR" },
                    { "7648217c-c970-4041-9589-5ea026788fe6", "985efb43-96ad-428e-91ad-fdff57e5e460", "User", "USER" },
                    { "ee0fd447-a4fa-421a-9f41-6af51a313451", "cac99212-3b43-434e-ae38-4f9947da8521", "Mod", "MOD" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fd20e098-0b51-4564-ade3-ea03d744b4ea", 0, "d98956d8-4378-4662-a150-70e2235d9e9d", new DateTime(2005, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "willian.fernando040@gmail.com", true, false, null, "Willian", "WILLIAN.FERNANDO040@GMAIL.COM", "WILL", "AQAAAAEAACcQAAAAEO24ilb26f6tobBmp4fFphKSI9vWnYqlhXzWibnKws5tJ+p16tN9jwS4NnQVNVjI6w==", "14982260514", true, "/img/users/avatar.png", "4cc62ad2-3ac8-4387-8c7a-39236fcf1bb7", false, "Will" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "132dbe3c-221a-43d0-8e98-675c617fe421", "fd20e098-0b51-4564-ade3-ea03d744b4ea" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7648217c-c970-4041-9589-5ea026788fe6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ee0fd447-a4fa-421a-9f41-6af51a313451");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "132dbe3c-221a-43d0-8e98-675c617fe421", "fd20e098-0b51-4564-ade3-ea03d744b4ea" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "132dbe3c-221a-43d0-8e98-675c617fe421");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fd20e098-0b51-4564-ade3-ea03d744b4ea");

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
    }
}
