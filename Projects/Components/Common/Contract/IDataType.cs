// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    #region Usings

    using System.Collections.Generic;
    using System.Xml.Serialization;

    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    /// The DataType interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IDataType<T>
    {
        /// <summary>
        /// Gets or sets the base namespace.
        /// </summary>
        string BaseNamespace { get; set; }

        /// <summary>
        /// Gets or sets the collection option.
        /// </summary>
        ICollectionOption CollectionOption { get; set; }

        /// <summary>
        ///     Gets or sets the driver type.
        /// </summary>
        List<IDriver> DriverTypes { get; set; }

        /// <summary>
        ///     Gets or sets the meta data.
        /// </summary>
        Table MetaData { get; set; }

        /// <summary>
        /// Gets or sets the naming convention.
        /// </summary>
        INamingConvention NamingConvention { get; set; }

        /// <summary>
        /// The create ui.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="IDataTypeUI"/>.
        /// </returns>
        IDataTypeUI<T> CreateUI(T parameters);

        /// <summary>
        ///     The create ui.
        /// </summary>
        /// <returns>
        ///     The <see cref="IDataTypeUI" />.
        /// </returns>
        IDataTypeUI<T> CreateUI();

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
    }

    /// <summary>
    ///     The DataType interface.
    /// </summary>
    public interface IDataType : IDataType<IDictionary<string, string>>
    {
    }
}