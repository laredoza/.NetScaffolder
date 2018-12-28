// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiServiceUsercontrol.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Forms.WebApiServiceDataTypes
{
    #region Usings

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

        public bool Loaded { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is default.
        /// </summary>
        public bool IsDefault { get; set; }

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
        public void AddNodes(string parentName, TreeView treeView, List<Hierarchy> hierarchy)
        {
            ITableHierarchyService applicationService = new TempateHierarchyService();
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

            this.Loaded = true;

            IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
            this.DataType?.Load(parameterDictionary);

            this.applicationServiceData = new ApplicationServiceDataType();
            this.applicationServiceData.DomainDefinition = this.DataSource;
            this.applicationServiceData.Load(parameterDictionary);

            (this.DataType as WebApiServiceDataType).ApplicationServiceDataType = this.applicationServiceData;

            if (parameterDictionary.ContainsKey("basePath"))
            {
                this.SavePath = parameterDictionary["basePath"];
            }

            if (parameterDictionary.ContainsKey("name"))
            {
                this.SelectedWebApi =
                    (this.DataType as WebApiServiceDataType).WebApiDataList.FirstOrDefault(
                        o => o.Id.ToString() == parameterDictionary["name"]);
            }

            this.TreeviewContextModels.Visible = this.SelectedWebApi != null;
            this.gbAdditionalNamespaces.Visible = this.SelectedWebApi == null;

            if (this.SelectedWebApi == null)
            {
                this.SetupDefault();
            }
            else
            {
                this.IsDefault = false;
            }

            if (this.IsDefault)
            {
                this.btnNew.Text = "Add";
                this.btnNew.Tag = "Add";
            }
            else
            {
                this.btnNew.Text = "Delete";
                this.btnNew.Tag = "Delete";
            }

            this.UpdateUI();

            if (this.DataType.Validate().Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                var contextDataType = this.DataType as WebApiServiceDataType;
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
            if (this.DataType != null)
            {
                if (!this.IsDefault && this.SelectedWebApi != null)
                {
                    this.UpdateDataType();

                    this.SelectedWebApi =
                        (this.DataType as WebApiServiceDataType).WebApiDataList.FirstOrDefault(
                            o => o.Id == this.SelectedWebApi.Id);

                    this.UpdateWebApi();
                }
                else
                {
                    this.UpdateDataType();
                }

                IDictionary<string, string> parameterDictionary = parameters as IDictionary<string, string>;
                this.DataType.Save(parameterDictionary);
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
                this.UpdateWebApi();
                (this.DataType as WebApiServiceDataType).WebApiDataList.Add(this.SelectedWebApi);
            }
            else if (btn.Tag.ToString() == "Delete")
            {
                var webApiServiceData =
                    (this.DataType as WebApiServiceDataType).WebApiDataList.FirstOrDefault(
                        o => o.Id == this.SelectedWebApi.Id);

                if (webApiServiceData != null)
                {
                    (this.DataType as WebApiServiceDataType).WebApiDataList.Remove(webApiServiceData);
                }

                this.SelectedWebApi = null;
            }

            var parameters = new Dictionary<string, string> { { "basePath", this.SavePath } };
            this.DataType.Save(parameters);
            this.OnNavigationChanged?.Invoke(this, this.DataType);
            this.SetupDefault();
            this.UpdateUI();
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
            this.IsDefault = true;
            this.SelectedWebApi = new WebApiServiceData { Id = Guid.NewGuid() };
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
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            if (this.DataSource != null)
            {
                this.DataType.DomainDefinition = this.DataSource;

                List<Hierarchy> hierarchy = new List<Hierarchy>();

                if (this.SelectedWebApi != null)
                {

                    foreach (var applicationData in this.applicationServiceData.ApplicationServiceData)
                    {
                        hierarchy.Add(
                            new Hierarchy
                                {
                                    Enabled = true,
                                    Name = applicationData.ApplicationServiceName,
                                    Id = applicationData.Id,
                                    Item = applicationData,
                                    Selected = this.SelectedWebApi.Models.Exists(m => m.Id == applicationData.Id)
                                });
                    }
                }

                this.AddNodes("Application Services", this.TreeviewContextModels, hierarchy);
            }
        }

        /// <summary>
        /// The update data type.
        /// </summary>
        private void UpdateDataType()
        {
            this.DataType.AdditionalNamespaces.Clear();

            foreach (var ns in this.txtNamespaces.Lines)
            {
                var item = ns.Trim();
                if (!string.IsNullOrEmpty(item) && !this.DataType.AdditionalNamespaces.Contains(item))
                {
                    this.DataType.AdditionalNamespaces.Add(item);
                }
            }
        }

        /// <summary>
        ///     The update ui.
        /// </summary>
        private void UpdateUI()
        {
            if (this.SelectedWebApi == null) return;

            this.OutputFolder.Text = this.SelectedWebApi.OutputFolder;
            this.Namespace.Text = this.SelectedWebApi.Namespace;
            this.WebApiName.Text = this.SelectedWebApi.WebApiName;
            this.InheritFromInterface.Text = this.SelectedWebApi.InheritFrom;

            // txtCustomConnectionName.Text = SelectedWebApi.CustomConnectionName;
            this.OutputPath.Text = this.SelectedWebApi.OutputPath;

            // chkIsDefault.Checked = SelectedWebApi.IsDefault;
            this.txtNamespaces.Lines = this.DataType.AdditionalNamespaces.ToArray();
            this.UpdateDataSource();
        }

        /// <summary>
        ///     The update context.
        /// </summary>
        private void UpdateWebApi()
        {
            if (this.SelectedWebApi == null) return;

            this.SelectedWebApi.OutputFolder = this.OutputFolder.Text;
            this.SelectedWebApi.Namespace = this.Namespace.Text;
            this.SelectedWebApi.WebApiName = this.WebApiName.Text;
            this.SelectedWebApi.InheritFrom = this.InheritFromInterface.Text;

            // SelectedWebApi.CustomConnectionName = txtCustomConnectionName.Text;
            this.SelectedWebApi.OutputPath = this.OutputPath.Text;

            // SelectedWebApi.IsDefault =
            // chkIsDefault.Checked || !(DataType as ApplicationServiceDataType).ApplicationServiceData.Any(o => o.IsDefault);
            this.SelectedWebApi.Models.Clear();

            if (this.TreeviewContextModels.Nodes.Count > 0)
            {
                foreach (TreeNode node in this.TreeviewContextModels.Nodes[0].Nodes)
                {
                    if (node.Checked)
                    {
                        this.SelectedWebApi.Models.Add(node.Tag as ApplicationServiceData);
                    }
                }
            }
        }

        #endregion
    }
}