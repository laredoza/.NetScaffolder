namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Common.Logging;

    using Configuration;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.TreeView;

    public partial class DomainMenuUserControl : UserControl
    {
        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        private DomainDefinition dataSource;

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource
        {
            get
            {
                return dataSource;
            }
            set
            {
                if (dataSource != value)
                {
                    dataSource = value;
                    UpdateDataSource();
                }
            }
        }

        public string OutputPath { get; set; }

        public Control ParentConfigControl { get; set; }

        public DomainMenuUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The update data source.
        /// </summary>
        public void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (DataSource != null)
            {
                foreach (var hierarchy in DataSource.Package.Templates)
                {
                    //var template = hierarchy;
                    //var dataTypeControl = ScaffoldConfig.ReturnDataType(template.DataType);
                    //var hierarchyToAdd = dataTypeControl.ReturnNavigation();

                    //var configControl = dataTypeControl.AddConfigUI(ParentConfigControl);
                    //var parameters = new Dictionary<string, string> { { "basePath", OutputPath } };
                    //configControl.LoadConfig(parameters);

                    //TreeNode node = new TreeNode { Tag = configControl, Text = hierarchyToAdd.Name };
                    //// Todo: Add children as well
                    //DomainTreeView.Nodes.Add(node);
                 }
            }
            else
            {
                Logger.Trace("Data Source not updated as project is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        public void Save()
        {
            Logger.Trace("Started Save()");

            if (DataSource != null)
            {
                var parameters = new Dictionary<string, string> { { "basePath", OutputPath } };
                foreach (var node in DomainTreeView.Nodes)
                {
                    //(node as IDataTypeUI<Dictionary<string, string>>)?.SaveConfig(parameters);
                }
            }
            else
            {
                Logger.Trace("Data Source is null ");
            }

            Logger.Trace("Completed Save()");
        }

        private void DomainTreeView_Click(object sender, EventArgs e)
        {
        }

        private void DomainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Control configControl)
            {
                configControl.BringToFront();
            }
        }
    }

    
}
