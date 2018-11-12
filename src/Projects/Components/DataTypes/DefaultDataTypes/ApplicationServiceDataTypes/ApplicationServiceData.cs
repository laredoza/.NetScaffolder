// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationServiceData.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The ApplicationServiceData.
    /// </summary>
    public class ApplicationServiceData
    {
        #region Fields

        /// <summary>
        ///     The exluded relationships.
        /// </summary>
        private readonly List<Relationship> exludedRelationships;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApplicationServiceData" /> class.
        /// </summary>
        public ApplicationServiceData()
        {
            this.exludedRelationships = new List<Relationship>();
            this.Models = new List<Table>();
            this.OutputFolder = "ApplicationService";
            this.OutputFolderInterface = "ApplicationService";
            this.ApplicationServiceName = "New";
            this.Namespace = "ApplicationService";
            this.NamespaceInterface = "ApplicationService";
            this.InheritFrom = string.Empty;
            this.InheritFromInterface = string.Empty;
            this.Id = Guid.NewGuid();
            this.OutputPath = @"..\..\ApplicationService\RepositoryEFDotnet.Data.ApplicationServices.ApplicationService.csproj";
            this.OutputPathInterface = @"..\..\Interfaces\ApplicationService\RepositoryEFDotnet.Data.Interface.ApplicationService.csproj";
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the application service name.
        /// </summary>
        public string ApplicationServiceName { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the inherit from.
        /// </summary>
        public string InheritFrom { get; set; }

        public string InheritFromInterface { get; set; }

        /// <summary>
        ///     Gets the models.
        /// </summary>
        public List<Table> Models { get; }

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; }

        public string NamespaceInterface { get; set; }

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; }

        public string OutputFolderInterface { get; set; }

        /// <summary>
        ///     Gets or sets the output path.
        /// </summary>
        public string OutputPath { get; set; }

        public string OutputPathInterface { get; set; }

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
        
        [XmlIgnore]
        public string TransformInheritFromInterface
        {
            get
            {
                if (string.IsNullOrEmpty(this.InheritFromInterface))
                {
                    return string.Empty;
                }

                return $": {this.InheritFromInterface}";
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The has model.
        /// </summary>
        /// <param name="rel">
        /// The rel.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool HasModel(Relationship rel)
        {
            if (this.Models == null || !this.Models.Any())
            {
                return false;
            }

            return this.Models.Any(o => o.SchemaName == rel.SchemaName && o.TableName == rel.ReferencedTableName);
        }

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

        public string TransformFullnamespaceInterface(string baseNs)
        {
            return $"{baseNs}.{this.NamespaceInterface}";
        }

        #endregion
    }
}