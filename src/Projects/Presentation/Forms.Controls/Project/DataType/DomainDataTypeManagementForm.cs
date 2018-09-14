// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainModelForm.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// <summary>
//   The domain table form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using Common.Logging;
using DotNetScaffolder.Mapping.MetaData.Domain;
using DotNetScaffolder.Presentation.Forms.Controls.Sources;

namespace DotNetScaffolder.Presentation.Forms.Controls.Project.DataType
{
    #region Usings

    #endregion

    /// <summary>
    ///     The domain table form.
    /// </summary>
    public partial class DomainModelForm : Form
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        ///     The data source.
        /// </summary>
        private DomainDefinition dataSource;

        #endregion

        #region Constructors and Destructors

        // public Package MyProperty { get; set; }
        /// <summary>
        ///     Initializes a new instance of the <see cref="DomainModelForm" /> class.
        /// </summary>
        public DomainModelForm()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource
        {
            get
            {
                return this.dataSource;
            }

            set
            {
                if (this.dataSource != value)
                {
                    this.dataSource = value;
                    this.domainMenuUserControl1.ParentConfigControl = this.PanelConfig;
                    this.domainMenuUserControl1.DataSource = this.dataSource;
                }
            }
        }

        /// <summary>
        ///     Sets the output folder.
        /// </summary>
        public string OutputFolder
        {
            set => this.domainMenuUserControl1.OutputPath = value;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The btn save_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.domainMenuUserControl1.Save();
        }

        /// <summary>
        /// The button 1_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The button 2_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void button2_Click(object sender, EventArgs e)
        {
            UpdateModelsFromSourceForm tables = new UpdateModelsFromSourceForm();
            tables.ShowDialog();
        }

        #endregion
    }
}