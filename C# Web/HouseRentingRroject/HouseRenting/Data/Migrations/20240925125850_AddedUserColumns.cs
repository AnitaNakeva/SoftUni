using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRenting.Data.Migrations
{
    public partial class AddedUserColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97e1353b-4dbc-4a47-b593-76a9454d8a8e", "Teodor", "Lesly", "AQAAAAEAACcQAAAAELgAxbTu7O6jt5o5HncvIIbsrVIfSSYTFWBz4n3BTAHNIYVeOiJGwe+j0y+zbYup9Q==", "f70c6e98-12c3-40cd-a32d-2cb696044fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dcf630f-32e6-4067-bd52-d2549f05ba35", "Linda", "Michaels", "AQAAAAEAACcQAAAAEJO7FWJoDCZRGrYo5G4WoWDjWUsSiwQbQc6qbZXKGx6+eg2IvfiwkbnRP1w9+ImzPQ==", "17892407-b88f-40c6-8fa4-fc1ddac91ee1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21955e5c-a3af-43e4-8267-538a43eea7db", "AQAAAAEAACcQAAAAENJumBzrYu+hDGbC6RXD0B8T2pGGE78/xnSy1p5vYfSHI6gipRzzezrGyOxNSmNjIA==", "d865609f-b259-4b8a-95bf-ffe4d851477f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7909cb3-13f0-4d34-8219-af0e12ec9ff5", "AQAAAAEAACcQAAAAEL9WaT1vIoSpMJybMp0x5uWMUXM1Ji0uaKEBVfpuowgGsU+//V+x6JTHDx/Y2XmIZw==", "80ca3588-845a-414a-a479-9ead259630a3" });
        }
    }
}
