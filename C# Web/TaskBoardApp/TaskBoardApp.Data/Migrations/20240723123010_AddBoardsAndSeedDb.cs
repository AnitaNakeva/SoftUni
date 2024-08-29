using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp.Data.Migrations
{
    public partial class AddBoardsAndSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("1daca26a-41b8-441f-8a38-a3f7c0ef3a3d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("639ced49-0f4d-4f55-80d1-b86b950303cd"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("7dde03c0-dfae-43a4-a666-9eb2b9feabf8"));

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[] { new Guid("02551d7f-0daa-4928-82df-79cf7fc30a3b"), 1, new DateTime(2024, 1, 5, 12, 30, 10, 75, DateTimeKind.Utc).AddTicks(8524), "LJNDonfn fnerorn fren ffrr ntonto.", "a0fe5445-0c5a-4363-9ed6-55a38fe009f6", "Improve CSS styles" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[] { new Guid("3dd42862-5be8-402a-bae1-678028093d97"), 3, new DateTime(2024, 1, 5, 12, 30, 10, 75, DateTimeKind.Utc).AddTicks(8550), "LJNDonfn fnerorn fren ffrr ntonto.", "d9f382f0-9670-49fd-ae1c-1bc074a28d93", "Improve CSS styles 3" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[] { new Guid("4f22a455-9870-4bc5-b34d-f6c6f6292c11"), 2, new DateTime(2024, 1, 5, 12, 30, 10, 75, DateTimeKind.Utc).AddTicks(8545), "LJNDonfn fnerorn fren ffrr ntonto.", "b7488d11-9c04-4924-bd06-055dca1ad7cd", "Improve CSS styles 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("02551d7f-0daa-4928-82df-79cf7fc30a3b"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3dd42862-5be8-402a-bae1-678028093d97"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("4f22a455-9870-4bc5-b34d-f6c6f6292c11"));

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[] { new Guid("1daca26a-41b8-441f-8a38-a3f7c0ef3a3d"), 2, new DateTime(2024, 1, 5, 12, 28, 50, 911, DateTimeKind.Utc).AddTicks(1465), "LJNDonfn fnerorn fren ffrr ntonto.", "b7488d11-9c04-4924-bd06-055dca1ad7cd", "Improve CSS styles 2" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[] { new Guid("639ced49-0f4d-4f55-80d1-b86b950303cd"), 1, new DateTime(2024, 1, 5, 12, 28, 50, 911, DateTimeKind.Utc).AddTicks(1446), "LJNDonfn fnerorn fren ffrr ntonto.", "a0fe5445-0c5a-4363-9ed6-55a38fe009f6", "Improve CSS styles" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[] { new Guid("7dde03c0-dfae-43a4-a666-9eb2b9feabf8"), 3, new DateTime(2024, 1, 5, 12, 28, 50, 911, DateTimeKind.Utc).AddTicks(1493), "LJNDonfn fnerorn fren ffrr ntonto.", "d9f382f0-9670-49fd-ae1c-1bc074a28d93", "Improve CSS styles 3" });
        }
    }
}
