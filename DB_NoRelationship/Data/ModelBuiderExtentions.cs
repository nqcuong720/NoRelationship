// <copyright file="ModelBuiderExtentions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DB_NoRelationship.Data
{
    using DB_NoRelationship.Entities;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// seeddata.
    /// </summary>
    public static class ModelBuiderExtentions
    {
        /// <summary>
        /// model Builder.
        /// </summary>
        /// <param name="modelBuilder">modelBuider.</param>
        public static void SeedDataDefault(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassEntities>().HasData(
                new ClassEntities() { Id = 1, ClassName = "Mạng Máy Tính", Department = 2 },
                new ClassEntities() { Id = 2, ClassName = "Hệ Điều Hành", Department = 1 });

            modelBuilder.Entity<StudentEntities>().HasData(
                new StudentEntities() { Id = 1, FirstName = "Cường", LastName = "Nguyễn", StudentAge = 20, Note = "No", ClassId = 1 },
                new StudentEntities() { Id = 2, FirstName = "Đức", LastName = "Trần", StudentAge = 22, Note = "No No", ClassId = 2 },
                new StudentEntities() { Id = 3, FirstName = "Diệp", LastName = "Võ", StudentAge = 20, Note = "No", ClassId = 1 },
                new StudentEntities() { Id = 4, FirstName = "Hùng", LastName = "Nguyễn", StudentAge = 48, Note = "No", ClassId = 2 });
            modelBuilder.Entity<DepartmentEntities>().HasData(
                    new DepartmentEntities() { Id = 1,  DepartmentName = "Công Nghệ Thông Tin" },
                    new DepartmentEntities() { Id = 2,  DepartmentName = "Lịch Sử" },
                    new DepartmentEntities() { Id = 3, DepartmentName = "Tiểu Học" },
                    new DepartmentEntities() { Id = 4,  DepartmentName = "Văn Học" });
        }
    }
}
