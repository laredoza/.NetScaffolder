using Common.Logging;
using Configuration;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Mapping.MetaData.Domain;
using DotNetScaffolder.Mapping.MetaData.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    public partial class ManageDataSourceForm : Form
    {
        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        private DomainDefinition dataSource;

        private ISourceType sourceType;
        
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

        /// <summary>
        /// The update data source.
        /// </summary>
        public void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.DataSource != null)
            {
                this.sourceType = ScaffoldConfig.ReturnSourceType(this.DataSource.SourceTypeId);
                this.panel1.Controls.Clear();
                this.sourceType.AddConfigUI(this.panel1);
            }
            else
            {
                Logger.Trace("Data Source not updated as domain is null ");
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

        public ManageDataSourceForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
