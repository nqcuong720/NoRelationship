// <copyright file="20210123154224_UpdateEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore.Migrations;

namespace DB_NoRelationship.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ClassNavigationId",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DepartmentNavigationId",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DepartmentIdNavigationId",
                table: "Class",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassNavigationId",
                table: "Student",
                column: "ClassNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_DepartmentNavigationId",
                table: "Student",
                column: "DepartmentNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_DepartmentIdNavigationId",
                table: "Class",
                column: "DepartmentIdNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Department_DepartmentIdNavigationId",
                table: "Class",
                column: "DepartmentIdNavigationId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Class_ClassNavigationId",
                table: "Student",
                column: "ClassNavigationId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_DepartmentNavigationId",
                table: "Student",
                column: "DepartmentNavigationId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Department_DepartmentIdNavigationId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Class_ClassNavigationId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_DepartmentNavigationId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_ClassNavigationId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_DepartmentNavigationId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Class_DepartmentIdNavigationId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "ClassNavigationId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DepartmentNavigationId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DepartmentIdNavigationId",
                table: "Class");
        }
    }
}
