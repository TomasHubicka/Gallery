using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gallery.Migrations
{
    public partial class NewImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e21b584c-4d42-4ea7-8d9d-91fdf5ea0048", "AQAAAAEAACcQAAAAEK7Oxte4T5A7scEMpQSFnH0H1ob91aYsj7Fi3sFvgy8LvwuoS8DQGwKzEr3YqnFrig==" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "GalleryId", "Name", "OwnerId", "Source" },
                values: new object[] { new Guid("43214321-4321-4321-4321-432143214321"), new Guid("12345678-1234-1234-1234-123456781234"), "Maou", new Guid("11111111-1111-1111-1111-111111111111"), "https://www.covercentury.com/covers/audio/m/maoyuu-maou-yuusha-o_takeshi-hama_30803434.jpg" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "GalleryId", "Name", "OwnerId", "Source" },
                values: new object[] { new Guid("12121212-1212-1212-1212-121212121212"), new Guid("12345678-1234-1234-1234-123456781234"), "Sinon", new Guid("11111111-1111-1111-1111-111111111111"), "https://i.pinimg.com/originals/6e/36/b5/6e36b544c8f6edb3d509c7cbb59fa84d.jpg" });

            migrationBuilder.InsertData(
                table: "GalleryImages",
                columns: new[] { "GalleryId", "ImageId" },
                values: new object[] { new Guid("12345678-1234-1234-1234-123456781234"), new Guid("12121212-1212-1212-1212-121212121212") });

            migrationBuilder.InsertData(
                table: "GalleryImages",
                columns: new[] { "GalleryId", "ImageId" },
                values: new object[] { new Guid("12345678-1234-1234-1234-123456781234"), new Guid("43214321-4321-4321-4321-432143214321") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GalleryImages",
                keyColumns: new[] { "GalleryId", "ImageId" },
                keyValues: new object[] { new Guid("12345678-1234-1234-1234-123456781234"), new Guid("12121212-1212-1212-1212-121212121212") });

            migrationBuilder.DeleteData(
                table: "GalleryImages",
                keyColumns: new[] { "GalleryId", "ImageId" },
                keyValues: new object[] { new Guid("12345678-1234-1234-1234-123456781234"), new Guid("43214321-4321-4321-4321-432143214321") });

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("12121212-1212-1212-1212-121212121212"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("43214321-4321-4321-4321-432143214321"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4ef05ae-2d0d-4711-a588-350c620ea3f9", "AQAAAAEAACcQAAAAEB1UGslwxsrVcvc7vDhkyAm6eprE23MIEw/aFBrJuWSRYTpgc54/xl1JI2uU8VUb+w==" });
        }
    }
}
