using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoutubeBlog.Data.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("29713c56-e93a-475f-a596-ff19fe254b1f"), "Admin Test", new DateTime(2023, 6, 7, 13, 35, 41, 852, DateTimeKind.Local).AddTicks(4629), "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adminn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core" },
                    { new Guid("43df9b9a-a17f-449b-a79d-414a684e7350"), "Admin Test", new DateTime(2023, 6, 7, 13, 35, 41, 852, DateTimeKind.Local).AddTicks(4632), "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Adminn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("00a5354d-0d30-4576-a128-78efcbed9849"), "Admin Test", new DateTime(2023, 6, 7, 13, 35, 41, 852, DateTimeKind.Local).AddTicks(4716), "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage", "abc", false, "Adminn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("be2c73cf-c312-485e-be69-7f7a7027829e"), "Admin Test", new DateTime(2023, 6, 7, 13, 35, 41, 852, DateTimeKind.Local).AddTicks(4719), "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage", "abc", false, "Adminn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("97cc1628-e96f-44a7-888a-b240db8dceab"), new Guid("29713c56-e93a-475f-a596-ff19fe254b1f"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "Admin Test", new DateTime(2023, 6, 7, 13, 35, 41, 852, DateTimeKind.Local).AddTicks(4465), "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00a5354d-0d30-4576-a128-78efcbed9849"), false, "Adminn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("b58cd382-09de-4176-813d-67898aa5c7b9"), new Guid("43df9b9a-a17f-449b-a79d-414a684e7350"), "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.", "Admin Test", new DateTime(2023, 6, 7, 13, 35, 41, 852, DateTimeKind.Local).AddTicks(4473), "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("be2c73cf-c312-485e-be69-7f7a7027829e"), false, "Adminn", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.", 25 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("97cc1628-e96f-44a7-888a-b240db8dceab"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b58cd382-09de-4176-813d-67898aa5c7b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29713c56-e93a-475f-a596-ff19fe254b1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43df9b9a-a17f-449b-a79d-414a684e7350"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("00a5354d-0d30-4576-a128-78efcbed9849"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("be2c73cf-c312-485e-be69-7f7a7027829e"));
        }
    }
}
