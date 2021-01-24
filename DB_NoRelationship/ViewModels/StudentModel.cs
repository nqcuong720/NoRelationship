// <copyright file="StudentModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using DB_NoRelationship.BaseEntities;

namespace DB_NoRelationship.ViewModels
{
    public class StudentModel : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets image. 
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
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets department .
        /// </summary>
        [Column("Department")]
        public string Department { get; set; }
    }
}
