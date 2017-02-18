// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Package.cs" company="">
//   
// </copyright>
// <summary>
//   The package defines which templates will be created.
//   i.e) DbContext, EF, ViewModel, etc
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    #region Using

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The package defines which templates will be created.
    ///     i.e) DbContext, EF, ViewModel, etc
    /// </summary>
    public class Package
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        public Package()
        {
            this.Enabled = false;
            this.Templates = new List<Template>();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets a value indicating whether enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the templates.
        /// </summary>
        public List<Template> Templates { get; set; }

        #endregion
    }
}