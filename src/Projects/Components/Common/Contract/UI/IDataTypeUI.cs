// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataTypeUI.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    #region Usings

    using System;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    ///     The DataTypeUI interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IDataTypeUI : IValidate
    {
        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        event EventHandler<IDataType> OnNavigationChanged;

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        DomainDefinition DataSource { get; set; }

        /// <summary>
        /// Gets or sets the data type.
        /// </summary>
        IDataType DataType { get; set; }

        bool Loaded { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        void LoadConfig(object parameters);

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        void SaveConfig(object parameters);

        #endregion
    }
}