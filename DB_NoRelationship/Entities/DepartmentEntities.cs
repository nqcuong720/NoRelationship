// <copyright file="DepartmentEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DB_NoRelationship.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;
    using DB_NoRelationship.BaseEntities;

    /// <summary>
    /// Department for project.
    /// </summary>
    public class DepartmentEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets departmnetName.
        /// </summary>
        [Column("DepartmentName")]
        public string DepartmentName { get; set; }
    }
}
