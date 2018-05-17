// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.ApplicationServices.Tables;
    using DotNetScaffolder.Mapping.MetaData.Domain;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The context user control.
    /// </summary>
    public partial class ContextUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        #region Fields

        /// <summary>
        ///     The data source.
        /// </summary>
        private DomainDefinition dataSource;

        /// <summary>
        ///     The data type.
        /// </summary>
        private ContextDataType dataType;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContextUserControl" /> class.
        /// </summary>
        public ContextUserControl()
        {
            this.InitializeComponent();
            this.TreeviewContextModels.AfterCheck += this.TreeviewContextModels_AfterCheck;
        }

        #endregion

        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        public event EventHandler<IDataType<IDictionary<string, string>>> OnNavigationChanged;

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
        ///     Gets or sets the data type.
        /// </summary>
        public ContextDataType DataType
        {
            get
            {
                return this.dataType;
            }

            set
            {
                this.dataType = value;
                this.UpdateUI();
            }
        }

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        ///     Gets or sets the selected context.
        /// </summary>
        public ContextData SelectedContext { get; set; }

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
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void LoadConfig(IDictionary<string, string> parameters)
        {
            if (this.DataType == null) return;

            this.DataType?.Load(parameters);

            if (parameters.ContainsKey("name"))
            {
                this.SelectedContext =
                    this.DataType.Contexts.FirstOrDefault(o => o.Id.ToString() == parameters["name"]);
            }

            if (this.SelectedContext == null)
            {
                this.btnNew.Text = "Add";
                this.btnNew.Tag = "Add";
            }
            else
            {
                this.btnNew.Text = "Delete";
                this.btnNew.Tag = "Delete";
            }

            this.TreeviewContextModels.Visible = this.SelectedContext != null;

            if (this.SelectedContext == null)
            {
                this.SetupDefault();
            }

            this.UpdateUI();

            if (this.DataType.Validate().Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                foreach (Validation validation in this.DataType.ValidationResult)
                {
                    sb.AppendLine(validation.Description);
                }

                MessageBox.Show(sb.ToString(), "Invalid Context", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(IDictionary<string, string> parameters)
        {
            if (this.DataType == null || this.SelectedContext == null) return;

            this.SelectedContext = this.DataType.Contexts.FirstOrDefault(o => o.Id == this.SelectedContext.Id);

            this.UpdateContext();

            this.DataType.Save(parameters);
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The btn new_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (btn.Tag.ToString() == "Add")
            {
                this.UpdateContext();
                this.DataType.Contexts.Add(this.SelectedContext);
            }
            else if (btn.Tag.ToString() == "Delete")
            {
                var context = this.DataType.Contexts.FirstOrDefault(o => o.Id == this.SelectedContext.Id);

                if (context != null)
                {
                    this.DataType.Contexts.Remove(context);
                }

                this.SelectedContext = null;
            }

            var parameters = new Dictionary<string, string>();
            parameters.Add("basePath", this.SavePath);
            this.DataType.Save(parameters);
            this.OnNavigationChanged?.Invoke(this, this.DataType);
            this.SetupDefault();
            this.UpdateUI();
        }

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
        /// The context user control_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ContextUserControl_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     The setup default.
        /// </summary>
        private void SetupDefault()
        {
            this.SelectedContext = new ContextData { Id = Guid.NewGuid() };
        }

        /// <summary>
        /// The treeview context models_ after check.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TreeviewContextModels_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                this.clicked(e.Node, e.Node.Checked);
            }
        }

        /// <summary>
        ///     The update context.
        /// </summary>
        private void UpdateContext()
        {
            if (this.SelectedContext == null) return;

            this.SelectedContext.OutputFolder = this.OutputFolder.Text;
            this.SelectedContext.LazyLoadingEnabled = this.LazyLoading.Checked;
            this.SelectedContext.Namespace = this.Namespace.Text;
            this.SelectedContext.ContextName = this.ContextName.Text;
            this.SelectedContext.CreateDb = this.CreateDb.Checked;
            this.SelectedContext.ProxyCreationEnabled = this.ProxyCreation.Checked;
            this.SelectedContext.InheritFrom = this.InheritFromInterface.Text;
            this.SelectedContext.LoggingEnabled = this.LoggingEnabled.Checked;
            this.SelectedContext.CustomConnectionName = this.txtCustomConnectionName.Text;
            this.SelectedContext.OutputPath = this.OutputPath.Text;
            this.SelectedContext.IncludeColumnOrder = this.chkColumnOrder.Checked;

            this.SelectedContext.Models.Clear();

            if (this.TreeviewContextModels.Nodes.Count > 0)
            {
                ITableHierarchyService applicationService = new TempateHierarchyService();

                var tables = applicationService.ReturnTables(this.TreeviewContextModels.Nodes[0]);
                if (tables != null && tables.Any())
                {
                    this.SelectedContext.Models.AddRange(tables);
                }
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            if (this.DataSource != null)
            {
                this.DataType.DomainDefinition = this.DataSource;
                ITableHierarchyService applicationService = new TempateHierarchyService();
                List<Hierarchy> hierarchy = applicationService.ReturnSelectedHierarchyFromList(
                    this.DataSource.Tables,
                    this.SelectedContext?.Models ?? null,
                    false,
                    false);

                this.AddNodes("Models", this.TreeviewContextModels, hierarchy, applicationService);
            }
        }

        /// <summary>
        ///     The update ui.
        /// </summary>
        private void UpdateUI()
        {
            if (this.SelectedContext == null) return;

            this.OutputFolder.Text = this.SelectedContext.OutputFolder;
            this.LazyLoading.Checked = this.SelectedContext.LazyLoadingEnabled;
            this.Namespace.Text = this.SelectedContext.Namespace;
            this.ContextName.Text = this.SelectedContext.ContextName;
            this.CreateDb.Checked = this.SelectedContext.CreateDb;
            this.ProxyCreation.Checked = this.SelectedContext.ProxyCreationEnabled;
            this.InheritFromInterface.Text = this.SelectedContext.InheritFrom;
            this.LoggingEnabled.Checked = this.SelectedContext.LoggingEnabled;
            this.txtCustomConnectionName.Text = this.SelectedContext.CustomConnectionName;
            this.OutputPath.Text = this.SelectedContext.OutputPath;
            this.chkColumnOrder.Checked = this.SelectedContext.IncludeColumnOrder;

            this.UpdateDataSource();
        }

        #endregion
    }
}