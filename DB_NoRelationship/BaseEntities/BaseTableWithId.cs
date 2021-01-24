// <copyright file="BaseTableWithId.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace DB_NoRelationship.BaseEntities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// BaseTableWithId .
    /// </summary>
    public abstract class BaseTableWithId
    {
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
    }
}
