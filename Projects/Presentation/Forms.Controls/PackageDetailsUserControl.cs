// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateDetailsUserControl.cs" company="">
//   
// </copyright>
// <summary>
//   The template details user control.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using Common.Logging;

    using Configuration;

    using DotNetScaffolder.Core.Common;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.Enum;

    #endregion

    /// <summary>
    ///     Package details user control.
    /// </summary>
    public partial class PackageDetailsUserControl : UserControl
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Fields

        /// <summary>
        ///     The data.
        /// </summary>
        private Package dataSource;

        /// <summary>
        /// Gets or sets the all templates.
        /// </summary>
        private List<Template> availableTemplates { get; set; }

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageDetailsUserControl"/> class.
        /// </summary>
        public PackageDetailsUserControl()
        {
            this.availableTemplates = this.availableTemplates;
            this.InitializeComponent();

            this.ComboBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //this.TemplateListBox.DisplayMember = "Name";
            //this.TemplateListBox.ValueMember = "Id";
            this.AvailableTemplates = new List<Template>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the templates.
        /// </summary>
        public List<Template> AvailableTemplates
        {
            get
            {
                return this.availableTemplates;
            }
            set
            {
                if (this.availableTemplates != value)
                {
                    this.TemplateListBox.DisplayMember = "Name";
                    this.TemplateListBox.ValueMember = "Id";

                    this.availableTemplates = value;

                    if (this.DataSource != null && this.DataSource.Templates.Count > 0)
                    {
                        List<Template> currentTemplates =
                            this.DataSource.Templates[0].ReturnTemplateItems(this.DataSource.Templates);

                        foreach (Template currentTemplate in currentTemplates)
                        {
                            this.availableTemplates.Remove(this.availableTemplates.First(t => t.Id == currentTemplate.Id));
                        }
                    }

                    this.UpdateDataSource();
                }
            }
        }

        /// <summary>
        /// Gets or sets the available templates.
        /// </summary>
        //public List<Template> AvailableTemplates { get; set; }

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        public Package DataSource
        {
            get
            {
                return this.dataSource;
            }

            set
            {
                if (this.dataSource != value)
                {
                    this.dataSource = value;
                    this.UpdateDataSource();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the package name.
        /// </summary>
        public string PackageName
        {
            get
            {
                string result = string.Empty;

                if (this.dataSource != null)
                {
                    result = this.DataSource.Name;
                    Logger.Trace($"PackageName set to {this.DataSource.Name}.");
                }
                else
                {
                    result = string.Empty;
                    Logger.Trace("Empty PackageName is not returned as data is null.");
                }

                return result;
            }

            set
            {
                if (this.DataSource != null)
                {
                    this.DataSource.Name = value;
                    this.TreeNode.Text = this.TextBoxName.Text;
                }
                else
                {
                    Logger.Trace("PackageName is not set as Data is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the tree node.
        /// </summary>
        public TreeNode TreeNode { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        public double Version
        {
            get
            {
                double result = 1;

                if (this.dataSource != null)
                {
                    result = this.DataSource.Version;
                    Logger.Trace($"Version set to {this.DataSource.Version}.");
                }
                else
                {
                    result = 1;
                    Logger.Trace("Empty Version is not returned as data is null.");
                }

                return result;
            }

            set
            {
                if (this.DataSource != null)
                {
                    this.DataSource.Version = value;
                }
                else
                {
                    Logger.Trace("Version is not set as Data is null.");
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether template enabled.
        /// </summary>
        public bool TemplateEnabled
        {
            get
            {
                bool result = false;

                if (this.dataSource != null)
                {
                    result = this.DataSource.Enabled;
                    Logger.Trace($"Enabled set to {this.DataSource.Enabled}.");
                }
                else
                {
                    result = false;
                    Logger.Trace("Enabled is false as data is null.");
                }

                return result;
            }

            set
            {
                if (this.DataSource != null)
                {
                    this.DataSource.Enabled = value;
                }
                else
                {
                    Logger.Trace("Enabled is false as data is null.");
                }
            }
        }

        #endregion


        #region Other Methods

        /// <summary>
        /// The text box name_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            this.PackageName = this.TextBoxName.Text;
        }

        /// <summary>
        /// The text box version_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        //private void TextBoxVersion_TextChanged(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(this.TextBoxVersion.Text))
        //    {
        //        this.Version = Convert.ToDouble(this.TextBoxVersion.Text);
        //    }
        //    else
        //    {
        //        this.Version = 0;
        //        this.TextBoxVersion.Text = 0.ToString();
        //    }
        //}

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            if (this.DataSource != null)
            {
                this.TextBoxName.Text = this.DataSource.Name;

                //this.TextBoxVersion.Text = this.DataSource.Version.ToString();
                this.CheckBoxEnabled.Checked = this.DataSource.Enabled;

                if (this.dataSource.HierarchyType == HierarchyType.Item)
                {
                    this.PanelTemplate.Visible = true;
                    if (this.DataSource.Templates.Count > 0)
                    {
                        this.TemplateListBox.DataSource = this.DataSource.Templates[0].ReturnTemplateItems(this.DataSource.Templates);
                        this.BtnRemove.Enabled = true;
                    }
                    else
                    {
                        this.TemplateListBox.DataSource = null;
                        this.BtnRemove.Enabled = false;
                    }

                    if (this.availableTemplates.Count == 0)
                    {
                        this.BtnAdd.Enabled = false;
                        this.ComboBoxSearch.Enabled = false;
                        this.ComboBoxSearch.AutoCompleteCustomSource.Clear();
                    }
                    else
                    {
                        this.BtnAdd.Enabled = true;
                        this.ComboBoxSearch.Enabled = true;

                        List<string> availableTemplates = new List<string>();

                        foreach (var template in this.availableTemplates)
                        {
                            availableTemplates.Add(template.Name);
                        }

                        this.ComboBoxSearch.AutoCompleteCustomSource.Clear();
                        this.ComboBoxSearch.AutoCompleteCustomSource.AddRange(availableTemplates.ToArray());
                    }

                }
                else
                {
                    this.PanelTemplate.Visible = false;
                }
            }
        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TemplateEnabled = (sender as CheckBox).Checked;
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

            if (this.DataSource != null)
            {
                //this.errorProvider1.Clear();
                //this.DataSource.Validate();

                //if (this.DataSource.ValidationResult.Count > 0)
                //{
                //    Validation validation = null;

                //    if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateName))
                //    {
                //        validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateName);
                //        this.TextBoxName.Focus();
                //        this.errorProvider1.SetError(
                //            this.TextBoxName,
                //            validation.Description);
                //        result++;
                //    }

                //    if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateLanguageOutputId))
                //    {
                //        validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateLanguageOutputId);
                //        this.ComboBoxLanguageOutput.Focus();
                //        this.errorProvider1.SetError(
                //            this.ComboBoxLanguageOutput,
                //            validation.Description);
                //        result++;
                //    }

                //    if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateGeneratorTypeId))
                //    {
                //        validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateGeneratorTypeId);
                //        this.ComboBoxGeneratorOutput.Focus();
                //        this.errorProvider1.SetError(
                //            this.ComboBoxGeneratorOutput,
                //            validation.Description);
                //        result++;
                //    }

                //    if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplatePath))
                //    {
                //        validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplatePath);
                //        this.TextBoxTemplate.Focus();
                //        this.errorProvider1.SetError(
                //            this.TextBoxTemplate,
                //            validation.Description);
                //        result++;
                //    }

                //    if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateVersion))
                //    {
                //        validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateVersion);
                //        this.TextBoxVersion.Focus();
                //        this.errorProvider1.SetError(
                //            this.TextBoxVersion,
                //            validation.Description);
                //        result++;
                //    }
                //}
            }

            Logger.Trace("Completed Validation()");
            return result;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Template selectedTemplate = this.AvailableTemplates.First(t => t.Name == this.ComboBoxSearch.Text);
            this.DataSource.Templates.Add(selectedTemplate);
            this.AvailableTemplates.Remove(selectedTemplate);
            this.UpdateDataSource();
            this.ComboBoxSearch.Text = string.Empty;
            //this.TemplateListBox.DataSource = this.DataSource.Templates[0].ReturnTemplateItems();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Template selectedTemplate = this.TemplateListBox.SelectedItem as Template;
            this.DataSource.Templates.Remove(selectedTemplate);
            this.AvailableTemplates.Add(selectedTemplate);
            this.UpdateDataSource();
            this.ComboBoxSearch.Text = string.Empty;
        }
    }
}