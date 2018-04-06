namespace DotNetScaffolder.Presentation.Forms.Controls
{
    using System.Windows.Forms;

    public partial class DomainTableForm : Form
    {
        //public Package MyProperty { get; set; }
        public DomainTableForm()
        {
            this.InitializeComponent();

            //DomainTreeView
        }

        private void textBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label12_Click(object sender, System.EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, System.EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, System.EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, System.EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            UpdateTablesFromSourceForm tables = new UpdateTablesFromSourceForm();
            tables.ShowDialog();
        }
    }
}
