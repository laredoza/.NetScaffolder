// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDetailsUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Project;

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

        #region Properties

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

        /// <summary>
        ///     Gets or sets how layers are generated
        /// </summary>
        public GenerationType GroupBy
        {
            get
            {
                if (Project == null)
                {
                    Logger.Trace("Default GroupBy is returned as Project is null.");
                    return GenerationType.Domain;
                }

                Logger.Trace($"GroupBy: {Project.GroupBy}");
                return Project.GroupBy;
            }

            set
            {
                if (Project != null)
                {
                    Changed = true;
                    Project.GroupBy = value;
                    Logger.Trace($"GroupBy is set to {Project.GroupBy.ToString()}");
                }
                else
                {
                    Logger.Trace("GroupBy is not set as Project is null.");
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
            get
            {
                return project;
            }

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

        #region Public methods and operators

        /// <summary>
        ///     The update data source.
        /// </summary>
        public void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (Project != null)
            {
                TextBoxOutputFolderName.Text = Project.OutputFolder;
                TextBoxBaseNamespace.Text = Project.BaseNameSpace;
                ComboBoxGroupBy.SelectedIndex = Project.GroupBy.GetHashCode();
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
                        validation = Project.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.ProjectBaseNameSpace);
                        TextBoxBaseNamespace.Focus();
                        errorProvider1.SetError(
                            TextBoxBaseNamespace,
                            validation.Description);
                        result++;
                    }

                    if (Project.ValidationResult.Any(v => v.ValidationType == ValidationType.ProjectOutputFolder))
                    {
                        validation = Project.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.ProjectOutputFolder);
                        TextBoxOutputFolderName.Focus();
                        errorProvider1.SetError(
                            TextBoxOutputFolderName,
                            validation.Description);
                        result++;
                    }
                }
            }

            Logger.Trace("Completed Validation()");
            return result;
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The combo box group by_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxGroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.GroupBy = (GenerationType)ComboBoxGroupBy.SelectedIndex;
            }
        }

        /// <summary>
        /// The text box base namespace_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TextBoxBaseNamespace_TextChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.BaseNameSpace = TextBoxBaseNamespace.Text;
            }
        }

        /// <summary>
        /// The text box output folder name_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TextBoxOutputFolderName_TextChanged(object sender, EventArgs e)
        {
            if (Project != null)
            {
                Project.OutputFolder = TextBoxOutputFolderName.Text;
            }
        }

        #endregion
    }
}