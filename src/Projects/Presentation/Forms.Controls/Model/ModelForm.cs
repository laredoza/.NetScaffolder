#region Usings

using System;
using System.Windows.Forms;
using Common.Logging;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.Common.Contract.UI;
using DotNetScaffolder.Core.Configuration;
using DotNetScaffolder.Mapping.MetaData.Domain;

#endregion

namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    #region Usings

    #endregion

    /// <summary>
    ///     The model form.
    /// </summary>
    public partial class ModelForm : Form
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

        private bool loading;

        /// <summary>
        ///     The source type.
        /// </summary>
        private ISourceType sourceType;

        /// <summary>
        ///     The source type control.
        /// </summary>
        private IDataSourceUI sourceTypeControl;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ModelForm" /> class.
        /// </summary>
        public ModelForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource
        {
            get { return dataSource; }

            set
            {
                dataSource = value;
                UpdateDataSource();
            }
        }

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath { get; set; }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The btn close_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (ModelFormUserControl1.CurrentlySelectedControl == null
                || (ModelFormUserControl1.CurrentlySelectedControl != null
                    && ModelFormUserControl1.CurrentlySelectedControl.Validate().Count == 0))
            {
                Close();
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (DataSource != null)
            {
                this.loading = true;

                ModelFormUserControl1.SavePath = SavePath;
                sourceType = ScaffoldConfig.ReturnSourceType(DataSource.SourceTypeId);
                ModelFormUserControl1.DataSource = DataSource;

                this.loading = false;
            }
            else
            {
                Logger.Trace("Data Source not updated as domain is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion
    }
}