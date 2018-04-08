using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Mapping.MetaData.Domain;
using Common.Logging;
using Configuration;
using DotNetScaffolder.Mapping.MetaData.Project.Packages;
using DotNetScaffolder.Components.Common.Contract;
using FormControls.TreeView;

namespace DotNetScaffolder.Presentation.Forms.Controls
{
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
                    this.UpdateDataSource();
                }
            }
        }

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

            if (this.DataSource != null)
            {
                Template template = null;
                IDataType dataTypeControl;
                IHierarchy hierarchyToAdd = null;
                Control configControl = null;

                foreach (var hierarchy in this.DataSource.Package.Templates)
                {
                    template = hierarchy as Template;
                    dataTypeControl = ScaffoldConfig.ReturnDataType(template.DataType);
                    hierarchyToAdd = dataTypeControl.ReturnNavigation();

                    configControl = dataTypeControl.AddConfigUI(this.ParentConfigControl) as Control;

                    TreeNode node = new TreeNode { Tag = configControl, Text = hierarchyToAdd.Name };
                    // Todo: Add children as well
                    this.DomainTreeView.Nodes.Add(node);
                 }
            }
            else
            {
                Logger.Trace("Data Source not updated as project is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        private void DomainTreeView_Click(object sender, EventArgs e)
        {
        }

        private void DomainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Control configControl = e.Node.Tag as Control;
            if (configControl != null)
            {
                configControl.BringToFront();
            }
        }
    }

    
}
