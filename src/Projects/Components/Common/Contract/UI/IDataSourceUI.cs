﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataSourceUI.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract.UI
{
    #region Usings

    using DotNetScaffolder.Core.Common.Validation;

    #endregion

    /// <summary>
    ///     The DataSourceUI interface.
    /// </summary>
    public interface IDataSourceUI : IValidate
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the parameters.
        /// </summary>
        object Parameters { get; set; }

        /// <summary>
        ///     Gets or sets the source type.
        /// </summary>
        ISourceType SourceType { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        bool LoadData(object parameters);

        /// <summary>
        /// The save data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        void SaveData(object parameters);

        bool TestData(object parameters, bool displayMessageOnSucceed);

        #endregion
    }
}