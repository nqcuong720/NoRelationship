// <copyright file="20210121181636_Data_Entities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore.Migrations;

namespace DB_NoRelationship.Migrations
{
    public partial class Data_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "Id", "ClassName" },
                values: new object[,]
                {
                    { 1L, "Mạng Máy Tính" },
                    { 2L, "Hệ Điều Hành" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { 1L, "Công Nghệ Thông Tin" },
                    { 2L, "Lịch Sử" },
                    { 3L, "Tiểu Học" },
                    { 4L, "Văn Học" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "FirstName", "LastName", "Note", "Age" },
                values: new object[,]
                {
                    { 1L, "Cường", "Nguyễn", "No", 20 },
                    { 2L, "Đức", "Trần", "No No", 22 },
                    { 3L, "Diệp", "Võ", "No", 20 },
                    { 4L, "Hùng", "Nguyễn", "No", 48 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
