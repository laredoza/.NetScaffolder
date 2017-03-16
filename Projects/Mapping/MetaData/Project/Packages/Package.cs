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
    using System.Xml.Serialization;

    using DotNetScaffolder.Core.Common.Validation;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The package defines which templates will be created.
    ///     i.e) DbContext, EF, ViewModel, etc
    /// </summary>
    public class Package : Hierarchy, IValidate
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        public Package()
        {
            this.Enabled = false;
            this.Templates = new List<Template>();
            this.ValidationResult = new List<Validation>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        public double Version { get; set; }

        /// <summary>
        ///     Gets or sets the templates.
        /// </summary>
        public List<Template> Templates { get; set; }

        #endregion

        #region Implementation of IValidate

        /// <summary>
        /// Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        /// <summary>
        ///     Validate class.
        /// </summary>
        /// <returns>
        ///     The <see cref="List{T}" />
        ///     Errors returned
        /// </returns>
        public List<Validation> Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}