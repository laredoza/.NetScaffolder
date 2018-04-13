// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     The entity user control.
    /// </summary>
    public partial class EntityUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EntityUserControl" /> class.
        /// </summary>
        public EntityUserControl()
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
        public EntityDataType DataType { get; set; }

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
            DataType.Load(parameters);
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(IDictionary<string, string> parameters)
        {
            DataType.Save(parameters);
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The entity user control 1_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void EntityUserControl1_Load(object sender, EventArgs e)
        {
        }

        #endregion
    }
}