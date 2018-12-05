#region Usings

using System;
using System.Collections.Generic;
using DotNetScaffolder.Core.Common.Validation;
using DotNetScaffolder.Mapping.MetaData.Model;

#endregion

namespace DotNetScaffolder.Components.Common.Contract
{
    #region Usings

    #region Usings

    #endregion

    #endregion

    /// <summary>
    ///     The DriverType interface.
    /// </summary>
    public interface IDriverType : IValidate
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets a value indicating whether create db.
        /// </summary>
        bool CreateDb { get; set; }

        /// <summary>
        ///     Gets the id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        ///     Gets or sets a value indicating whether include column order.
        /// </summary>
        bool IncludeColumnOrder { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether lazy loading enabled.
        /// </summary>
        bool LazyLoadingEnabled { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether logging enabled.
        /// </summary>
        bool LoggingEnabled { get; set; }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     Gets or sets a value indicating whether proxy creation enabled.
        /// </summary>
        bool ProxyCreationEnabled { get; set; }

        bool UseAlias { get; set; }

        bool UseSeperateConfigClasses { get; set; }

        bool EnableCache { get; set; }

        Guid Cache { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The load config.
        /// </summary>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        void LoadConfig(object parameters);

        /// <summary>
        ///     The save config.
        /// </summary>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        bool SaveConfig(object parameters);

        string TransformColumnPrecision(Column col, IDriver driver = null);

        string TransformDbGeneratedKey(Table table);

        string TransformRelationship(
            string table,
            Relationship rel,
            IEnumerable<Table> models,
            IEnumerable<Relationship> relationships = null,
            INamingConvention nc = null);

        #endregion
    }
}