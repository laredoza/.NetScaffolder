// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateDetailsUserControl.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Presentation.Forms.Controls
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using Common.Logging;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.MetaData;
    using DotNetScaffolder.Core.Common;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.Enum;
    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The template details user control.
    /// </summary>
    public partial class TemplateDetailsUserControl : UserControl
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
        private Template data;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="TemplateDetailsUserControl" /> class.
        /// </summary>
        public TemplateDetailsUserControl()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether data source initialized.
        /// </summary>
        public bool DataSourceInitialized { get; set; }

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        public Template Data
        {
            get
            {
                return this.data;
            }

            set
            {
                if (this.data != value)
                {
                    this.data = value;
                    this.UpdateDataSource();
                }
            }
        }

        /// <summary>
        ///     Gets or sets the generator type id.
        /// </summary>
        public Guid GeneratorTypeId
        {
            get
            {
                Guid result = Guid.Empty;

                if (this.data != null)
                {
                    result = this.Data.GeneratorTypeId;
                    Logger.Trace($"GeneratorTypeId set to {this.Data.GeneratorTypeId}.");
                }
                else
                {
                    result = Guid.Empty;
                    Logger.Trace("Empty GeneratorTypeId is not returned as data is null.");
                }

                return result;
            }

            set
            {
                if (this.Data != null)
                {
                    this.Data.GeneratorTypeId = value;

                    // this.TreeNode.Text = this.TextBoxName.Text;
                }
                else
                {
                    Logger.Trace("GeneratorTypeId is not set as Data is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the language id.
        /// </summary>
        public Guid LanguageId
        {
            get
            {
                Guid result = Guid.Empty;

                if (this.data != null)
                {
                    result = this.Data.LanguageOutputId;
                    Logger.Trace($"LanguageOutputId set to {this.Data.LanguageOutputId}.");
                }
                else
                {
                    result = Guid.Empty;
                    Logger.Trace("Empty LanguageOutputId is not returned as data is null.");
                }

                return result;
            }

            set
            {
                if (this.Data != null)
                {
                    this.Data.LanguageOutputId = value;

                    // this.TreeNode.Text = this.TextBoxName.Text;
                }
                else
                {
                    Logger.Trace("LanguageOutputId is not set as Data is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether template enabled.
        /// </summary>
        public bool TemplateEnabled
        {
            get
            {
                bool result = false;

                if (this.data != null)
                {
                    result = this.Data.Enabled;
                    Logger.Trace($"Enabled set to {this.Data.Enabled}.");
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
                if (this.Data != null)
                {
                    this.Data.Enabled = value;
                }
                else
                {
                    Logger.Trace("Enabled is false as data is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the template name.
        /// </summary>
        public string TemplateName
        {
            get
            {
                string result = string.Empty;

                if (this.data != null)
                {
                    result = this.Data.Name;
                    Logger.Trace($"TemplateName set to {this.Data.Name}.");
                }
                else
                {
                    result = string.Empty;
                    Logger.Trace("Empty TemplateName is not returned as data is null.");
                }

                return result;
            }

            set
            {
                if (this.Data != null)
                {
                    this.Data.Name = value;
                    this.TreeNode.Text = this.TextBoxName.Text;
                }
                else
                {
                    Logger.Trace("TemplateName is not set as Data is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the template path.
        /// </summary>
        public string TemplatePath
        {
            get
            {
                string result = string.Empty;

                if (this.data != null)
                {
                    result = this.Data.TemplatePath;
                    Logger.Trace($"TemplatePath set to {this.Data.TemplatePath}.");
                }
                else
                {
                    result = string.Empty;
                    Logger.Trace("Empty TemplatePath is not returned as data is null.");
                }

                return result;
            }

            set
            {
                if (this.Data != null)
                {
                    this.Data.TemplatePath = value;
                }
                else
                {
                    Logger.Trace("TemplatePath is not set as Data is null.");
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

                if (this.data != null)
                {
                    result = this.Data.Version;
                    Logger.Trace($"Version set to {this.Data.Version}.");
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
                if (this.Data != null)
                {
                    this.Data.Version = value;
                }
                else
                {
                    Logger.Trace("Version is not set as Data is null.");
                }
            }
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     Return driver types.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public object[] ReturnLanguageOutputs()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();
            items.Add(new ComboboxItem{ Text = "Please select"});

            if (this.Data != null)
            {
                IDataType dataType = ScaffoldConfig.ReturnDataType(this.Data.DataType);

                foreach (LanguageOutputDetails selectedLanguageDetails in dataType.LanguageOutputDetails)
                {
                    foreach (var language in ScaffoldConfig.LanguageOutputs)
                    {
                        if (selectedLanguageDetails.LanguageOutput
                            == new Guid(language.Metadata["ValueMetaData"].ToString()))
                        {
                            items.Add(
                                new ComboboxItem
                                {
                                    Text = (string)language.Metadata["NameMetaData"],
                                    Value = new Guid(language.Metadata["ValueMetaData"].ToString())
                                });

                            break;
                        }
                    }
                }
            }

            return items.ToArray();
        }

        /// <summary>
        ///     Return output generators.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public object[] ReturnOutputGenerators()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();
            items.Add(new ComboboxItem { Text = "Please select" });

            foreach (var outputGenerator in ScaffoldConfig.OutputGenerators)
            {
                items.Add(
                    new ComboboxItem
                    {
                        Text = (string)outputGenerator.Metadata["NameMetaData"],
                        Value = new Guid(outputGenerator.Metadata["ValueMetaData"].ToString())
                    });
            }

            return items.ToArray();
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

            if (this.Data != null)
            {
                this.errorProvider1.Clear();
                this.Data.Validate();

                if (this.Data.ValidationResult.Count > 0)
                {
                    Validation validation = null;

                    if (this.data.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateName))
                    {
                        validation =
                            this.data.ValidationResult.FirstOrDefault(
                                v => v.ValidationType == ValidationType.TemplateName);
                        this.TextBoxName.Focus();
                        this.errorProvider1.SetError(this.TextBoxName, validation.Description);
                        result++;
                    }

                    if (this.data.ValidationResult.Any(
                        v => v.ValidationType == ValidationType.TemplateLanguageOutputId))
                    {
                        validation = this.data.ValidationResult.FirstOrDefault(
                            v => v.ValidationType == ValidationType.TemplateLanguageOutputId);
                        this.ComboBoxLanguageOutput.Focus();
                        this.errorProvider1.SetError(this.ComboBoxLanguageOutput, validation.Description);
                        result++;
                    }

                    if (this.data.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateGeneratorTypeId))
                    {
                        validation = this.data.ValidationResult.FirstOrDefault(
                            v => v.ValidationType == ValidationType.TemplateGeneratorTypeId);
                        this.ComboBoxGeneratorOutput.Focus();
                        this.errorProvider1.SetError(this.ComboBoxGeneratorOutput, validation.Description);
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
        /// The check box 1_ checked changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TemplateEnabled = (sender as CheckBox).Checked;
        }

        /// <summary>
        /// The combo box language output_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxLanguageOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem selectedItem = (sender as ComboBox).SelectedItem as ComboboxItem;

            if (selectedItem != null && this.DataSourceInitialized)
            {
                if (selectedItem.Value != null)
                {
                    this.LanguageId = new Guid(selectedItem.Value.ToString());

                    IDataType dataType = ScaffoldConfig.ReturnDataType(this.Data.DataType);
                    LanguageOutputDetails languageOutputDetail =
                        dataType.LanguageOutputDetails.FirstOrDefault(l => l.LanguageOutput == this.LanguageId);

                    this.GeneratorTypeId = languageOutputDetail.OutputGenerator;

                    this.ComboBoxGeneratorOutput.SelectedValue = this.GeneratorTypeId;

                    this.ListBoxTemplates.Items.Clear();
                    foreach (string template in languageOutputDetail.Templates)
                    {
                        this.ListBoxTemplates.Items.Add(template);
                    }
                }
                else
                {
                    this.LanguageId = Guid.Empty;
                    this.GeneratorTypeId = Guid.Empty;
                    this.ComboBoxGeneratorOutput.SelectedIndex = 0;
                    this.ListBoxTemplates.Items.Clear();
                }
            }
        }

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
            this.TemplateName = this.TextBoxName.Text;
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {

            this.DataSourceInitialized = false;
            this.TextBoxName.Text = this.Data.Name;
            this.CheckBoxEnabled.Checked = this.Data.Enabled;

            if (this.data.HierarchyType == HierarchyType.Item)
            {
                this.ComboBoxLanguageOutput.SelectedValue = this.Data.LanguageOutputId;
                //this.ComboBoxGeneratorOutput.SelectedValue = this.Data.GeneratorTypeId;
                this.PanelTemplate.Visible = true;

                this.ComboBoxLanguageOutput.DataSource = null;
                this.ComboBoxGeneratorOutput.DataSource = null;

                this.ComboBoxLanguageOutput.DataSource = this.ReturnLanguageOutputs();
                this.ComboBoxLanguageOutput.DisplayMember = "Text";
                this.ComboBoxLanguageOutput.ValueMember = "Value";

                this.ComboBoxGeneratorOutput.DataSource = this.ReturnOutputGenerators();
                this.ComboBoxGeneratorOutput.DisplayMember = "Text";
                this.ComboBoxGeneratorOutput.ValueMember = "Value";

                this.DataSourceInitialized = true;
                this.ComboBoxLanguageOutput.SelectedValue = this.LanguageId;
            }
            else
            {
                this.PanelTemplate.Visible = false;
            }
        }

        #endregion
    }
}