#region Usings

using System;
using System.Linq;
using System.Windows.Forms;
using Common.Logging;
using DotNetScaffolder.Core.Common.Validation;
using DotNetScaffolder.Mapping.MetaData.Project;

#endregion

namespace DotNetScaffolder.Presentation.Forms.Controls.Project
{
    #region Usings

    #endregion

    /// <summary>
    ///     The project details user control.
    /// </summary>
    public partial class ProjectDetailsUserControl : UserControl
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        private bool loading;

        /// <summary>
        ///     The project.
        /// </summary>
        private ProjectDefinition project;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectDetailsUserControl" /> class.
        /// </summary>
        public ProjectDetailsUserControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the base name space.
        /// </summary>
        public string BaseNameSpace
        {
            get
            {
                if (Project == null)
                {
                    Logger.Trace("Empty BaseNameSpace is returned as Project is null.");
                    return string.Empty;
                }

                Logger.Trace($"BaseNameSpace: {Project.BaseNameSpace}");
                return Project.BaseNameSpace;
            }

            set
            {
                if (Project != null)
                {
                    Changed = true;
                    Project.BaseNameSpace = value.Trim();
                    Logger.Trace($"BaseNameSpace set to {Project.BaseNameSpace}");
                }
                else
                {
                    Logger.Trace("BaseNameSpace is not updated as Project is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether changed.
        /// </summary>
        public bool Changed { get; set; }

        public string Company
        {
            get
            {
                if (Project == null)
                {
                    Logger.Trace("Company is returned empty as Project is null.");
                    return string.Empty;
                }

                Logger.Trace($"Company: {Project.Company}");
                return Project.Company;
            }

            set
            {
                if (Project != null)
                {
                    Changed = true;
                    Project.Company = value.Trim();
                    Logger.Trace($"Company is changed to {Project.Company}");
                }
                else
                {
                    Logger.Trace("Company is not changed as Project is null.");
                }
            }
        }

        public string HeaderText
        {
            get
            {
                if (Project == null)
                {
                    Logger.Trace("HeaderText is returned empty as Project is null.");
                    return string.Empty;
                }

                Logger.Trace($"HeaderText: {Project.HeaderText}");
                return Project.HeaderText;
            }

            set
            {
                if (Project != null)
                {
                    Changed = true;
                    Project.HeaderText = value.Trim();
                    Logger.Trace($"HeaderText is changed to {Project.HeaderText}");
                }
                else
                {
                    Logger.Trace("HeaderText is not changed as Project is null.");
                }
            }
        }

        public string License
        {
            get
            {
                if (Project == null)
                {
                    Logger.Trace("License is returned empty as Project is null.");
                    return string.Empty;
                }

                Logger.Trace($"Company: {Project.License}");
                return Project.License;
            }

            set
            {
                if (Project != null)
                {
                    Changed = true;
                    Project.License = value.Trim();
                    Logger.Trace($"Company is changed to {Project.License}");
                }
                else
                {
                    Logger.Trace("License is not changed as Project is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder
        {
            get
            {
                if (Project == null)
                {
                    Logger.Trace("OutputFolder is returned empty as Project is null.");
                    return string.Empty;
                }

                Logger.Trace($"OutputFolder: {Project.OutputFolder}");
                return Project.OutputFolder;
            }

            set
            {
                if (Project != null)
                {
                    Changed = true;
                    Project.OutputFolder = value.Trim();
                    Logger.Trace($"OutputFolder is changed to {Project.OutputFolder}");
                }
                else
                {
                    Logger.Trace("OutputFolder is not changed as Project is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the project.
        /// </summary>
        public ProjectDefinition Project
        {
            get { return project; }

            set
            {
                project = value;

                if (!Changed)
                {
                    UpdateDataSource();
                }
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The update data source.
        /// </summary>
        public void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (Project != null)
            {
                loading = true;

                TextBoxOutputFolderName.Text = Project.OutputFolder;
                TextBoxBaseNamespace.Text = Project.BaseNameSpace;
                TextBoxHeader.Text = Project.HeaderText;
                TextBoxCompany.Text = Project.Company;
                TextBoxLicense.Text = Project.License;

                loading = false;
            }
            else
            {
                Logger.Trace("Data Source not updated as project is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        /// <summary>
        ///     The validation.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public int Validation()
        {
            Logger.Trace("Started Validation()");

            int result = 0;

            if (Project != null)
            {
                errorProvider1.Clear();
                Project.Validate();

                if (Project.ValidationResult.Count > 0)
                {
                    Validation validation = null;

                    if (Project.ValidationResult.Any(v => v.ValidationType == ValidationType.ProjectBaseNameSpace))
                    {
                        validation = Project.ValidationResult.FirstOrDefault(
                            v => v.ValidationType == ValidationType.ProjectBaseNameSpace);
                        TextBoxBaseNamespace.Focus();
                        errorProvider1.SetError(TextBoxBaseNamespace, validation.Description);
                        result++;
                    }

                    if (Project.ValidationResult.Any(v => v.ValidationType == ValidationType.ProjectOutputFolder))
                    {
                        validation = Project.ValidationResult.FirstOrDefault(
                            v => v.ValidationType == ValidationType.ProjectOutputFolder);
                        TextBoxOutputFolderName.Focus();
                        errorProvider1.SetError(TextBoxOutputFolderName, validation.Description);
                        result++;
                    }
                }
            }

            Logger.Trace("Completed Validation()");
            return result;
        }

        #endregion

        #region Other Methods

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Project != null && !loading)
            {
                Project.Company = TextBoxCompany.Text;
            }
        }

        /// <summary>
        ///     The text box base namespace_ text changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void TextBoxBaseNamespace_TextChanged(object sender, EventArgs e)
        {
            if (Project != null && !loading)
            {
                Project.BaseNameSpace = TextBoxBaseNamespace.Text;
            }
        }

        private void TextBoxHeader_TextChanged(object sender, EventArgs e)
        {
            if (Project != null && !loading)
            {
                Project.HeaderText = TextBoxHeader.Text;
            }
        }

        private void TextBoxLicense_TextChanged(object sender, EventArgs e)
        {
            if (Project != null && !loading)
            {
                Project.License = TextBoxLicense.Text;
            }
        }

        /// <summary>
        ///     The text box output folder name_ text changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void TextBoxOutputFolderName_TextChanged(object sender, EventArgs e)
        {
            if (Project != null && !loading)
            {
                Project.OutputFolder = TextBoxOutputFolderName.Text;
            }
        }

        #endregion
    }
}