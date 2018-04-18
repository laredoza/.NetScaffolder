// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Package.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    #region Usings

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
    [Serializable]
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

        #region Public Properties

        /// <summary>
        ///     Gets or sets the templates.
        /// </summary>
        public List<Template> Templates { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        public double Version { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The return package items.
        /// </summary>
        /// <param name="packages">
        /// The packages.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Package> ReturnPackageItems(List<Package> packages)
        {
            List<Package> results = new List<Package>();

            foreach (Package package in packages)
            {
                results.AddRange(this.ReturnPackageItems(package));
            }

            return results;
        }

        /// <summary>
        ///     The return package items.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Package> ReturnPackageItems()
        {
            return this.ReturnPackageItems(this);
        }

        /// <summary>
        /// The return package items.
        /// </summary>
        /// <param name="package">
        /// The package.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Package> ReturnPackageItems(Package package)
        {
            List<Package> result = new List<Package>();

            if (package.HierarchyType == FormControls.Enum.HierarchyType.Item)
            {
                result.Add(package);
            }
            else
            {
                foreach (Hierarchy child in package.Children)
                {
                    if (package.HierarchyType == FormControls.Enum.HierarchyType.Item)
                    {
                        result.Add(child as Package);
                    }
                    else
                    {
                        result.AddRange(this.ReturnPackageItems(child as Package));
                    }
                }
            }

            return result;
        }

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