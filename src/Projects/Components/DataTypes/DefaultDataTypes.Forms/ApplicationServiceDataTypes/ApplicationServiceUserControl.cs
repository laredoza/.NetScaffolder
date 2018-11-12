#region Usings

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;
using DotNetScaffolder.Core.Common.Validation;
using DotNetScaffolder.Mapping.ApplicationServices.Forms.Tables;
using DotNetScaffolder.Mapping.ApplicationServices.Tables;
using DotNetScaffolder.Mapping.MetaData.Domain;
using DotNetScaffolder.Mapping.MetaData.Model;
using FormControls.TreeView;

#endregion

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.ApplicationServiceDataTypes
{
    #region Usings

    #endregion

    /// <summary>
    ///     The application service user control.
    /// </summary>
    [Export(typeof(IDataTypeUI))]
    [ExportMetadata("NameMetaData", "ApplicationServiceUI")]
    [ExportMetadata("ValueMetaData", "1BC1B0C41BC1B0C4-1E41-9146-82CF-599181CE4420")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DataType", "1BC1B0C4-1E41-9146-82CF-599181CE4420")]
    public partial class ApplicationServiceUserControl : UserControl, IDataTypeUI
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
        ///     Initializes a new instance of the <see cref="ApplicationServiceUserControl" /> class.
        /// </summary>
        public ApplicationServiceUserControl()
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

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        ///     Gets or sets the selected application service.
        /// </summary>
        public ApplicationServiceData SelectedApplicationService { get; set; }

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

            IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
            DataType?.Load(parameterDictionary);

            if (parameterDictionary.ContainsKey("basePath"))
            {
                SavePath = parameterDictionary["basePath"];
            }

            if (parameterDictionary.ContainsKey("name"))
            {
                SelectedApplicationService =
                    (DataType as ApplicationServiceDataType).ApplicationServiceData.FirstOrDefault(
                        o => o.Id.ToString() == parameterDictionary["name"]);
            }

            if (SelectedApplicationService == null)
            {
                btnNew.Text = "Add";
                btnNew.Tag = "Add";
            }
            else
            {
                btnNew.Text = "Delete";
                btnNew.Tag = "Delete";
            }

            TreeviewContextModels.Visible = SelectedApplicationService != null;
            gbAdditionalNamespaces.Visible = SelectedApplicationService == null;
            gbAdditionalNamespacesInterfaces.Visible = SelectedApplicationService == null;

            if (SelectedApplicationService == null)
            {
                SetupDefault();
            }

            UpdateUI();

            if (DataType.Validate().Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                var applicationServiceDataType = DataType as ApplicationServiceDataType;
                bool removed = false;

                foreach (var error in applicationServiceDataType.MissingTables)
                {
                    DialogResult result =
                        MessageBox.Show(
                            $"Delete missing table {error.TableName} from the Application Service {error.ApplicationServiceData.ApplicationServiceName}",
                            "Missing Table", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        var model = error.ApplicationServiceData.Models.FirstOrDefault(m => m.TableName == error.TableName);
                        error.ApplicationServiceData.Models.Remove(model);
                        removed = true;
                    }
                }

                if (removed)
                {
                    SaveConfig(parameterDictionary);
                }

                foreach (Validation validation in DataType.ValidationResult)
                {
                    if (validation.ValidationType != ValidationType.ApplicationServiceMissingModels)
                    {
                        sb.AppendLine(validation.Description);
                    }
                }

                if (sb.Length > 0)
                {
                    MessageBox.Show(sb.ToString(), "Invalid Application Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (DataType == null || SelectedApplicationService == null) return;

            DataType.AdditionalNamespaces.Clear();
            

            foreach (var ns in txtNamespaces.Lines)
            {
                var item = ns.Trim();
                if (!string.IsNullOrEmpty(item) && !DataType.AdditionalNamespaces.Contains(item))
                {
                    DataType.AdditionalNamespaces.Add(item);
                }
            }

            var applicationServiceDataType = (DataType as ApplicationServiceDataType);
            applicationServiceDataType.AdditionalNamespacesInterfaces.Clear();

            foreach (var ns in txtNamespacesInterfaces.Lines)
            {
                var item = ns.Trim();
                if (!string.IsNullOrEmpty(item) && !applicationServiceDataType.AdditionalNamespacesInterfaces.Contains(item))
                {
                    applicationServiceDataType.AdditionalNamespacesInterfaces.Add(item);
                }
            }

            SelectedApplicationService =
                applicationServiceDataType.ApplicationServiceData.FirstOrDefault(o => o.Id == SelectedApplicationService.Id);

            UpdateApplicationService();

            IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
            DataType.Save(parameterDictionary);
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
                UpdateApplicationService();
                (DataType as ApplicationServiceDataType).ApplicationServiceData.Add(SelectedApplicationService);
            }
            else if (btn.Tag.ToString() == "Delete")
            {
                var applicationService =
                    (DataType as ApplicationServiceDataType).ApplicationServiceData.FirstOrDefault(o => o.Id == SelectedApplicationService.Id);

                if (applicationService != null)
                {
                    (DataType as ApplicationServiceDataType).ApplicationServiceData.Remove(applicationService);
                }

                SelectedApplicationService = null;
            }

            var parameters = new Dictionary<string, string> {{"basePath", SavePath}};
            DataType.Save(parameters);
            OnNavigationChanged?.Invoke(this, DataType);
            SetupDefault();
            UpdateUI();
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
            SelectedApplicationService = new ApplicationServiceData { Id = Guid.NewGuid()};
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
        ///     The update Application Service.
        /// </summary>
        private void UpdateApplicationService()
        {
            if (SelectedApplicationService == null) return;

            SelectedApplicationService.OutputFolder = OutputFolder.Text;
            SelectedApplicationService.Namespace = Namespace.Text;
            SelectedApplicationService.ApplicationServiceName = ApplicationServiceName.Text;
            SelectedApplicationService.InheritFrom = InheritFrom.Text;
            SelectedApplicationService.OutputPath = OutputPath.Text;
            SelectedApplicationService.Models.Clear();

            SelectedApplicationService.OutputFolderInterface = OutputFolderInterface.Text;
            SelectedApplicationService.NamespaceInterface = NamespaceInterface.Text;
            SelectedApplicationService.InheritFromInterface = InheritFromInterface.Text;
            SelectedApplicationService.OutputPathInterface = OutputPathInterface.Text;

            if (TreeviewContextModels.Nodes.Count > 0)
            {
                ITableHierarchyService applicationService = new TempateHierarchyService();

                var tables = applicationService.ReturnTables(TreeviewContextModels.Nodes[0]);
                if (tables != null && tables.Any())
                {
                    foreach (var table in tables)
                    {
                        SelectedApplicationService.Models.Add(new Table
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
                    SelectedApplicationService?.Models ?? null,
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
            if (SelectedApplicationService == null) return;

            OutputFolder.Text = SelectedApplicationService.OutputFolder;
            Namespace.Text = SelectedApplicationService.Namespace;
            ApplicationServiceName.Text = SelectedApplicationService.ApplicationServiceName;
            InheritFrom.Text = SelectedApplicationService.InheritFrom;
            OutputPath.Text = SelectedApplicationService.OutputPath;
            txtNamespaces.Lines = DataType.AdditionalNamespaces.ToArray();

            this.OutputFolderInterface.Text = this.SelectedApplicationService.OutputFolderInterface;
            NamespaceInterface.Text = SelectedApplicationService.NamespaceInterface;
            InheritFromInterface.Text = SelectedApplicationService.InheritFromInterface;
            OutputPathInterface.Text = SelectedApplicationService.OutputPathInterface;
            txtNamespacesInterfaces.Lines = (DataType as ApplicationServiceDataType).AdditionalNamespacesInterfaces.ToArray();

            UpdateDataSource();
        }

        #endregion
    }
}