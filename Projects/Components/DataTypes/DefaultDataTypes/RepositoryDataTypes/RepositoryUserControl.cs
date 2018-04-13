// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.RepositoryDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     The repository user control.
    /// </summary>
    public partial class RepositoryUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RepositoryUserControl" /> class.
        /// </summary>
        public RepositoryUserControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Events

        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        public event EventHandler<IDataType<IDictionary<string, string>>> OnNavigationChanged;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public RepositoryDataType DataType { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void LoadConfig(IDictionary<string, string> parameters)
        {
            DataType?.Load(parameters);
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(IDictionary<string, string> parameters)
        {
            DataType?.Save(parameters);
        }

        #endregion
    }
}