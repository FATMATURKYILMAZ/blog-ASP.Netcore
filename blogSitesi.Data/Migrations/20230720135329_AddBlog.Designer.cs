﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blogSitesi.Data.Context;

#nullable disable

namespace blogSitesi.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230720135329_AddBlog")]
    partial class AddBlog
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("blogSitesi.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fada4326-915d-4ea3-af8d-d6706d8fc9a1"),
                            CategoryId = new Guid("540c738f-2d82-4866-84c0-e497700bfc74"),
                            Content = "ASP.NET Core MVC is a powerful framework for building web applications, but it is also important to ensure that your application is secure. Security is a critical aspect of any web application, and there are several best practices that you can follow to make sure that your ASP.NET Core MVC application is secure. In this article, we will explore some of the best practices for securing your ASP.NET Core MVC application.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 7, 20, 16, 53, 29, 402, DateTimeKind.Local).AddTicks(7669),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = new Guid("d9678411-71f1-41d5-8238-b9531b1083b1"),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "ASP.Net Core EF Article Essay",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("69d76eaf-7236-4d04-9a7c-2f93e8e845ca"),
                            CategoryId = new Guid("92b75f4a-fb11-4122-a8f6-d405cbd76045"),
                            Content = "Visual Studio ASP.NET Core MVC is a powerful framework for building web applications, but it is also important to ensure that your application is secure. Security is a critical aspect of any web application, and there are several best practices that you can follow to make sure that your ASP.NET Core MVC application is secure. In this article, we will explore some of the best practices for securing your ASP.NET Core MVC application.",
                            CreatedBy = "Admin Test2",
                            CreatedDate = new DateTime(2023, 7, 20, 16, 53, 29, 402, DateTimeKind.Local).AddTicks(7686),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = new Guid("2c2bd7a1-dea5-45a9-86f3-4204f9c0cc2c"),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Visual Studio Essay Article 1",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("blogSitesi.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("540c738f-2d82-4866-84c0-e497700bfc74"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 7, 20, 16, 53, 29, 402, DateTimeKind.Local).AddTicks(8410),
                            IsDeleted = false,
                            name = "ASP.Net Core"
                        },
                        new
                        {
                            Id = new Guid("92b75f4a-fb11-4122-a8f6-d405cbd76045"),
                            CreatedBy = "Admin Test2",
                            CreatedDate = new DateTime(2023, 7, 20, 16, 53, 29, 402, DateTimeKind.Local).AddTicks(8417),
                            IsDeleted = false,
                            name = "Visual Studio 2023"
                        });
                });

            modelBuilder.Entity("blogSitesi.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("fileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d9678411-71f1-41d5-8238-b9531b1083b1"),
                            CreatedBy = "Admin Test3",
                            CreatedDate = new DateTime(2023, 7, 20, 16, 53, 29, 402, DateTimeKind.Local).AddTicks(8799),
                            IsDeleted = false,
                            fileName = "images/testimages",
                            fileType = "jpg"
                        },
                        new
                        {
                            Id = new Guid("2c2bd7a1-dea5-45a9-86f3-4204f9c0cc2c"),
                            CreatedBy = "Admin Test4",
                            CreatedDate = new DateTime(2023, 7, 20, 16, 53, 29, 402, DateTimeKind.Local).AddTicks(8835),
                            IsDeleted = false,
                            fileName = "images/vstest",
                            fileType = "png"
                        });
                });

            modelBuilder.Entity("blogSitesi.Entity.Entities.Article", b =>
                {
                    b.HasOne("blogSitesi.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blogSitesi.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("blogSitesi.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("blogSitesi.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
