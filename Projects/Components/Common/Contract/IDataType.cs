// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    #region Usings

    using System;
    using System.Collections.Generic;

    using DotNetScaffolder.Components.Common.MetaData;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    /// The DataType interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IDataType<T> : IValidate
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the base namespace.
        /// </summary>
        string BaseNamespace { get; set; }

        /// <summary>
        ///     Gets or sets the collection option.
        /// </summary>
        ICollectionOption CollectionOption { get; set; }

        /// <summary>
        ///     Gets or sets the domain definition.
        /// </summary>
        DomainDefinition DomainDefinition { get; set; }

        /// <summary>
        ///     Gets or sets the driver type.
        /// </summary>
        List<IDriver> Drivers { get; set; }

        /// <summary>
        ///     Gets or sets the meta data.
        /// </summary>
        Table MetaData { get; set; }

        /// <summary>
        ///     Gets or sets the naming convention.
        /// </summary>
        INamingConvention NamingConvention { get; set; }

        /// <summary>
        /// Gets or sets the language output details.
        /// </summary>
        List<LanguageOutputDetails> LanguageOutputDetails { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The create ui.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <summary>
        /// The create ui.
        /// </summary>
        /// <returns>
        /// The <see cref="IDataTypeUI"/>.
        /// </returns>
        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        void Load(T parameters);

        /// <summary>
        ///     The return navigation.
        /// </summary>
        /// <returns>
        ///     The <see cref="IHierarchy" />.
        /// </returns>
        Hierarchy ReturnNavigation();

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Save(T parameters);

        List<string> AdditionalNamespaces { get; }

        #endregion
    }

    /// <summary>
    ///     The DataType interface.
    /// </summary>
    public interface IDataType : IDataType<IDictionary<string, string>>
    {
    }
}