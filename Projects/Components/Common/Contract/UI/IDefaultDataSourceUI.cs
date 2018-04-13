// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDefaultDataSourceUI.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common.Contract.UI
{
    /// <summary>
    /// The DefaultDataSourceUI interface.
    /// </summary>
    public interface IDefaultDataSourceUI
    {
        #region Properties

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        object Parameters { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The load data.
        /// </summary>
        void LoadData();

        /// <summary>
        /// The save data.
        /// </summary>
        void SaveData();

        #endregion
    }
}