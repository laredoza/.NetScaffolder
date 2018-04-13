// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdoUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources
{
    #region Usings

    using System;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract.UI;

    #endregion

    /// <summary>
    ///     The ado user control.
    /// </summary>
    public partial class AdoUserControl : UserControl, IDefaultDataSourceUI
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="AdoUserControl" /> class.
        /// </summary>
        public AdoUserControl()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the parameters.
        /// </summary>
        public object Parameters { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The save data.
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void SaveData()
        {
            throw new NotImplementedException();
        }

        #endregion

        /// <summary>
        ///     The load data.
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// </exception>
        void IDefaultDataSourceUI.LoadData()
        {
            throw new NotImplementedException();
        }

        #region Other Methods

        /// <summary>
        ///     The load data.
        /// </summary>
        /// <exception cref="NotImplementedException">
        /// </exception>
        void LoadData()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}