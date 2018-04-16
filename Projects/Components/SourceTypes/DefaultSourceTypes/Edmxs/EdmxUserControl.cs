// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EdmxUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;

    using global::Common.Logging;

    #endregion

    /// <summary>
    ///     The edmx user control.
    /// </summary>
    public partial class EdmxUserControl : UserControl, IDataSourceUI
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        ///     The options.
        /// </summary>
        private FileSourceOptions options;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EdmxUserControl" /> class.
        /// </summary>
        public EdmxUserControl()
        {
            Logger.Trace("Started EdmxUserControl()");
            this.InitializeComponent();
            this.options = new FileSourceOptions();
            Logger.Trace("Completed EdmxUserControl()");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the parameters.
        /// </summary>
        public object Parameters { get; set; }

        /// <summary>
        ///     Gets or sets the source type.
        /// </summary>
        public ISourceType SourceType { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <inheritdoc />
        /// <summary>
        ///     The load data.
        /// </summary>
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public void LoadData(object parameters)
        {
            Logger.Trace("Started LoadData()");

            this.options = this.SourceType.Load(parameters) as FileSourceOptions;

            if (this.options != null)
            {
                this.TxtFilePath.Text = this.options.Path;
            }
            else
            {
                this.TxtFilePath.Text = string.Empty;
            }

            Logger.Trace("Completed LoadData()");
        }

        /// <summary>
        /// The save data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void SaveData(object parameters)
        {
            Logger.Trace("Started SaveData()");

            List<object> saveParameters = new List<object> { parameters, this.options };
            this.SourceType.Save(saveParameters);

            Logger.Trace("Completed SaveData()");
        }

        /// <summary>
        /// The test data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void TestData(object parameters)
        {
            Logger.Trace("Started TestData()");

            if (this.SourceType.Test(this.options))
            {
                MessageBox.Show("Edmx Path Correct", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Edmx Path Is Incorrect", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Logger.Trace("Completed TestData()");
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The btn browse_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            Logger.Trace("Started Browse Clicked");

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.TxtFilePath.Text = this.openFileDialog1.FileName;
                this.options.Path = this.TxtFilePath.Text;
            }

            Logger.Trace("Completed Browse Clicked");
        }

        /// <summary>
        /// The txt file path_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtFilePath_TextChanged(object sender, EventArgs e)
        {
            Logger.Trace("Started TextFilePath Changed");
            this.options.Path = this.TxtFilePath.Text;
            Logger.Trace("Completed TextFilePath Changed");
        }

        #endregion
    }
}