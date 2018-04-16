// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelForm.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System.Windows.Forms;
    using Common.Logging;
    using Configuration;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    #endregion

    /// <summary>
    /// The model form.
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
        /// Initializes a new instance of the <see cref="ModelForm"/> class.
        /// </summary>
        public ModelForm()
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
                this.dataSource = value;
                this.UpdateDataSource();
            }
        }

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath { get; set; }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                this.sourceType = ScaffoldConfig.ReturnSourceType(this.DataSource.SourceTypeId);

                // this.panel1.Controls.Clear();
                // this.sourceTypeControl = this.sourceType.AddConfigUI(this.panel1) as IDataSourceUI;
                // this.sourceTypeControl.SourceType = this.sourceType;
                // this.sourceTypeControl.LoadData(this.SavePath);
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