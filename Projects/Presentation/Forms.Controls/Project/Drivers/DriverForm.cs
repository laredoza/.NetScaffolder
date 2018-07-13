#region Usings

using System;
using System.Windows.Forms;
using DotNetScaffolder.Mapping.MetaData.Domain;

#endregion

namespace DotNetScaffolder.Presentation.Forms.Controls.Project.Drivers
{
    public partial class DriverForm : Form
    {
        #region Fields

        /// <summary>
        ///     The data source.
        /// </summary>
        private DomainDefinition dataSource;

        private string savePath;

        #endregion

        #region Constructors and Destructors

        public DriverForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the data source.
        /// </summary>
        public DomainDefinition DataSource
        {
            get { return dataSource; }

            set
            {
                if (dataSource != value)
                {
                    dataSource = value;
                    DriverUserControl1.DataSource = value;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the save path.
        /// </summary>
        public string SavePath
        {
            get => savePath;

            set
            {
                if (savePath != value)
                {
                    savePath = value;
                    DriverUserControl1.SavePath = savePath;
                }
            }
        }

        #endregion

        #region Other Methods

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DriverUserControl1.Save();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}