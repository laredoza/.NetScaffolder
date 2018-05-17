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

    #region Usings

    #endregion

    #endregion

    /// <summary>
    /// The DataTypeUI interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IDataTypeUI<T>: IValidate
    {
        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        event EventHandler<IDataType<T>> OnNavigationChanged;

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        DomainDefinition DataSource { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        void LoadConfig(T parameters);

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        void SaveConfig(T parameters);

        #endregion
    }
}