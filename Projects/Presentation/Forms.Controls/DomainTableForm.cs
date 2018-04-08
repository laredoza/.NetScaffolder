namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using Common.Logging;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using System.Windows.Forms;

    public partial class DomainTableForm : Form
    {
        private DomainDefinition dataSource;

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

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
                    this.domainMenuUserControl1.ParentConfigControl = this.PanelConfig;
                    this.domainMenuUserControl1.DataSource = dataSource;
                }
            }
        }

        //public Package MyProperty { get; set; }
        public DomainTableForm()
        {
            this.InitializeComponent();
            
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            UpdateTablesFromSourceForm tables = new UpdateTablesFromSourceForm();
            tables.ShowDialog();
        }

        private void PanelConfig_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
