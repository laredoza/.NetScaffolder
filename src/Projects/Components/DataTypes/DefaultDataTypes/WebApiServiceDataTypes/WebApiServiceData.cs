﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextData.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.WebApiServiceDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The context data.
    /// </summary>
    public class WebApiServiceData
    {
        #region Fields

        /// <summary>
        ///     The exluded relationships.
        /// </summary>
        //private readonly List<Relationship> exludedRelationships;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="WebApiServiceData" /> class.
        /// </summary>
        public WebApiServiceData()
        {
            //this.exludedRelationships = new List<Relationship>();
            this.Models = new List<Table>();
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
        /// Gets or sets the web api name.
        /// </summary>
        public string WebApiName { get; set; }

        /// <summary>
        ///     Gets or sets the custom connection name.
        /// </summary>
        public string CustomConnectionName { get; set; }

        //public List<Relationship> ExcludedRelationships(List<Table> models)
        //{
        //    if (!this.exludedRelationships.Any())
        //    {
        //        foreach (var model in models)
        //        {
        //            foreach (var rel in model.Relationships.Where(o => o.Render))
        //            {
        //                if (!this.exludedRelationships.Any(
        //                        o => o.SchemaName == rel.SchemaName && o.ReferencedTableName == rel.ReferencedTableName)
        //                    && !this.Models.Any(
        //                        o => o.SchemaName == rel.SchemaName && o.TableName == rel.ReferencedTableName))
        //                {
        //                    this.exludedRelationships.Add(rel);
        //                }
        //            }
        //        }
        //    }

        //    return this.exludedRelationships;
        //}

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
        public List<Table> Models { get; }

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

        #endregion
    }
}