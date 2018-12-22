// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiServiceData.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.WebApiServiceDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;

    #endregion

    /// <summary>
    ///     The context data.
    /// </summary>
    public class WebApiServiceData
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="WebApiServiceData" /> class.
        /// </summary>
        public WebApiServiceData()
        {
            // this.exludedRelationships = new List<Relationship>();
            this.Models = new List<ApplicationServiceData>();
            this.OutputFolder = "Controllers";
            this.WebApiName = "NewWebApi";
            this.CustomConnectionName = string.Empty;
            this.Namespace = "Controllers";
            this.InheritFrom = "BaseController";
            this.Id = Guid.NewGuid();
            this.OutputPath = string.Empty;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the custom connection name.
        /// </summary>
        public string CustomConnectionName { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the inherit from.
        /// </summary>
        public string InheritFrom { get; set; } = "BaseWebApi";

        /// <summary>
        ///     Gets the models.
        /// </summary>
        public List<ApplicationServiceData> Models { get; }

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; }

        /// <summary>
        ///     Gets or sets the output path.
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        ///     Gets the transform inherit from.
        /// </summary>
        [XmlIgnore]
        public string TransformInheritFrom
        {
            get
            {
                if (string.IsNullOrEmpty(this.InheritFrom))
                {
                    return string.Empty;
                }

                return $": {this.InheritFrom}";
            }
        }

        /// <summary>
        ///     Gets or sets the web api name.
        /// </summary>
        public string WebApiName { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The transform fullnamespace.
        /// </summary>
        /// <param name="baseNs">
        /// The base ns.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformFullnamespace(string baseNs)
        {
            return $"{baseNs}.{this.Namespace}";
        }

        #endregion
    }
}