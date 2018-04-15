// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EdmxUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs
{
    #region Usings

    using System;
    using System.IO;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract.UI;
    using DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.SourceOptions;
    using DotNetScaffolder.Core.Common.Serializer;

    #endregion

    /// <summary>
    ///     The edmx user control.
    /// </summary>
    public partial class EdmxUserControl : UserControl, IDataSourceUI
    {
        #region Fields

        /// <summary>
        /// The options.
        /// </summary>
        private FileSourceOptions options;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EdmxUserControl" /> class.
        /// </summary>
        public EdmxUserControl()
        {
            this.InitializeComponent();
            this.options = new FileSourceOptions();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the parameters.
        /// </summary>
        public object Parameters { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <inheritdoc />
        /// <summary>
        ///     The load data.
        /// </summary>
        /// <exception cref="T:System.NotImplementedException">
        /// </exception>
        public void LoadData(object parameters)
        {
            string path = this.ReturnFilePath(parameters as string);

            if (File.Exists(path))
            {
                this.options = ObjectXMLSerializer<FileSourceOptions>.Load(path);
                this.TxtFilePath.Text = this.options.Path;
            }
            else
            {
                this.TxtFilePath.Text = string.Empty;
            }
        }

        /// <summary>
        /// The save data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void SaveData(object parameters)
        {
            string path = this.ReturnFilePath(parameters as string);
            ObjectXMLSerializer<FileSourceOptions>.Save(this.options, path, SerializedFormat.Document);
        }

        /// <summary>
        /// The test data.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void TestData(object parameters)
        {
            string path = this.ReturnFilePath(parameters as string);
            if (File.Exists(this.options.Path))
            {
                MessageBox.Show("Edmx Path Correct", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Edmx Path Is Incorrect", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        public string ReturnFilePath(string basePath)
        {
            return basePath + @"\EdmxSourceType.xml";
        }

        #region Other Methods

        /// <summary>
        /// The btn browse_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.TxtFilePath.Text = this.openFileDialog1.FileName;
                this.options.Path = this.TxtFilePath.Text;
            }
        }

        #endregion

        private void TxtFilePath_TextChanged(object sender, EventArgs e)
        {
            this.options.Path = this.TxtFilePath.Text;
        }
    }
}