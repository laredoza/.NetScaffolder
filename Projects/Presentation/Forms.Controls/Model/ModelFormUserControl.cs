// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelFormUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    #region Usings

    using System.Collections.Generic;
    using System.Windows.Forms;

    using Common.Logging;

    using Configuration;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.ApplicationServices.Tables;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The model form user control.
    /// </summary>
    public partial class ModelFormUserControl : UserControl
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        ///     The default model control.
        /// </summary>
        private readonly DefaultModelUserControl defaultModelControl;

        /// <summary>
        ///     The field control.
        /// </summary>
        private readonly ModelFieldUserControl fieldControl;

        /// <summary>
        ///     The model control.
        /// </summary>
        private readonly ModelUserControl modelControl;

        /// <summary>
        ///     The relationship control.
        /// </summary>
        private readonly ModelRelationshipUserControl relationshipControl;



        /// <summary>
        ///     The data source.
        /// </summary>
        private DomainDefinition dataSource;

        /// <summary>
        ///     The source type.
        /// </summary>
        private ISourceType sourceType;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ModelFormUserControl" /> class.
        /// </summary>
        public ModelFormUserControl()
        {
            this.InitializeComponent();
            this.modelControl = new ModelUserControl();
            this.modelControl.Dock = DockStyle.Fill;
            this.PanelConfig.Controls.Add(this.modelControl);

            this.defaultModelControl = new DefaultModelUserControl();
            this.defaultModelControl.Dock = DockStyle.Fill;
            this.PanelConfig.Controls.Add(this.defaultModelControl);

            this.fieldControl = new ModelFieldUserControl();
            this.fieldControl.Dock = DockStyle.Fill;
            this.PanelConfig.Controls.Add(this.fieldControl);

            this.relationshipControl = new ModelRelationshipUserControl();
            this.relationshipControl.Dock = DockStyle.Fill;
            this.PanelConfig.Controls.Add(this.relationshipControl);

            this.defaultModelControl.BringToFront();
        }

        #endregion

        #region Public Properties
  
        public IValidate currentlySelectedControl { get; set; }
        
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

        #endregion

        #region Other Methods

        /// <summary>
        /// The domain tree view_ before select.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DomainTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (this.currentlySelectedControl != null && this.currentlySelectedControl.Validate().Count > 0)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// The domain tree view_ node mouse click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DomainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (this.currentlySelectedControl == null
                || (this.currentlySelectedControl != null && this.currentlySelectedControl.Validate().Count == 0))
            {
                if (e.Node.Tag is Table)
                {
                    var table = e.Node.Tag as Table;
                    this.modelControl.DataSource = table;
                    this.currentlySelectedControl = this.modelControl;
                    this.modelControl.BringToFront();
                }
                else if (e.Node.Tag is Column)
                {
                    var column = e.Node.Tag as Column;
                    this.fieldControl.DataSource = column;
                    this.currentlySelectedControl = this.fieldControl;
                    this.fieldControl.BringToFront();
                }
                else if (e.Node.Tag is Relationship)
                {
                    var relationship = e.Node.Tag as Relationship;
                    this.relationshipControl.Domain = this.DataSource;
                    this.relationshipControl.DataSource = relationship;
                    this.relationshipControl.BringToFront();
                }
                else if (e.Node.Tag == null)
                {
                    this.defaultModelControl.BringToFront();
                }
            }
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
                List<Hierarchy> hierarchy =
                    applicationService.ReturnHierarchyFromList(this.DataSource.Tables, true, true);

                this.AddNodes("Models", this.DomainTreeView, hierarchy, applicationService);
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