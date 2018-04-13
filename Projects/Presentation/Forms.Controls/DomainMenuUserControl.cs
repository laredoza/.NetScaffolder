namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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

        private Control activeControl;

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource
        {
            get => dataSource;
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
                    var parameters = new Dictionary<string, string> { { "basePath", OutputPath } };

                    var template = hierarchy;
                    var dataType = ScaffoldConfig.ReturnDataType(template.DataType);
                    dataType.Load(parameters);
                    var navigation = dataType.ReturnNavigation();

                    var configControl = dataType.CreateUI();
                    var control = configControl as Control;

                    if (control == null) continue;

                    configControl.OnNavigationChanged += ConfigControlOnOnNavigationChanged;

                    control.Visible = false;
                    ParentConfigControl.Controls.Add(control);

                    var node = new TreeNode { Tag = configControl, Text = navigation.Name, Name = navigation.Id.ToString()};

                    if (navigation.Children.Any())
                    {
                        foreach (var child in navigation.Children)
                        {
                            node.Nodes.Add(new TreeNode
                                               {
                                                   Tag = configControl,
                                                   Text = child.Name,
                                                   Name = child.Id.ToString()
                                               });
                        }
                    }
                    else
                    {
                        node.Tag = configControl;
                    }

                    DomainTreeView.Nodes.Add(node);
                }
            }
            else
            {
                Logger.Trace("Data Source not updated as project is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        private void ConfigControlOnOnNavigationChanged(object sender, IDataType<IDictionary<string, string>> type)
        {
            var navigation = type.ReturnNavigation();
            var node = DomainTreeView.Nodes.Find(navigation.Id.ToString(), false).FirstOrDefault();

            if (node != null)
            {               
                foreach (var nav in navigation.Children)
                {
                    var childNode = DomainTreeView.Nodes.Find(nav.Id.ToString(), false).FirstOrDefault();

                    if (childNode != null)
                    {
                        childNode.Text = nav.Name;
                    }
                    else
                    {
                        childNode = new TreeNode
                                        {
                                            Tag = node.Tag,
                                            Text = nav.Name,
                                            Name = nav.Id.ToString()
                                        };
                        node.Nodes.Add(childNode);
                        node.Expand();
                    }
                }
            }
        }

        public void Save()
        {
            Logger.Trace("Started Save()");

            if (DataSource != null)
            {
                var parameters = new Dictionary<string, string> { { "basePath", OutputPath } };
                foreach (TreeNode node in DomainTreeView.Nodes)
                {
                    (node.Tag as IDataTypeUI<IDictionary<string, string>>)?.SaveConfig(parameters);
                }
                //TODO: Replace with something less annoying
                MessageBox.Show("Save complete", "Success");
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
            if (activeControl != null)
            {
                activeControl.Visible = false;
            }

            if (e.Node.Tag is IDataTypeUI<IDictionary<string, string>> configControl)
            {
                var parameters = new Dictionary<string, string> { { "basePath", OutputPath }, { "name", e.Node.Name } };

                configControl.LoadConfig(parameters);

                if (e.Node.Tag is Control control)
                {
                    activeControl = control;
                    activeControl.Visible = true;
                    activeControl.BringToFront();
                }
            }
        }
    }

    
}
