// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelFormUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System.Collections.Generic;
    using System.Windows.Forms;

    using Common.Logging;

    using Configuration;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.ApplicationServices.Differences;
    using DotNetScaffolder.Mapping.ApplicationServices.Tables;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    /// The model form user control.
    /// </summary>
    public partial class ModelFormUserControl : UserControl
    {
        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        /// <summary>
        ///     The data source.
        /// </summary>
        private DomainDefinition dataSource;

        /// <summary>
        ///     The source type.
        /// </summary>
        private ISourceType sourceType;

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

        /// <summary>
        /// The add nodes.
        /// </summary>
        /// <param name="parentName">
        /// The parent name.
        /// </param>
        /// <param name="treeView">
        /// The tree view.
        /// </param>
        /// <param name="hierarchy">
        /// The hierarchy.
        /// </param>
        /// <param name="applicationService">
        /// The application service.
        /// </param>
        public void AddNodes(
            string parentName,
            TreeView treeView,
            List<Hierarchy> hierarchy,
            ITableHierarchyService applicationService)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(new TreeNode { Text = parentName });
            treeView.Nodes[0].Nodes.AddRange(applicationService.ConvertHierarchyToNodes(hierarchy).ToArray());
        }
        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                this.sourceType = ScaffoldConfig.ReturnSourceType(this.DataSource.SourceTypeId);
                var sourceDomain = this.sourceType.Import(this.sourceType.Load(this.SavePath));

                ITableHierarchyService applicationService = new TempateHierarchyService();
                List<Hierarchy> hierarchy = applicationService.ReturnHierarchyFromList(
                    this.DataSource.Tables,
                    true,
                    false);
                this.AddNodes("Models", this.DomainTreeView, hierarchy, applicationService);
            }
            else
            {
                Logger.Trace("Data Source not updated as domain is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFormUserControl"/> class.
        /// </summary>
        public ModelFormUserControl()
        {
            this.InitializeComponent();
        }

        #endregion
    }
}