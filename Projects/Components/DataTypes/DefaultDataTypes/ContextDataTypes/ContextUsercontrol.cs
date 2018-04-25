// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes
{
    #region Usings

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.ApplicationServices.Tables;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using FormControls.TreeView;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    ///     The context user control.
    /// </summary>
    public partial class ContextUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        public string SavePath { get; set; }

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContextUserControl" /> class.
        /// </summary>
        public ContextUserControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Events

        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        public event EventHandler<IDataType<IDictionary<string, string>>> OnNavigationChanged;

        #endregion

        #region Properties

        private ContextDataType dataType;
        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public ContextDataType DataType
        {
            get
            {
                return dataType;
            }
            set
            {
                dataType = value;
                UpdateUI();
            }
        }

        /// <summary>
        ///     Gets or sets the selected context.
        /// </summary>
        public ContextData SelectedContext { get; set; }

        private DomainDefinition dataSource;
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

        private void UpdateDataSource()
        {
            if (this.DataSource != null)
            {
                ITableHierarchyService applicationService = new TempateHierarchyService();
                List<Hierarchy> hierarchy = applicationService.ReturnSelectedHierarchyFromList(
                    this.DataSource.Tables,
                    this.SelectedContext?.Models ?? null,
                    false,
                    false);

                this.AddNodes("Models", this.TreeviewContextModels, hierarchy, applicationService);
            }
        }

        public void AddNodes(string parentName, TreeView treeView, List<Hierarchy> hierarchy, ITableHierarchyService applicationService)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(new TreeNode { Text = parentName });
            treeView.Nodes[0].Nodes.AddRange(applicationService.ConvertHierarchyToNodes(hierarchy).ToArray());
            treeView.Nodes[0].Expand();
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void LoadConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null) return;

            DataType?.Load(parameters);

            if (parameters.ContainsKey("name"))
            {
                SelectedContext = DataType.Contexts.FirstOrDefault(o => o.Id.ToString() == parameters["name"]);
            }

            if (SelectedContext == null)
            {
                btnNew.Text = "Add";
                btnNew.Tag = "Add";
            }
            else
            {
                btnNew.Text = "Delete";
                btnNew.Tag = "Delete";
            }

            TreeviewContextModels.Visible = SelectedContext != null;

            if (SelectedContext == null)
            {
                SetupDefault();
            }

            UpdateUI();
        }

        

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null || SelectedContext == null) return;

            SelectedContext = DataType.Contexts.FirstOrDefault(o => o.Id == SelectedContext.Id);

            UpdateContext();

            DataType.Save(parameters);
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
                UpdateContext();
                DataType.Contexts.Add(SelectedContext);
            }
            else if (btn.Tag.ToString() == "Delete")
            {
                var context = DataType.Contexts.FirstOrDefault(o => o.Id == SelectedContext.Id);

                if (context != null)
                {
                    DataType.Contexts.Remove(context);
                }

                SelectedContext = null;
            }

            var parameters = new Dictionary<string, string>();
            parameters.Add("basePath", SavePath);
            DataType.Save(parameters);
            OnNavigationChanged?.Invoke(this, DataType);
            SetupDefault();
            UpdateUI();
        }

        /// <summary>
        ///     The setup default.
        /// </summary>
        private void SetupDefault()
        {
            SelectedContext = new ContextData
            {
                Id = Guid.NewGuid()
            };
        }

        /// <summary>
        ///     The update context.
        /// </summary>
        private void UpdateContext()
        {
            if (SelectedContext == null) return;

            SelectedContext.OutputFolder = OutputFolder.Text;
            SelectedContext.Enabled = ContextEnabled.Checked;
            SelectedContext.Namespace = Namespace.Text;
            SelectedContext.ContextName = ContextName.Text;
            SelectedContext.CreateDb = CreateDb.Checked;
            SelectedContext.GenerateInterface = GenerateInterface.Checked;
            SelectedContext.InheritFrom = InheritFromInterface.Text;
            SelectedContext.LoggingEnabled = LoggingEnabled.Checked;
            SelectedContext.ConstructionOptions = ConstructionOptions.SelectedText;
            SelectedContext.OutputPath = OutputPath.Text;

            SelectedContext.Models.Clear();

            if (TreeviewContextModels.Nodes.Count > 0)
            {
                ITableHierarchyService applicationService = new TempateHierarchyService();

                var tables = applicationService.ReturnTables(this.TreeviewContextModels.Nodes[0]);
                if (tables != null && tables.Any())
                {
                    // Only save table name and schema not details
                    tables.ForEach(o =>
                    {
                        if(o.RelationShips != null)
                        {
                            o.RelationShips.Clear();
                        }

                        if (o.Columns != null)
                        {
                            o.Columns.Clear();
                        }
                    });

                    SelectedContext.Models.AddRange(tables);
                }
            }
        }

        /// <summary>
        ///     The update ui.
        /// </summary>
        private void UpdateUI()
        {
            if (SelectedContext == null) return;

            OutputFolder.Text = SelectedContext.OutputFolder;
            ContextEnabled.Checked = SelectedContext.Enabled;
            Namespace.Text = SelectedContext.Namespace;
            ContextName.Text = SelectedContext.ContextName;
            CreateDb.Checked = SelectedContext.CreateDb;
            GenerateInterface.Checked = SelectedContext.GenerateInterface;
            InheritFromInterface.Text = SelectedContext.InheritFrom;
            LoggingEnabled.Checked = SelectedContext.LoggingEnabled;
            ConstructionOptions.SelectedText = SelectedContext.ConstructionOptions;
            OutputPath.Text = SelectedContext.OutputPath;

            UpdateDataSource();
        }

        #endregion

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                var result = dialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    OutputPath.Text = dialog.SelectedPath;
                }
            }
        }
    }
}