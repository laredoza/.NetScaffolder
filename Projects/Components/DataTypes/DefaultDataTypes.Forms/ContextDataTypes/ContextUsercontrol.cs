// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextUsercontrol.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.ContextDataTypes
{
    #region Usings

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.ApplicationServices.Tables;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Model;
    using FormControls.TreeView;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes;

    #endregion

    /// <summary>
    ///     The context user control.
    /// </summary>
    [Export(typeof(IDataTypeUI))]
    [ExportMetadata("NameMetaData", "ContextUI")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4430")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DataType", "1BC1B0C4-1E41-9146-82CF-599181CE4430")]
    public partial class ContextUserControl : UserControl, IDataTypeUI
    {
        #region Fields

        /// <summary>
        ///     The data source.
        /// </summary>
        private DomainDefinition dataSource;

        /// <summary>
        ///     The data type.
        /// </summary>
        private IDataType dataType;

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
        public event EventHandler<IDataType> OnNavigationChanged;

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
        public IDataType DataType
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
        /// Gets or sets the save path.
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        /// Gets or sets the selected context.
        /// </summary>
        public ContextData SelectedContext { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        public List<Validation> ValidationResult { get; set; }

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
        public void LoadConfig(object parameters)
        {
            if (this.DataType == null) return;

            IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
            this.DataType?.Load(parameterDictionary);

            if (parameterDictionary.ContainsKey("name"))
            {
                this.SelectedContext =
                    (this.DataType as ContextDataType).Contexts.FirstOrDefault(
                        o => o.Id.ToString() == parameterDictionary["name"]);
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

                var contextDataType = this.DataType as ContextDataType;
                bool removed = false;

                foreach (var error in contextDataType.MissingTables)
                {
                    DialogResult result = MessageBox.Show($"Delete missing table {error.TableName} from the context {error.ContextData.ContextName}", "Missing Table", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        var model = error.ContextData.Models.FirstOrDefault(m => m.TableName == error.TableName);
                        error.ContextData.Models.Remove(model);
                        removed = true;
                    }
                }

                if (removed)
                {
                    this.SaveConfig(parameterDictionary);
                }

                foreach (Validation validation in this.DataType.ValidationResult)
                {
                    if (validation.ValidationType != ValidationType.ContextMissingModels)
                    {
                        sb.AppendLine(validation.Description);
                    }
                }

                if (sb.Length > 0)
                {
                    MessageBox.Show(sb.ToString(), "Invalid Context", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void SaveConfig(object parameters)
        {
            if (this.DataType == null || this.SelectedContext == null) return;

            this.SelectedContext =
                (this.DataType as ContextDataType).Contexts.FirstOrDefault(o => o.Id == this.SelectedContext.Id);

            this.UpdateContext();

            IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
            this.DataType.Save(parameterDictionary);
        }

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public virtual List<Validation> Validate()
        {
            this.ValidationResult = this.DataType.Validate();
            return this.ValidationResult;
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
                (this.DataType as ContextDataType).Contexts.Add(this.SelectedContext);
            }
            else if (btn.Tag.ToString() == "Delete")
            {
                var context =
                    (this.DataType as ContextDataType).Contexts.FirstOrDefault(o => o.Id == this.SelectedContext.Id);

                if (context != null)
                {
                    (this.DataType as ContextDataType).Contexts.Remove(context);
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
            this.SelectedContext.Namespace = this.Namespace.Text;
            this.SelectedContext.ContextName = this.ContextName.Text;
            this.SelectedContext.InheritFrom = this.InheritFromInterface.Text;
            this.SelectedContext.CustomConnectionName = this.txtCustomConnectionName.Text;
            this.SelectedContext.OutputPath = this.OutputPath.Text;

            this.SelectedContext.Models.Clear();

            if (this.TreeviewContextModels.Nodes.Count > 0)
            {
                ITableHierarchyService applicationService = new TempateHierarchyService();

                var tables = applicationService.ReturnTables(this.TreeviewContextModels.Nodes[0]);
                if (tables != null && tables.Any())
                {
                    foreach (var table in tables)
                    {
                        this.SelectedContext.Models.Add(new Table
                                                            {
                                                                TableName = table.TableName,
                                                                SchemaName = table.SchemaName
                                                            });
                    }
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
            this.Namespace.Text = this.SelectedContext.Namespace;
            this.ContextName.Text = this.SelectedContext.ContextName;
            this.InheritFromInterface.Text = this.SelectedContext.InheritFrom;
            this.txtCustomConnectionName.Text = this.SelectedContext.CustomConnectionName;
            this.OutputPath.Text = this.SelectedContext.OutputPath;

            this.UpdateDataSource();
        }

        #endregion
    }
}