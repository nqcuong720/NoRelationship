﻿// <auto-generated />
using System;
using DB_NoRelationship.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DB_NoRelationship.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20210123154224_UpdateEntities")]
    partial class UpdateEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DB_NoRelationship.Entities.ClassEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .HasColumnName("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Department")
                        .HasColumnName("DepartmentId")
                        .HasColumnType("int");

                    b.Property<long?>("DepartmentIdNavigationId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentIdNavigationId");

                    b.ToTable("Class");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ClassName = "Mạng Máy Tính",
                            Department = 2
                        },
                        new
                        {
                            Id = 2L,
                            ClassName = "Hệ Điều Hành",
                            Department = 1
                        });
                });

            modelBuilder.Entity("DB_NoRelationship.Entities.DepartmentEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnName("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DepartmentName = "Công Nghệ Thông Tin"
                        },
                        new
                        {
                            Id = 2L,
                            DepartmentName = "Lịch Sử"
                        },
                        new
                        {
                            Id = 3L,
                            DepartmentName = "Tiểu Học"
                        },
                        new
                        {
                            Id = 4L,
                            DepartmentName = "Văn Học"
                        });
                });

            modelBuilder.Entity("DB_NoRelationship.Entities.StudentEntities", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId")
                        .HasColumnName("Class")
                        .HasColumnType("int");

                    b.Property<long?>("ClassNavigationId")
                        .HasColumnType("bigint");

                    b.Property<long?>("DepartmentNavigationId")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnName("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnName("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentAge")
                        .HasColumnName("Age")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassNavigationId");

                    b.HasIndex("DepartmentNavigationId");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ClassId = 1,
                            FirstName = "Cường",
                            LastName = "Nguyễn",
                            Note = "No",
                            StudentAge = 20
                        },
                        new
                        {
                            Id = 2L,
                            ClassId = 2,
                            FirstName = "Đức",
                            LastName = "Trần",
                            Note = "No No",
                            StudentAge = 22
                        },
                        new
                        {
                            Id = 3L,
                            ClassId = 1,
                            FirstName = "Diệp",
                            LastName = "Võ",
                            Note = "No",
                            StudentAge = 20
                        },
                        new
                        {
                            Id = 4L,
                            ClassId = 2,
                            FirstName = "Hùng",
                            LastName = "Nguyễn",
                            Note = "No",
                            StudentAge = 48
                        });
                });

            modelBuilder.Entity("DB_NoRelationship.Entities.ClassEntities", b =>
                {
                    b.HasOne("DB_NoRelationship.Entities.DepartmentEntities", "DepartmentIdNavigation")
                        .WithMany()
                        .HasForeignKey("DepartmentIdNavigationId");
                });

            modelBuilder.Entity("DB_NoRelationship.Entities.StudentEntities", b =>
                {
                    b.HasOne("DB_NoRelationship.Entities.ClassEntities", "ClassNavigation")
                        .WithMany()
                        .HasForeignKey("ClassNavigationId");

                    b.HasOne("DB_NoRelationship.Entities.DepartmentEntities", "DepartmentNavigation")
                        .WithMany()
                        .HasForeignKey("DepartmentNavigationId");
                });
#pragma warning restore 612, 618
        }
    }
}
