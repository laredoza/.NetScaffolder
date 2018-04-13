// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainTableForm.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    /// The domain table form.
    /// </summary>
    public partial class DomainTableForm : Form
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        /// The data source.
        /// </summary>
        private DomainDefinition dataSource;

        #endregion

        #region Constructors and Destructors

        // public Package MyProperty { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainTableForm"/> class.
        /// </summary>
        public DomainTableForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource
        {
            get
            {
                return dataSource;
            }

            set
            {
                if (dataSource != value)
                {
                    dataSource = value;
                    domainMenuUserControl1.ParentConfigControl = PanelConfig;
                    domainMenuUserControl1.DataSource = dataSource;
                }
            }
        }

        /// <summary>
        /// Sets the output folder.
        /// </summary>
        public string OutputFolder
        {
            set => domainMenuUserControl1.OutputPath = value;
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
            domainMenuUserControl1.Save();
            Close();
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
            Close();
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
            UpdateTablesFromSourceForm tables = new UpdateTablesFromSourceForm();
            tables.ShowDialog();
        }

        /// <summary>
        /// The label 1_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The panel config_ paint.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void PanelConfig_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion
    }
}