// <copyright file="ClassEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DB_NoRelationship.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;
    using DB_NoRelationship.BaseEntities;

    /// <summary>
    /// ClassEntities for project.
    /// </summary>
    public class ClassEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets className.
        /// </summary>
        [Column("ClassName")]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets department.
        /// </summary>
        [Column("DepartmentId")]
        public int Department { get; set; }

        /// <summary>
        /// Gets or sets departmentIdNavigation.
        /// </summary>
        // public virtual DepartmentEntities DepartmentIdNavigation { get; set; }.
    }
}
