// <copyright file="EntityContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DB_NoRelationship.Data
{
    using DB_NoRelationship.Entities;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// EntityContext .
    /// </summary>
    public class EntityContext : DbContext
    {
        /// <summary>
        /// Gets or sets class.
        /// </summary>
        public DbSet<ClassEntities> ClassEntities { get; set; }

        /// <summary>
        /// Gets or sets student.
        /// </summary>
        public DbSet<StudentEntities> StudentEntities { get; set; }

        /// <summary>
        /// Gets or sets department.
        /// </summary>
        public DbSet<DepartmentEntities> DepartmentEntities { get; set; }

        /// <summary>
        /// ok.
        /// </summary>
        /// <param name="options">ok.</param>
        public EntityContext(DbContextOptions options)
            : base(options)
        {
        }

        /// <summary>
        /// ModelBuider.
        /// </summary>
        /// <param name="modelBuilder"> modelBuilder. </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassEntities>().ToTable("Class").HasKey(x => x.Id);
            modelBuilder.Entity<StudentEntities>().ToTable("Student").HasKey(x => x.Id);
            modelBuilder.Entity<DepartmentEntities>().ToTable("Department").HasKey(x => x.Id);
            modelBuilder.SeedDataDefault();
        }
    }
}
