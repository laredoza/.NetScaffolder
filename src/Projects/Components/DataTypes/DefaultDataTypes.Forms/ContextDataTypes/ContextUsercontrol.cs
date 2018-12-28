#region Usings

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes;
using DotNetScaffolder.Core.Common.Validation;
using DotNetScaffolder.Mapping.ApplicationServices.Forms.Tables;
using DotNetScaffolder.Mapping.ApplicationServices.Tables;
using DotNetScaffolder.Mapping.MetaData.Domain;
using DotNetScaffolder.Mapping.MetaData.Model;
using FormControls.TreeView;

#endregion

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.ContextDataTypes
{
    #region Usings

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
            InitializeComponent();
            TreeviewContextModels.AfterCheck += TreeviewContextModels_AfterCheck;
        }

        #endregion

        /// <summary>
        ///     The on navigation changed.
        /// </summary>
        public event EventHandler<IDataType> OnNavigationChanged;

        #region Public Properties

        public bool IsDefault { get; set; }

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
        ///     Gets or sets the data type.
        /// </summary>
        public IDataType DataType
        {
            get { return dataType; }

            set
            {
                dataType = value;
                UpdateUI();
            }
        }

        public bool Loaded { get; set; }

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        ///     Gets or sets the selected context.
        /// </summary>
        public ContextData SelectedContext { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        public List<Validation> ValidationResult { get; set; }

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
        }

        /// <summary>
        ///     The load config.
        /// </summary>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        public void LoadConfig(object parameters)
        {
            if (DataType == null) return;

            this.Loaded = true;

            IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
            DataType?.Load(parameterDictionary);

            if (parameterDictionary.ContainsKey("basePath"))
            {
                SavePath = parameterDictionary["basePath"];
            }

            if (parameterDictionary.ContainsKey("name"))
            {
                SelectedContext =
                    (DataType as ContextDataType).Contexts.FirstOrDefault(
                        o => o.Id.ToString() == parameterDictionary["name"]);
            }

            TreeviewContextModels.Visible = SelectedContext != null;
            gbAdditionalNamespaces.Visible = SelectedContext == null;

            if (SelectedContext == null)
            {
                SetupDefault();
            }
            else
            {
                this.IsDefault = false;
            }

            if (this.IsDefault)
            {
                btnNew.Text = "Add";
                btnNew.Tag = "Add";
            }
            else
            {
                btnNew.Text = "Delete";
                btnNew.Tag = "Delete";
            }

            UpdateUI();

            if (DataType.Validate().Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                var contextDataType = DataType as ContextDataType;
                bool removed = false;

                foreach (var error in contextDataType.MissingTables)
                {
                    DialogResult result =
                        MessageBox.Show(
                            $"Delete missing table {error.TableName} from the context {error.ContextData.ContextName}",
                            "Missing Table", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        var model = error.ContextData.Models.FirstOrDefault(m => m.TableName == error.TableName);
                        error.ContextData.Models.Remove(model);
                        removed = true;
                    }
                }

                if (removed)
                {
                    SaveConfig(parameterDictionary);
                }

                foreach (Validation validation in DataType.ValidationResult)
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
        ///     The save config.
        /// </summary>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        public void SaveConfig(object parameters)
        {
            if (DataType != null)
            {
                if (!this.IsDefault && SelectedContext != null)
                {
                    this.UpdateDataType();

                    SelectedContext =
                        (DataType as ContextDataType).Contexts.FirstOrDefault(o => o.Id == SelectedContext.Id);

                    UpdateContext();
                }
                else
                {
                    this.UpdateDataType();
                }

                IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
                DataType.Save(parameterDictionary);
            }
        }

        private void UpdateDataType()
        {
            DataType.AdditionalNamespaces.Clear();

            foreach (var ns in txtNamespaces.Lines)
            {
                var item = ns.Trim();
                if (!string.IsNullOrEmpty(item) && !DataType.AdditionalNamespaces.Contains(item))
                {
                    DataType.AdditionalNamespaces.Add(item);
                }
            }
        }

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public virtual List<Validation> Validate()
        {
            ValidationResult = DataType.Validate();
            return ValidationResult;
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The btn new_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            var btn = (Button) sender;

            if (btn.Tag.ToString() == "Add")
            {
                UpdateContext();
                (DataType as ContextDataType).Contexts.Add(SelectedContext);
            }
            else if (btn.Tag.ToString() == "Delete")
            {
                var context =
                    (DataType as ContextDataType).Contexts.FirstOrDefault(o => o.Id == SelectedContext.Id);

                if (context != null)
                {
                    (DataType as ContextDataType).Contexts.Remove(context);
                }

                SelectedContext = null;
            }

            var parameters = new Dictionary<string, string> {{"basePath", SavePath}};
            DataType.Save(parameters);
            OnNavigationChanged?.Invoke(this, DataType);
            SetupDefault();
            UpdateUI();
        }

        private void chkIsDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectedContext == null)
            {
                return;
            }

            var dt = DataType as ContextDataType;

            if (dt?.Contexts == null)
            {
                return;
            }

            if (chkIsDefault.Checked)
            {
                foreach (var ctx in dt.Contexts)
                {
                    ctx.IsDefault = false;
                }
            }

            SelectedContext.IsDefault = chkIsDefault.Checked;
        }

        /// <summary>
        ///     The clicked.
        /// </summary>
        /// <param name="node">
        ///     The node.
        /// </param>
        /// <param name="newCheckedValue">
        ///     The new checked value.
        /// </param>
        private void clicked(TreeNode node, bool newCheckedValue)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = newCheckedValue;
                clicked(child, newCheckedValue);
            }
        }

        /// <summary>
        ///     The setup default.
        /// </summary>
        private void SetupDefault()
        {
            this.IsDefault = true;
            SelectedContext = new ContextData {Id = Guid.NewGuid()};
        }

        /// <summary>
        ///     The treeview context models_ after check.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void TreeviewContextModels_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                clicked(e.Node, e.Node.Checked);
            }
        }

        /// <summary>
        ///     The update context.
        /// </summary>
        private void UpdateContext()
        {
            if (SelectedContext == null) return;

            SelectedContext.OutputFolder = OutputFolder.Text;
            SelectedContext.Namespace = Namespace.Text;
            SelectedContext.ContextName = ContextName.Text;
            SelectedContext.InheritFrom = InheritFromInterface.Text;
            SelectedContext.CustomConnectionName = txtCustomConnectionName.Text;
            SelectedContext.OutputPath = OutputPath.Text;
            SelectedContext.IsDefault =
                chkIsDefault.Checked || !(DataType as ContextDataType).Contexts.Any(o => o.IsDefault);

            SelectedContext.Models.Clear();

            if (TreeviewContextModels.Nodes.Count > 0)
            {
                ITableHierarchyService applicationService = new TempateHierarchyService();

                var tables = applicationService.ReturnTables(TreeviewContextModels.Nodes[0]);
                if (tables != null && tables.Any())
                {
                    foreach (var table in tables)
                    {
                        SelectedContext.Models.Add(new Table
                        {
                            TableName = table.TableName,
                            SchemaName = table.SchemaName,
                            EnabledForCodeGeneration = table.EnabledForCodeGeneration
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
            if (DataSource != null)
            {
                DataType.DomainDefinition = DataSource;
                ITableHierarchyService applicationService = new TempateHierarchyService();
                List<Hierarchy> hierarchy = applicationService.ReturnSelectedHierarchyFromList(
                    DataSource.Tables,
                    SelectedContext?.Models ?? null,
                    false,
                    false);

                AddNodes("Models", TreeviewContextModels, hierarchy, applicationService);
            }
        }

        /// <summary>
        ///     The update ui.
        /// </summary>
        private void UpdateUI()
        {
            if (SelectedContext == null) return;

            OutputFolder.Text = SelectedContext.OutputFolder;
            Namespace.Text = SelectedContext.Namespace;
            ContextName.Text = SelectedContext.ContextName;
            InheritFromInterface.Text = SelectedContext.InheritFrom;
            txtCustomConnectionName.Text = SelectedContext.CustomConnectionName;
            OutputPath.Text = SelectedContext.OutputPath;
            chkIsDefault.Checked = SelectedContext.IsDefault;
            txtNamespaces.Lines = DataType.AdditionalNamespaces.ToArray();
            UpdateDataSource();
        }

        #endregion
    }
}