#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Common.Logging;
using DotNetScaffolder.Mapping.MetaData.Project.Packages;
using FormControls.Enum;

#endregion

namespace DotNetScaffolder.Presentation.Forms.Controls.Packages
{
    #region Usings

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

        private bool loading;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="PackageDetailsUserControl" /> class.
        /// </summary>
        public PackageDetailsUserControl()
        {
            availableTemplates = availableTemplates;
            InitializeComponent();

            ComboBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // this.TemplateListBox.DisplayMember = "Name";
            // this.TemplateListBox.ValueMember = "Id";
            AvailableTemplates = new List<Template>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the templates.
        /// </summary>
        public List<Template> AvailableTemplates
        {
            get { return availableTemplates; }

            set
            {
                if (availableTemplates != value)
                {
                    TemplateListBox.DisplayMember = "Name";
                    TemplateListBox.ValueMember = "Id";

                    availableTemplates = value;

                    if (DataSource != null && DataSource.Templates.Count > 0)
                    {
                        List<Template> currentTemplates =
                            DataSource.Templates[0].ReturnTemplateItems(DataSource.Templates);

                        foreach (Template currentTemplate in currentTemplates)
                        {
                            if (availableTemplates.Any(t => t.Id == currentTemplate.Id))
                            {
                                availableTemplates.Remove(
                                    availableTemplates.First(t => t.Id == currentTemplate.Id));
                            }
                        }
                    }

                    UpdateDataSource();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the available templates.
        /// </summary>
        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        public Package DataSource
        {
            get { return dataSource; }

            set
            {
                if (dataSource != value)
                {
                    dataSource = value;
                    UpdateDataSource();
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

                if (dataSource != null)
                {
                    result = DataSource.Name;
                    Logger.Trace($"PackageName set to {DataSource.Name}.");
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
                if (DataSource != null)
                {
                    DataSource.Name = value;
                    TreeNode.Text = TextBoxName.Text;
                }
                else
                {
                    Logger.Trace("PackageName is not set as Data is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the selected package.
        /// </summary>
        public Package SelectedPackage { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether template enabled.
        /// </summary>
        public bool TemplateEnabled
        {
            get
            {
                bool result = false;

                if (dataSource != null)
                {
                    result = DataSource.Enabled;
                    Logger.Trace($"Enabled set to {DataSource.Enabled}.");
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
                if (DataSource != null)
                {
                    DataSource.Enabled = value;
                }
                else
                {
                    Logger.Trace("Enabled is false as data is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the tree node.
        /// </summary>
        public TreeNode TreeNode { get; set; }

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        public double Version
        {
            get
            {
                double result = 1;

                if (dataSource != null)
                {
                    result = DataSource.Version;
                    Logger.Trace($"Version set to {DataSource.Version}.");
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
                if (DataSource != null)
                {
                    DataSource.Version = value;
                }
                else
                {
                    Logger.Trace("Version is not set as Data is null.");
                }
            }
        }

        #endregion

        #region Other Properties

        /// <summary>
        ///     Gets or sets the all templates.
        /// </summary>
        private List<Template> availableTemplates { get; set; }

        #endregion

        #region Public Methods And Operators

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

            if (DataSource != null)
            {
                // this.errorProvider1.Clear();
                // this.DataSource.Validate();

                // if (this.DataSource.ValidationResult.Count > 0)
                // {
                // Validation validation = null;

                // if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateName))
                // {
                // validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateName);
                // this.TextBoxName.Focus();
                // this.errorProvider1.SetError(
                // this.TextBoxName,
                // validation.Description);
                // result++;
                // }

                // if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateLanguageOutputId))
                // {
                // validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateLanguageOutputId);
                // this.ComboBoxLanguageOutput.Focus();
                // this.errorProvider1.SetError(
                // this.ComboBoxLanguageOutput,
                // validation.Description);
                // result++;
                // }

                // if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateGeneratorTypeId))
                // {
                // validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateGeneratorTypeId);
                // this.ComboBoxGeneratorOutput.Focus();
                // this.errorProvider1.SetError(
                // this.ComboBoxGeneratorOutput,
                // validation.Description);
                // result++;
                // }

                // if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplatePath))
                // {
                // validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplatePath);
                // this.TextBoxTemplate.Focus();
                // this.errorProvider1.SetError(
                // this.TextBoxTemplate,
                // validation.Description);
                // result++;
                // }

                // if (this.dataSource.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateVersion))
                // {
                // validation = this.dataSource.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateVersion);
                // this.TextBoxVersion.Focus();
                // this.errorProvider1.SetError(
                // this.TextBoxVersion,
                // validation.Description);
                // result++;
                // }
                // }
            }

            Logger.Trace("Completed Validation()");
            return result;
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The btn add_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Template selectedTemplate = AvailableTemplates.First(t => t.Name == ComboBoxSearch.Text);
            DataSource.Templates.Add(selectedTemplate);
            AvailableTemplates.Remove(selectedTemplate);
            UpdateDataSource();
            ComboBoxSearch.Text = string.Empty;

            if (SelectedPackage.Templates != null)
            {
                SelectedPackage.Templates = DataSource.Templates;
            }

            BtnAdd.Enabled = false;
        }

        /// <summary>
        ///     The btn remove_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Template selectedTemplate = TemplateListBox.SelectedItem as Template;
            DataSource.Templates.Remove(selectedTemplate);
            AvailableTemplates.Add(selectedTemplate);
            UpdateDataSource();
            ComboBoxSearch.Text = string.Empty;

            if (SelectedPackage.Templates != null)
            {
                SelectedPackage.Templates = DataSource.Templates;
            }
        }

        /// <summary>
        ///     The check box 1_ checked changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                TemplateEnabled = (sender as CheckBox).Checked;
            }
        }

        /// <summary>
        ///     The combo box search_ selected value changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ComboBoxSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                if (string.IsNullOrEmpty(ComboBoxSearch.Text))
                {
                    BtnAdd.Enabled = false;
                }
                else
                {
                    BtnAdd.Enabled = true;
                }
            }
        }

        /// <summary>
        ///     The combo box search_ text update.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void ComboBoxSearch_TextUpdate(object sender, EventArgs e)
        {
            if (!loading)
            {
                if (string.IsNullOrEmpty(ComboBoxSearch.Text))
                {
                    BtnAdd.Enabled = false;
                }
                else if (ComboBoxSearch.Text.Trim().Length > 1)
                {
                    BtnAdd.Enabled = true;
                }
            }
        }

        /// <summary>
        ///     The text box name_ text changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                PackageName = TextBoxName.Text;
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            if (DataSource != null)
            {
                loading = true;

                TextBoxName.Text = DataSource.Name;
                CheckBoxEnabled.Checked = DataSource.Enabled;

                if (dataSource.HierarchyType == HierarchyType.Item)
                {
                    PanelTemplate.Visible = true;
                    if (DataSource.Templates.Count > 0)
                    {
                        TemplateListBox.DataSource =
                            DataSource.Templates[0].ReturnTemplateItems(DataSource.Templates);
                        BtnRemove.Enabled = true;
                    }
                    else
                    {
                        TemplateListBox.DataSource = null;
                        BtnRemove.Enabled = false;
                    }

                    if (this.availableTemplates.Count == 0)
                    {
                        BtnAdd.Enabled = false;
                        ComboBoxSearch.Enabled = false;
                        ComboBoxSearch.AutoCompleteCustomSource.Clear();
                    }
                    else
                    {
                        BtnAdd.Enabled = true;
                        ComboBoxSearch.Enabled = true;

                        List<string> availableTemplates = new List<string>();

                        foreach (var template in this.availableTemplates)
                        {
                            availableTemplates.Add(template.Name);
                        }

                        ComboBoxSearch.AutoCompleteCustomSource.Clear();
                        ComboBoxSearch.AutoCompleteCustomSource.AddRange(availableTemplates.ToArray());
                        ComboBoxSearch.Items.Clear();
                        ComboBoxSearch.Items.AddRange(availableTemplates.ToArray());
                    }

                    if (string.IsNullOrEmpty(ComboBoxSearch.Text))
                    {
                        BtnAdd.Enabled = false;
                    }
                }
                else
                {
                    PanelTemplate.Visible = false;
                }

                loading = false;
            }
        }

        #endregion
    }
}