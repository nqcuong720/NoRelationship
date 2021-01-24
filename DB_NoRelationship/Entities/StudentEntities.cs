// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DB_NoRelationship.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;
    using DB_NoRelationship.BaseEntities;

    /// <summary>
    /// StudentEntities for Project.
    /// </summary>
    public class StudentEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets image .
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets firstName.
        /// </summary>
        [Column("FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets lastName.
        /// </summary>
        [Column("LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets studentAge .
        /// </summary>
        [Column("Age")]
        public int StudentAge { get; set; }

        /// <summary>
        /// Gets or sets note.
        /// </summary>
        [Column("Note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets class.
        /// </summary>
        [Column("Class")]
        public int ClassId { get; set; }

        /// <summary>
        /// Gets or sets classNavigation .
        /// </summary>
        // public virtual ClassEntities ClassNavigation { get; set; }.

        /// <summary>
        /// Gets or sets departmentNavigation.
        /// </summary>
        // public virtual DepartmentEntities DepartmentNavigation { get; set; }.
    }
}
