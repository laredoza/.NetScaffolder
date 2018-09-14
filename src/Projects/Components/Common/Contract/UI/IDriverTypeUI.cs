// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDriverTypeUI.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract.UI
{
    #region Usings

    using System;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    /// The DriverTypeUI interface.
    /// </summary>
    public interface IDriverTypeUI : IValidate
    {

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        DomainDefinition DataSource { get; set; }

        /// <summary>
        /// Gets or sets the driver type.
        /// </summary>
        IDriverType DriverType { get; set; }

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