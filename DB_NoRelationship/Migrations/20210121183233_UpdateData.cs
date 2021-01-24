// <copyright file="20210121183233_UpdateData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore.Migrations;

namespace DB_NoRelationship.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Class",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Class",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Class",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Class",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DepartmentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DepartmentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Class",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Class",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Class",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Class",
                value: 0);
        }
    }
}
