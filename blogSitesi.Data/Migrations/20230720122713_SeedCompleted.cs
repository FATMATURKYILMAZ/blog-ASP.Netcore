using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace blogSitesi.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3f4ed7d2-a24c-480d-a027-ddbc41e133cc"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7e24abfb-290e-403c-aeac-d61f1b31b2f9"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1d5676ee-7304-4796-8671-b5e3b5d77361"), new Guid("00000000-0000-0000-0000-000000000000"), "Visual Studio ASP.NET Core MVC is a powerful framework for building web applications, but it is also important to ensure that your application is secure. Security is a critical aspect of any web application, and there are several best practices that you can follow to make sure that your ASP.NET Core MVC application is secure. In this article, we will explore some of the best practices for securing your ASP.NET Core MVC application.", "Admin Test2", new DateTime(2023, 7, 20, 15, 27, 13, 38, DateTimeKind.Local).AddTicks(8306), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c2bd7a1-dea5-45a9-86f3-4204f9c0cc2c"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio Essay Article 1", 15 },
                    { new Guid("2ae345aa-46e8-470c-ba0b-18615af1a1b4"), new Guid("540c738f-2d82-4866-84c0-e497700bfc74"), "ASP.NET Core MVC is a powerful framework for building web applications, but it is also important to ensure that your application is secure. Security is a critical aspect of any web application, and there are several best practices that you can follow to make sure that your ASP.NET Core MVC application is secure. In this article, we will explore some of the best practices for securing your ASP.NET Core MVC application.", "Admin Test", new DateTime(2023, 7, 20, 15, 27, 13, 38, DateTimeKind.Local).AddTicks(8271), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9678411-71f1-41d5-8238-b9531b1083b1"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.Net Core EF Article Essay", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("540c738f-2d82-4866-84c0-e497700bfc74"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 15, 27, 13, 38, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92b75f4a-fb11-4122-a8f6-d405cbd76045"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 15, 27, 13, 38, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2c2bd7a1-dea5-45a9-86f3-4204f9c0cc2c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 15, 27, 13, 38, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d9678411-71f1-41d5-8238-b9531b1083b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 15, 27, 13, 38, DateTimeKind.Local).AddTicks(9616));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1d5676ee-7304-4796-8671-b5e3b5d77361"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2ae345aa-46e8-470c-ba0b-18615af1a1b4"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3f4ed7d2-a24c-480d-a027-ddbc41e133cc"), new Guid("540c738f-2d82-4866-84c0-e497700bfc74"), "ASP.NET Core MVC is a powerful framework for building web applications, but it is also important to ensure that your application is secure. Security is a critical aspect of any web application, and there are several best practices that you can follow to make sure that your ASP.NET Core MVC application is secure. In this article, we will explore some of the best practices for securing your ASP.NET Core MVC application.", "Admin Test", new DateTime(2023, 7, 20, 15, 19, 16, 122, DateTimeKind.Local).AddTicks(4531), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9678411-71f1-41d5-8238-b9531b1083b1"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.Net Core EF Article Essay", 15 },
                    { new Guid("7e24abfb-290e-403c-aeac-d61f1b31b2f9"), new Guid("00000000-0000-0000-0000-000000000000"), "Visual Studio ASP.NET Core MVC is a powerful framework for building web applications, but it is also important to ensure that your application is secure. Security is a critical aspect of any web application, and there are several best practices that you can follow to make sure that your ASP.NET Core MVC application is secure. In this article, we will explore some of the best practices for securing your ASP.NET Core MVC application.", "Admin Test2", new DateTime(2023, 7, 20, 15, 19, 16, 122, DateTimeKind.Local).AddTicks(4546), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c2bd7a1-dea5-45a9-86f3-4204f9c0cc2c"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio Essay Article 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("540c738f-2d82-4866-84c0-e497700bfc74"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 15, 19, 16, 122, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92b75f4a-fb11-4122-a8f6-d405cbd76045"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 15, 19, 16, 122, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2c2bd7a1-dea5-45a9-86f3-4204f9c0cc2c"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 15, 19, 16, 122, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d9678411-71f1-41d5-8238-b9531b1083b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 20, 15, 19, 16, 122, DateTimeKind.Local).AddTicks(5737));
        }
    }
}
