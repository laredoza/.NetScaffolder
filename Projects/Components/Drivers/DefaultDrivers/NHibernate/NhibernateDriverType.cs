// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NhibernateDriverType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.NHibernate
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     The ef core driver type.
    /// </summary>
    [Export(typeof(IDriverType))]
    public class NhibernateDriverType : IDriverType
    {
        #region Fields

        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        protected readonly string FileName = string.Empty;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NhibernateDriverType"/> class.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        public NhibernateDriverType(string fileName)
        {
            this.FileName = fileName;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="NhibernateDriverType" /> class.
        /// </summary>
        public NhibernateDriverType()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets a value indicating whether create db.
        /// </summary>
        public bool CreateDb { get; set; }

        /// <summary>
        ///     The id.
        /// </summary>
        public Guid Id => new Guid("2BC1B0C4-1E41-9146-82CF-599181CE4412");

        /// <summary>
        ///     Gets or sets a value indicating whether include column order.
        /// </summary>
        public bool IncludeColumnOrder { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether lazy loading enabled.
        /// </summary>
        public bool LazyLoadingEnabled { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether logging enabled.
        /// </summary>
        public bool LoggingEnabled { get; set; }

        /// <summary>
        ///     The name.
        /// </summary>
        public string Name => "NHibernate";

        /// <summary>
        ///     Gets or sets a value indicating whether proxy creation enabled.
        /// </summary>
        public bool ProxyCreationEnabled { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void LoadConfig(object parameters)
        {
            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;

            var filePath = Path.Combine(parameterList["basePath"], this.FileName);

            if (File.Exists(filePath))
            {
                var loadedDriverType = ObjectXMLSerializer<NhibernateDriverType>.Load(filePath);
                if (loadedDriverType != null)
                {
                    this.CreateDb = loadedDriverType.CreateDb;
                    this.IncludeColumnOrder = loadedDriverType.IncludeColumnOrder;
                    this.LazyLoadingEnabled = loadedDriverType.LazyLoadingEnabled;
                    this.LoggingEnabled = loadedDriverType.LoggingEnabled;
                    this.ProxyCreationEnabled = loadedDriverType.ProxyCreationEnabled;
                }
            }
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool SaveConfig(object parameters)
        {
            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;
            var filePath = Path.Combine(parameterList["basePath"], this.FileName);
            ObjectXMLSerializer<NhibernateDriverType>.Save(this, filePath);
            return true;
        }

        /// <summary>
        /// The validate.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public List<Validation> Validate()
        {
            return this.ValidationResult;
        }

        public string TransformRelationship(string table,
                                            Relationship rel,
                                            IEnumerable<Table> models,
                                            IEnumerable<Relationship> relationships = null,
                                            INamingConvention nc = null)
        {
            return string.Empty;
        }

        public string TransformDbGeneratedKey(Table table)
        {
            throw new NotImplementedException();
        }

        public string TransformColumnPrecision(Column col)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}