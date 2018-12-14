#region Usings

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace DotNetScaffolder.Presentation.Forms
{
    #region Usings

    #endregion

    /// <summary>
    ///     The form 1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Form1" /> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ProjectUserControl1.TemplateManagementUserControl = TemplateManagementUserControl1;
            ProjectUserControl1.PackageUserControl = packageUserControl1;
            ProjectUserControl1.LabelPath = LblPath;
            ProjectUserControl1.TabControl = tabControl1;
            ProjectUserControl1.BtnSave = BtnSave;
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The btn close_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

      

        /// <summary>
        ///     The btn save_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            ProjectUserControl1.SaveProjects();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        ///     ProjectDefinition
        ///     The load data.
        /// </summary>
        private void LoadData()
        {
            ProjectUserControl1.LoadProjects();
        }

        private void CloseForm()
        {
            var result = MessageBox.Show(
                            this,
                            $"Are you sure you want to close the application?{Environment.NewLine}Any unsaved changes will be lost...",
                            "Are you sure?",
                            MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        ///     The open tool strip menu item_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool displayDialog = false;

            if (!string.IsNullOrEmpty(ProjectUserControl1.ModelPath))
            {
                var result = MessageBox.Show(
                    this,
                    $"Are you sure you want to open a new model file?{Environment.NewLine}Any unsaved changes will be lost...",
                    "Are you sure?",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    displayDialog = true;
                }
            }
            else
            {
                displayDialog = true;
            }

            if (displayDialog && openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ProjectUserControl1.ModelPath = openFileDialog1.FileName;
                LoadData();
            }
        }

        /// <summary>
        /// The close tool strip menu item_ click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        /// <summary>
        /// The open tool strip menu item_ click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Prompt prompt = new Prompt("Please enter a name for the project folder.", ".NetScaffolder"))
            {
                string zipPath = @"..\..\..\..\..\..\Templates\ScaffolderTemplate.zip";
                string result = prompt.Result;
                if (!string.IsNullOrWhiteSpace(result))
                {
                    string extractPath = @"..\..\..\..\..\..\Templates\" + result;
                    System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                    MessageBox.Show(
                            this,
                            ".NetScaffolder project created.",
                            "Completed",
                            MessageBoxButtons.OK);

                    ProjectUserControl1.ModelPath = $@"{extractPath}\ScaffolderTemplate\Data\Repositories\Repository\Model\Banking.mdl";
                    LoadData();
                }
                else
                {
                    MessageBox.Show(
                            this,
                            ".NetScaffolder needs a name. to extract",
                            "Completed",
                            MessageBoxButtons.OK);
                }

            }

            



        }


        /// <summary>
        ///     The tab control 1_ selected index changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;

            if (tabControl.SelectedIndex == 0)
            {
                ProjectUserControl1.ProjectDomainDetailsUserControl.Loading = false;
                ProjectUserControl1.ProjectDomainDetailsUserControl.UpdateDomainPackages();
            }
        }

        #endregion

      
    }
}