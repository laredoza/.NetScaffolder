#region Usings

using System.Collections.Generic;
using DotNetScaffolder.Mapping.MetaData.Model;

#endregion

namespace DotNetScaffolder.Components.Common.Contract
{
    #region Usings

    #endregion

    /// <summary>
    ///     The Driver interface.
    /// </summary>
    public interface IDriver
    {
        #region Public Properties

        string ConfigurationClass { get; }

        string ConfigurationOption { get; set; }

        /// <summary>
        ///     Gets the context attribute.
        /// </summary>
        string ContextAttribute { get; }

        /// <summary>
        ///     Gets the driver type.
        /// </summary>
        IDriverType DriverType { get; }

        /// <summary>
        ///     Gets a value indicating whether force schema to uppercase.
        /// </summary>
        bool ForceSchemaToUppercase { get; }

        /// <summary>
        ///     Gets the name spaces used to generate templates.
        /// </summary>
        List<string> NameSpaces { get; }

        /// <summary>
        ///     Gets the parent folder.
        /// </summary>
        string ParentFolder { get; }

        /// <summary>
        ///     Gets the prefix.
        /// </summary>
        string Prefix { get; }

        bool UseSchema { get; }

        #endregion

        #region Public Methods And Operators

        string AsAlias(string name);

        int CheckPrecision(Column col);

        /// <summary>
        ///     Generate bulk delete
        /// </summary>
        string GenerateBulkDelete { get; }

        /// <summary>
        ///     Generate bulk delete async
        /// </summary>
        string GenerateBulkDeleteAsync { get; }

        /// <summary>
        ///     Generate bulk insert async
        /// </summary>
        string GenerateBulkInsert { get; }

        /// <summary>
        ///     Generate bulk insert async
        /// </summary>
        string GenerateBulkInsertAsync { get; }

        /// <summary>
        ///     Generate bulk update async
        /// </summary>
        string GenerateBulkUpdate { get; }

        /// <summary>
        ///     Generate bulk delete async
        /// </summary>
        string GenerateBulkUpdateAsync { get; }

        string TransformIndex(Index index, INamingConvention nc = null);

        string InitContext { get; }

        #endregion
    }
}