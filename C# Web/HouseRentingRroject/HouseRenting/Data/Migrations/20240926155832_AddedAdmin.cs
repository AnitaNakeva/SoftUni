using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRenting.Data.Migrations
{
    public partial class AddedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da6032af-9425-4cec-b4db-60a77d737c8b", "AQAAAAEAACcQAAAAED5B195NmPoN5cm8Wo9GaWFmmi0jpkTRS7B62TJp6xXC2EylIahtw/uIMFdCcAZMrw==", "2b015e15-ea04-4136-a256-10654a1a9613" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb31e34e-bf6a-4e37-9c3d-bb6c2c97998b", "AQAAAAEAACcQAAAAEFt2yHdtXeIPbTdFdadl6LxGcBnB307tMvzKkmLr19/dAKk3aXStINHa2mHfhkw6rA==", "dd123009-bd58-4a88-8490-dcf9338099c0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "c7633893-b376-4b3c-ae32-ea244d1a1640", "adminmail@abv.bg", false, "Great", "Admin", false, null, "adminmail@abv.bg", "adminmail@abv.bg", "AQAAAAEAACcQAAAAEFD6VW64NgyEb4hhx2uxaEDWM3t/FP8M15Z5Ce9NyigZGNqhcMOz98IOXSefigHeQA==", null, false, "4249655a-5b03-41f7-9e94-931d1989ea21", false, "adminmail@abv.bg" });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 4, "+359123456789", "bcb4f072-ecca-43c9-ab26-c060c6f364e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97e1353b-4dbc-4a47-b593-76a9454d8a8e", "AQAAAAEAACcQAAAAELgAxbTu7O6jt5o5HncvIIbsrVIfSSYTFWBz4n3BTAHNIYVeOiJGwe+j0y+zbYup9Q==", "f70c6e98-12c3-40cd-a32d-2cb696044fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dcf630f-32e6-4067-bd52-d2549f05ba35", "AQAAAAEAACcQAAAAEJO7FWJoDCZRGrYo5G4WoWDjWUsSiwQbQc6qbZXKGx6+eg2IvfiwkbnRP1w9+ImzPQ==", "17892407-b88f-40c6-8fa4-fc1ddac91ee1" });
        }
    }
}
