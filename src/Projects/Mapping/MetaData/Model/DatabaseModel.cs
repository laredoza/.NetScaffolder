﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseModel.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Model
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    ///     The database model.
    /// </summary>
    [Serializable]
    public class DatabaseModel
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DatabaseModel" /> class.
        /// </summary>
        public DatabaseModel()
        {
            this.Tables = new List<Table>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the domain.
        /// </summary>
        [XmlIgnore]
        public DomainDefinition Domain { get; set; }

        /// <summary>
        ///     Gets or sets the tables.
        /// </summary>
        [XmlArray("Tables")]
        [XmlArrayItem("Table")]
        public List<Table> Tables { get; set; }

        #endregion
    }
}