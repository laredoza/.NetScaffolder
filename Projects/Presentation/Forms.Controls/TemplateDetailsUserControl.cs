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

    using Configuration;

    using DotNetScaffolder.Core.Common;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.Enum;

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
            InitializeComponent();

            ComboBoxLanguageOutput.DataSource = ReturnLanguageOutputs();
            ComboBoxLanguageOutput.DisplayMember = "Text";
            ComboBoxLanguageOutput.ValueMember = "Value";

            ComboBoxGeneratorOutput.DataSource = ReturnOutputGenerators();
            ComboBoxGeneratorOutput.DisplayMember = "Text";
            ComboBoxGeneratorOutput.ValueMember = "Value";
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the config location.
        /// </summary>
        public ConfigLocation ConfigLocation
        {
            get
            {
                ConfigLocation result = ConfigLocation.Data;

                if (data != null)
                {
                    result = Data.ConfigLocation;
                    Logger.Trace($"ConfigLocation set to {Data.ConfigLocation}.");
                }
                else
                {
                    result = ConfigLocation.Data;
                    Logger.Trace("Empty ConfigLocation is not returned as data is null.");
                }

                return result;
            }

            set
            {
                if (Data != null)
                {
                    Data.ConfigLocation = value;

                    // this.TreeNode.Text = this.TextBoxName.Text;
                }
                else
                {
                    Logger.Trace("ConfigLocation is not set as Data is null.");
                }
            }
        }

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        public Template Data
        {
            get
            {
                return data;
            }

            set
            {
                if (data != value)
                {
                    data = value;
                    UpdateDataSource();
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

                if (data != null)
                {
                    result = Data.GeneratorTypeId;
                    Logger.Trace($"GeneratorTypeId set to {Data.GeneratorTypeId}.");
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
                if (Data != null)
                {
                    Data.GeneratorTypeId = value;

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

                if (data != null)
                {
                    result = Data.LanguageOutputId;
                    Logger.Trace($"LanguageOutputId set to {Data.LanguageOutputId}.");
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
                if (Data != null)
                {
                    Data.LanguageOutputId = value;

                    // this.TreeNode.Text = this.TextBoxName.Text;
                }
                else
                {
                    Logger.Trace("LanguageOutputId is not set as Data is null.");
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

                if (data != null)
                {
                    result = Data.Enabled;
                    Logger.Trace($"Enabled set to {Data.Enabled}.");
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
                if (Data != null)
                {
                    Data.Enabled = value;
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

                if (data != null)
                {
                    result = Data.Name;
                    Logger.Trace($"TemplateName set to {Data.Name}.");
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
                if (Data != null)
                {
                    Data.Name = value;
                    TreeNode.Text = TextBoxName.Text;
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

                if (data != null)
                {
                    result = Data.TemplatePath;
                    Logger.Trace($"TemplatePath set to {Data.TemplatePath}.");
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
                if (Data != null)
                {
                    Data.TemplatePath = value;
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

                if (data != null)
                {
                    result = Data.Version;
                    Logger.Trace($"Version set to {Data.Version}.");
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
                if (Data != null)
                {
                    Data.Version = value;
                }
                else
                {
                    Logger.Trace("Version is not set as Data is null.");
                }
            }
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     Return driver types.
        /// </summary>
        /// <returns>
        ///     The <see cref="object[]" />.
        /// </returns>
        public object[] ReturnLanguageOutputs()
        {
            List<ComboboxItem> items = new List<ComboboxItem>();

            foreach (var language in ScaffoldConfig.LanguageOutputs)
            {
                items.Add(
                    new ComboboxItem
                        {
                            Text = (string)language.Metadata["NameMetaData"],
                            Value = new Guid(language.Metadata["ValueMetaData"].ToString())
                        });
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

            if (Data != null)
            {
                errorProvider1.Clear();
                Data.Validate();

                if (Data.ValidationResult.Count > 0)
                {
                    Validation validation = null;

                    if (data.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateName))
                    {
                        validation = data.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateName);
                        TextBoxName.Focus();
                        errorProvider1.SetError(
                            TextBoxName,
                            validation.Description);
                        result++;
                    }

                    if (data.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateLanguageOutputId))
                    {
                        validation = data.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateLanguageOutputId);
                        ComboBoxLanguageOutput.Focus();
                        errorProvider1.SetError(
                            ComboBoxLanguageOutput,
                            validation.Description);
                        result++;
                    }

                    if (data.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateGeneratorTypeId))
                    {
                        validation = data.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateGeneratorTypeId);
                        ComboBoxGeneratorOutput.Focus();
                        errorProvider1.SetError(
                            ComboBoxGeneratorOutput,
                            validation.Description);
                        result++;
                    }

                    if (data.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplatePath))
                    {
                        validation = data.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplatePath);
                        TextBoxTemplate.Focus();
                        errorProvider1.SetError(
                            TextBoxTemplate,
                            validation.Description);
                        result++;
                    }

                    if (data.ValidationResult.Any(v => v.ValidationType == ValidationType.TemplateVersion))
                    {
                        validation = data.ValidationResult.FirstOrDefault(v => v.ValidationType == ValidationType.TemplateVersion);
                        TextBoxVersion.Focus();
                        errorProvider1.SetError(
                            TextBoxVersion,
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
            TemplateEnabled = (sender as CheckBox).Checked;
        }

        /// <summary>
        /// The combo box generator output_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxGeneratorOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem selectedItem = (sender as ComboBox).SelectedItem as ComboboxItem;

            if (selectedItem != null)
            {
                GeneratorTypeId = new Guid(selectedItem.Value.ToString());
            }
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

            if (selectedItem != null)
            {
                LanguageId = new Guid(selectedItem.Value.ToString());
            }
        }

        /// <summary>
        /// The combo box setup location_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ComboBoxSetupLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
            {
                ConfigLocation =
                    (ConfigLocation)
                    System.Enum.Parse(typeof(ConfigLocation), (sender as ComboBox).SelectedItem.ToString());
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
            TemplateName = TextBoxName.Text;
        }

        /// <summary>
        /// The text box template_ text changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TextBoxTemplate_TextChanged(object sender, EventArgs e)
        {
            TemplatePath = TextBoxTemplate.Text;
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
        private void TextBoxVersion_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxVersion.Text))
            {
                Version = Convert.ToDouble(TextBoxVersion.Text);
            }
            else
            {
                Version = 0;
                TextBoxVersion.Text = 0.ToString();
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            TextBoxName.Text = Data.Name;
            TextBoxTemplate.Text = Data.TemplatePath;
            TextBoxVersion.Text = Data.Version.ToString();
            ComboBoxSetupLocation.SelectedIndex = Data.ConfigLocation.GetHashCode();
            CheckBoxEnabled.Checked = Data.Enabled;

            if (data.HierarchyType == HierarchyType.Item)
            {
                ComboBoxLanguageOutput.SelectedValue = Data.LanguageOutputId;
                ComboBoxGeneratorOutput.SelectedValue = Data.GeneratorTypeId;
                PanelTemplate.Visible = true;
            }
            else
            {
                PanelTemplate.Visible = false;
            }
        }

        #endregion
    }
}