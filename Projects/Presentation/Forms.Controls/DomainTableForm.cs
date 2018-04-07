namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using System.Windows.Forms;

    public partial class DomainTableForm : Form
    {
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
    }
}
