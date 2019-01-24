#region

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.WebApiServiceDataTypes;
using DotNetScaffolder.Core.Common.Validation;
using DotNetScaffolder.Mapping.ApplicationServices.Forms.Tables;
using DotNetScaffolder.Mapping.ApplicationServices.Tables;
using DotNetScaffolder.Mapping.MetaData.Domain;
using FormControls.TreeView;

#endregion

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.WebApiServiceDataTypes
{
    #region Usings

    #endregion

    /// <summary>
    ///     The context user control.
    /// </summary>
    [Export(typeof(IDataTypeUI))]
    [ExportMetadata("NameMetaData", "WebApiUI")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4431")]
    [ExportMetadata("DisplayType", DisplayType.WinForm)]
    [ExportMetadata("DataType", "1BC1B0C4-1E41-9146-82CF-599181CE4431")]
    public partial class WebApiServiceUserControl : UserControl, IDataTypeUI
    {
        #region Fields

        /// <summary>
        ///     The application service data.
        /// </summary>
        private ApplicationServiceDataType applicationServiceData;

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
        ///     Initializes a new instance of the <see cref="WebApiServiceUserControl" /> class.
        /// </summary>
        public WebApiServiceUserControl()
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
        ///     Gets or sets a value indicating whether is default.
        /// </summary>
        public bool IsDefault { get; set; }

        public bool Loaded { get; set; }

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        ///     Gets or sets the selected web api.
        /// </summary>
        public WebApiServiceData SelectedWebApi { get; set; }

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
        public void AddNodes(string parentName, TreeView treeView, List<Hierarchy> hierarchy)
        {
            ITableHierarchyService applicationService = new TempateHierarchyService();
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

            Loaded = true;

            IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
            DataType?.Load(parameterDictionary);

            applicationServiceData = new ApplicationServiceDataType();
            applicationServiceData.DomainDefinition = DataSource;
            applicationServiceData.Load(parameterDictionary);

            (DataType as WebApiServiceDataType).ApplicationServiceDataType = applicationServiceData;

            if (parameterDictionary.ContainsKey("basePath"))
            {
                SavePath = parameterDictionary["basePath"];
            }

            if (parameterDictionary.ContainsKey("name"))
            {
                SelectedWebApi =
                    (DataType as WebApiServiceDataType).WebApiDataList.FirstOrDefault(
                        o => o.Id.ToString() == parameterDictionary["name"]);
            }

            TreeviewContextModels.Visible = SelectedWebApi != null;
            gbAdditionalNamespaces.Visible = SelectedWebApi == null;

            if (SelectedWebApi == null)
            {
                SetupDefault();
            }
            else
            {
                IsDefault = false;
            }

            if (IsDefault)
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

                var contextDataType = DataType as WebApiServiceDataType;
                bool removed = false;

                foreach (var error in contextDataType.MissingApplicationList)
                {
                    DialogResult result = MessageBox.Show(
                        $"Delete missing Application Service {error.ApplicationServiceName} from the WebApi {error.ApplicationServiceData.ApplicationServiceName}",
                        "Missing Table",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        var model = error.ApplicationServiceData.Models.FirstOrDefault(
                            m => m.TableName == error.ApplicationServiceName);
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
                if (!IsDefault && SelectedWebApi != null)
                {
                    UpdateDataType();

                    SelectedWebApi =
                        (DataType as WebApiServiceDataType).WebApiDataList.FirstOrDefault(
                            o => o.Id == SelectedWebApi.Id);

                    UpdateWebApi();
                }
                else
                {
                    UpdateDataType();
                }

                IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
                DataType.Save(parameterDictionary);
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
                UpdateWebApi();
                (DataType as WebApiServiceDataType).WebApiDataList.Add(SelectedWebApi);
            }
            else if (btn.Tag.ToString() == "Delete")
            {
                var webApiServiceData =
                    (DataType as WebApiServiceDataType).WebApiDataList.FirstOrDefault(
                        o => o.Id == SelectedWebApi.Id);

                if (webApiServiceData != null)
                {
                    (DataType as WebApiServiceDataType).WebApiDataList.Remove(webApiServiceData);
                }

                SelectedWebApi = null;
            }

            var parameters = new Dictionary<string, string> {{"basePath", SavePath}};
            DataType.Save(parameters);
            OnNavigationChanged?.Invoke(this, DataType);
            SetupDefault();
            UpdateUI();
        }

        ///// <summary>
        ///// The chk is default_ checked changed.
        ///// </summary>
        ///// <param name="sender">
        ///// The sender.
        ///// </param>
        ///// <param name="e">
        ///// The e.
        ///// </param>
        //private void chkIsDefault_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (this.SelectedWebApi == null)
        //    {
        //        return;
        //    }

        //    var dt = this.DataType as ApplicationServiceDataType;

        //    if (dt?.ApplicationServiceData == null)
        //    {
        //    }
        //}

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
            IsDefault = true;
            SelectedWebApi = new WebApiServiceData {Id = Guid.NewGuid()};
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
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            if (DataSource != null)
            {
                DataType.DomainDefinition = DataSource;

                List<Hierarchy> hierarchy = new List<Hierarchy>();

                if (SelectedWebApi != null)
                {
                    foreach (var applicationData in applicationServiceData.ApplicationServiceData)
                    {
                        hierarchy.Add(
                            new Hierarchy
                            {
                                Enabled = true,
                                Name = applicationData.ApplicationServiceName,
                                Id = applicationData.Id,
                                Item = applicationData,
                                Selected = SelectedWebApi.Models.Exists(m => m.Id == applicationData.Id)
                            });
                    }
                }

                AddNodes("Application Services", TreeviewContextModels, hierarchy);
            }
        }

        /// <summary>
        ///     The update data type.
        /// </summary>
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
        ///     The update ui.
        /// </summary>
        private void UpdateUI()
        {
            if (SelectedWebApi == null) return;

            OutputFolder.Text = SelectedWebApi.OutputFolder;
            Namespace.Text = SelectedWebApi.Namespace;
            WebApiName.Text = SelectedWebApi.WebApiName;
            InheritFromInterface.Text = SelectedWebApi.InheritFrom;

            // txtCustomConnectionName.Text = SelectedWebApi.CustomConnectionName;
            OutputPath.Text = SelectedWebApi.OutputPath;

            // chkIsDefault.Checked = SelectedWebApi.IsDefault;
            txtNamespaces.Lines = DataType.AdditionalNamespaces.ToArray();
            UpdateDataSource();
        }

        /// <summary>
        ///     The update context.
        /// </summary>
        private void UpdateWebApi()
        {
            if (SelectedWebApi == null) return;

            SelectedWebApi.OutputFolder = OutputFolder.Text;
            SelectedWebApi.Namespace = Namespace.Text;
            SelectedWebApi.WebApiName = WebApiName.Text;
            SelectedWebApi.InheritFrom = InheritFromInterface.Text;

            // SelectedWebApi.CustomConnectionName = txtCustomConnectionName.Text;
            SelectedWebApi.OutputPath = OutputPath.Text;

            // SelectedWebApi.IsDefault =
            // chkIsDefault.Checked || !(DataType as ApplicationServiceDataType).ApplicationServiceData.Any(o => o.IsDefault);
            SelectedWebApi.Models.Clear();

            if (TreeviewContextModels.Nodes.Count > 0)
            {
                foreach (TreeNode node in TreeviewContextModels.Nodes[0].Nodes)
                {
                    if (node.Checked)
                    {
                        SelectedWebApi.Models.Add(node.Tag as ApplicationServiceData);
                    }
                }
            }
        }

        #endregion
    }
}