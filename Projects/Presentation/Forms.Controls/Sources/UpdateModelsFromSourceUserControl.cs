// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateModelsFromSourceUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Sources
{
    #region Usings

    using System.Collections.Generic;
    using System.Threading;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Mapping.ApplicationServices.Differences;
    using DotNetScaffolder.Mapping.ApplicationServices.Tables;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;
    using SplashScreenThreaded;

    #endregion

    /// <summary>
    ///     The update models from source user control.
    /// </summary>
    public partial class UpdateModelsFromSourceUserControl : UserControl
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
        ///     The differences.
        /// </summary>
        private ApplicationTableCollectionDifference differences;

        /// <summary>
        ///     The source type.
        /// </summary>
        private ISourceType sourceType;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="UpdateModelsFromSourceUserControl" /> class.
        /// </summary>
        public UpdateModelsFromSourceUserControl()
        {
            this.InitializeComponent();
            this.TreeViewAdd.AfterCheck += this.TreeViewAdd_AfterCheck;
            this.TreeViewDelete.AfterCheck += this.TreeViewAdd_AfterCheck;
            this.TreeViewRefresh.AfterCheck += this.TreeViewAdd_AfterCheck;
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

        /// <summary>
        ///     Gets or sets a value indicating whether valid.
        /// </summary>
        public bool Valid { get; set; }

        #endregion

        #region Public Methods And Operators

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
            treeView.Nodes[0].Expand();
        }

        /// <summary>
        ///     The save.
        /// </summary>
        public void Save()
        {
            ITableHierarchyService applicationService = new TempateHierarchyService();

            List<Table> addTables = applicationService.ReturnTables(this.TreeViewAdd.Nodes[0]);
            List<Table> removeTables = applicationService.ReturnTables(this.TreeViewDelete.Nodes[0]);
            List<Table> newTables = applicationService.DoTableCollectionDiff(
                this.DataSource.Tables,
                addTables,
                removeTables,
                this.differences);

            // Todo: Test
            applicationService.PreserveCustomMetadata(newTables, this.DataSource.Tables, this.sourceType);
            this.DataSource.Tables = newTables;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The clicked.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <param name="newCheckedValue">
        /// The new checked value.
        /// </param>
        private void clicked(TreeNode node, bool newCheckedValue)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = newCheckedValue;
                this.clicked(child, newCheckedValue);
            }
        }

        /// <summary>
        /// The tree view add_ after check.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TreeViewAdd_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                this.clicked(e.Node, e.Node.Checked);
            }
        }

        private Thread StartSplashScreen()
        {
            (this.Parent as Form).Hide();
            Thread splashthread = new Thread(new ThreadStart(SplashScreen.ShowSplashScreen));
            splashthread.IsBackground = true;
            splashthread.Start();

            return splashthread;
        }

        private void CloseSplashScreen(bool show = true)
        {
            if (show)
            {
                this.Show();
            }

            SplashScreen.CloseSplashScreen();
            (this.Parent as Form).Activate();
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

                var sourceOptions = this.sourceType.Load(this.SavePath);

                if (this.sourceType.Test(sourceOptions))
                {
                    Thread splashthread = this.StartSplashScreen();
                    Thread.Sleep(100);
                    SplashScreen.UdpateStatusText("Loading schema information");

                    var sourceDomain = this.sourceType.Import(sourceOptions);

                    IApplicationTableCollectionDifference differenceService =
                        new ApplicationTableCollectionDifference(new ApplicationTableDifference());
                    this.differences = differenceService.CompareTables(this.DataSource.Tables, sourceDomain.Tables);

                    ITableHierarchyService applicationService = new TempateHierarchyService();
                    List<Hierarchy> hierarchy = applicationService.ReturnHierarchyFromList(
                        this.differences.FirstExtraTables,
                        false,
                        false);
                    this.AddNodes("Models", this.TreeViewAdd, hierarchy, applicationService);

                    hierarchy = applicationService.ReturnHierarchyFromList(this.differences.RefreshTable, false, false);

                    this.AddNodes("Models", this.TreeViewRefresh, hierarchy, applicationService);

                    hierarchy = applicationService.ReturnHierarchyFromList(
                        this.differences.FirstMissingTables,
                        false,
                        false);

                    this.AddNodes("Models", this.TreeViewDelete, hierarchy, applicationService);
                    this.Valid = true;

                    Thread.Sleep(100);
                    this.CloseSplashScreen(false);
                }
                else
                {
                    MessageBox.Show(
                        "Invalid configuration. Please update source configuration.",
                        "Configuration Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.Valid = false;
                }
            }
            else
            {
                this.Valid = false;
                Logger.Trace("Data Source not updated as domain is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        #endregion
    }
}