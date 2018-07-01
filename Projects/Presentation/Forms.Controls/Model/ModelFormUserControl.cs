#region Usings

using System.Collections.Generic;
using System.Windows.Forms;
using Common.Logging;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Core.Common.Validation;
using DotNetScaffolder.Core.Configuration;
using DotNetScaffolder.Mapping.ApplicationServices.Forms.Tables;
using DotNetScaffolder.Mapping.ApplicationServices.Tables;
using DotNetScaffolder.Mapping.MetaData.Domain;
using DotNetScaffolder.Mapping.MetaData.Model;
using DotNetScaffolder.Presentation.Forms.Controls.Project.DataType;
using FormControls.TreeView;

#endregion

namespace DotNetScaffolder.Presentation.Forms.Controls.Model
{
    #region Usings

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
        ///     The index user control.
        /// </summary>
        private readonly IndexUserControl indexUserControl;

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

        private bool loading;

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
            InitializeComponent();
            modelControl = new ModelUserControl {Dock = DockStyle.Fill};
            PanelConfig.Controls.Add(modelControl);

            defaultModelControl = new DefaultModelUserControl {Dock = DockStyle.Fill};
            PanelConfig.Controls.Add(defaultModelControl);

            fieldControl = new ModelFieldUserControl {Dock = DockStyle.Fill};
            PanelConfig.Controls.Add(fieldControl);

            relationshipControl = new ModelRelationshipUserControl {Dock = DockStyle.Fill};
            PanelConfig.Controls.Add(relationshipControl);


            indexUserControl = new IndexUserControl {Dock = DockStyle.Fill};
            PanelConfig.Controls.Add(indexUserControl);

            defaultModelControl.BringToFront();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the currently selected control.
        /// </summary>
        public IValidate CurrentlySelectedControl { get; set; }

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

        #region Public Methods And Operators

        /// <summary>
        ///     The add nodes.
        /// </summary>
        /// <param name="parentName">
        ///     The parent name.
        /// </param>
        /// <param name="treeView">
        ///     The tree view.
        /// </param>
        /// <param name="hierarchy">
        ///     The hierarchy.
        /// </param>
        /// <param name="applicationService">
        ///     The application service.
        /// </param>
        public void AddNodes(
            string parentName,
            TreeView treeView,
            List<Hierarchy> hierarchy,
            ITableHierarchyService applicationService)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(new TreeNode {Text = parentName});
            treeView.Nodes[0].Nodes.AddRange(applicationService.ConvertHierarchyToNodes(hierarchy).ToArray());
            treeView.Nodes[0].Expand();

            treeView.SelectedNode = treeView.Nodes[0];
            // DomainTreeView_NodeMouseClick(this, new TreeNodeMouseClickEventArgs() );
        }

        #endregion

        #region Other Methods

        private void DomainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (CurrentlySelectedControl == null
                || (CurrentlySelectedControl != null && CurrentlySelectedControl.Validate().Count == 0))
            {
                if (e.Node.Tag is Table)
                {
                    var table = e.Node.Tag as Table;
                    modelControl.DataSource = table;
                    CurrentlySelectedControl = modelControl;
                    modelControl.BringToFront();
                }
                else if (e.Node.Tag is Column)
                {
                    var column = e.Node.Tag as Column;
                    fieldControl.DataSource = column;
                    CurrentlySelectedControl = fieldControl;
                    fieldControl.BringToFront();
                }
                else if (e.Node.Tag is Relationship)
                {
                    var relationship = e.Node.Tag as Relationship;
                    relationshipControl.Domain = DataSource;
                    relationshipControl.DataSource = relationship;
                    CurrentlySelectedControl = relationshipControl;
                    relationshipControl.BringToFront();
                }
                else if (e.Node.Tag is Index)
                {
                    var index = e.Node.Tag as Index;
                    indexUserControl.DataSource = index;
                    CurrentlySelectedControl = indexUserControl;
                    indexUserControl.BringToFront();
                }
                else if (e.Node.Tag == null)
                {
                    defaultModelControl.BringToFront();
                }
            }
        }

        /// <summary>
        ///     The domain tree view_ before select.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void DomainTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (CurrentlySelectedControl != null && CurrentlySelectedControl.Validate().Count > 0)
            {
                e.Cancel = true;
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

                sourceType = ScaffoldConfig.ReturnSourceType(DataSource.SourceTypeId);

                ITableHierarchyService applicationService = new TempateHierarchyService();
                List<Hierarchy> hierarchy =
                    applicationService.ReturnHierarchyFromList(DataSource.Tables, true, true, true);

                AddNodes("Models", DomainTreeView, hierarchy, applicationService);

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