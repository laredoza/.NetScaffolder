// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataTypeUI.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract
{
    using DotNetScaffolder.Mapping.MetaData.Domain;
    #region Usings

    using System;

    #endregion

    /// <summary>
    /// The DataTypeUI interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IDataTypeUI<T>
    {
        #region Public Events

        /// <summary>
        /// The on navigation changed.
        /// </summary>
        event EventHandler<IDataType<T>> OnNavigationChanged;

        #endregion

        #region Public methods and operators

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

        DomainDefinition DataSource { get; set; }

        #endregion
    }
}