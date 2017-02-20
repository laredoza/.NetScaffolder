// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectDetailsUserControl.cs" company="">
//   
// </copyright>
// <summary>
//   The project details user control.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Using

    using System;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Project;
    using Core.Common.Validation;
    using System.Linq;

    #endregion

    /// <summary>
    /// The project details user control.
    /// </summary>
    public partial class ProjectDetailsUserControl : UserControl
    {
        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #region Fields

        /// <summary>
        ///     The project.
        /// </summary>
        private ProjectDefinition project;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDetailsUserControl"/> class.
        /// </summary>
        public ProjectDetailsUserControl()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the base name space.
        /// </summary>
        public string BaseNameSpace
        {
            get
            {
                if (this.Project == null)
                {
                    Logger.Trace("Empty BaseNameSpace is returned as Project is null.");
                    return string.Empty;
                }
                else
                {
                    Logger.Trace($"BaseNameSpace: {this.Project.BaseNameSpace}");
                    return this.Project.BaseNameSpace;
                }
            }

            set
            {
                if (this.Project != null)
                {
                    this.Changed = true;
                    this.Project.BaseNameSpace = value.Trim();
                    Logger.Trace($"BaseNameSpace set to {this.Project.BaseNameSpace}");
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
                if (this.Project == null)
                {
                    Logger.Trace("Default GroupBy is returned as Project is null.");
                    return GenerationType.Domain;
                }
                else
                {
                    Logger.Trace($"GroupBy: {this.Project.GroupBy}");
                    return this.Project.GroupBy;
                }
            }

            set
            {
                if (this.Project != null)
                {
                    this.Changed = true;
                    this.Project.GroupBy = value;
                    Logger.Trace($"GroupBy is set to {this.Project.GroupBy.ToString()}");
                }
                else
                {
                    Logger.Trace("GroupBy is not set as Project is null.");
                }
            }
        }

        /// <summary>
        /// Gets or sets the output folder.
        /// </summary>
        public string OutputFolder
        {
            get
            {
                if (this.Project == null)
                {
                    Logger.Trace("OutputFolder is returned empty as Project is null.");
                    return string.Empty;
                }
                else
                {
                    Logger.Trace($"OutputFolder: {this.Project.OutputFolder}");
                    return this.Project.OutputFolder;
                }
            }

            set
            {
                if (this.Project != null)
                {
                    this.Changed = true;
                    this.Project.OutputFolder = value.Trim();
                    Logger.Trace($"OutputFolder is changed to {this.Project.OutputFolder}");
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
                return this.project;
            }

            set
            {
                this.project = value;

                if (!this.Changed)
                {
                    this.UpdateDataSource();
                }
            }
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The update data source.
        /// </summary>
        public void UpdateDataSource()
        {
            Logger.Trace("Started UpdateDataSource()");

            if (this.Project != null)
            {
                this.TextBoxOutputFolderName.Text = this.Project.OutputFolder;
                this.TextBoxBaseNamespace.Text = this.Project.BaseNameSpace;
                this.ComboBoxGroupBy.SelectedIndex = this.Project.GroupBy.GetHashCode();
            }
            else
            {
                Logger.Trace("Data Source not updated as project is null ");
            }

            Logger.Trace("Completed UpdateDataSource()");
        }

        /// <summary>
        /// The validation.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Validation()
        {
            Logger.Trace("Started Validation()");

            int result = 0;

            if (this.Project != null)
            {
                this.errorProvider1.Clear();
                this.Project.Validate();

                if (this.Project.ValidationResult.Count > 0)
                {
                    Validation validation = null;

                    if (this.Project.ValidationResult.Any(v => v.ValidationType == ValidationType.ProjectBaseNameSpace))
                    {
                        validation = this.Project.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.ProjectBaseNameSpace);
                        this.TextBoxBaseNamespace.Focus();
                        this.errorProvider1.SetError(
                            this.TextBoxBaseNamespace,
                            validation.Description);
                        result++;
                    }

                    if (this.Project.ValidationResult.Any(v => v.ValidationType == ValidationType.ProjectOutputFolder))
                    {
                        validation = this.Project.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.ProjectOutputFolder);
                        this.TextBoxOutputFolderName.Focus();
                        this.errorProvider1.SetError(
                            this.TextBoxOutputFolderName,
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
            if (this.Project != null)
            {
                this.Project.GroupBy = (GenerationType)this.ComboBoxGroupBy.SelectedIndex;
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
            if (this.Project != null)
            {
                this.Project.BaseNameSpace = this.TextBoxBaseNamespace.Text;
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
            if (this.Project != null)
            {
                this.Project.OutputFolder = this.TextBoxOutputFolderName.Text;
            }
        }

        #endregion
    }
}