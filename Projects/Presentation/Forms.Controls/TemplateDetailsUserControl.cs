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
    using System.Windows.Forms;

    using Common.Logging;

    using Configuration;

    using DotNetScaffolder.Core.Common;
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
            this.InitializeComponent();

            this.ComboBoxLanguageOutput.DataSource = this.ReturnLanguageOutputs();
            this.ComboBoxLanguageOutput.DisplayMember = "Text";
            this.ComboBoxLanguageOutput.ValueMember = "Value";

            this.ComboBoxGeneratorOutput.DataSource = this.ReturnOutputGenerators();
            this.ComboBoxGeneratorOutput.DisplayMember = "Text";
            this.ComboBoxGeneratorOutput.ValueMember = "Value";
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

                if (this.data != null)
                {
                    result = this.Data.ConfigLocation;
                    Logger.Trace($"ConfigLocation set to {this.Data.ConfigLocation}.");
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
                if (this.Data != null)
                {
                    this.Data.ConfigLocation = value;

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
        /// Gets or sets the generator type id.
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
        /// Gets or sets the template path.
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
        /// Gets or sets the version.
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

        #endregion

        #region Other Methods

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
                this.GeneratorTypeId = new Guid(selectedItem.Value.ToString());
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
                this.LanguageId = new Guid(selectedItem.Value.ToString());
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
                this.ConfigLocation =
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
            this.TemplateName = this.TextBoxName.Text;
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
            this.TemplatePath = this.TextBoxTemplate.Text;
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
            if (!string.IsNullOrEmpty(this.TextBoxVersion.Text))
            {
                this.Version = Convert.ToDouble(this.TextBoxVersion.Text);
            }
        }

        /// <summary>
        ///     The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            this.TextBoxName.Text = this.Data.Name;
            this.TextBoxTemplate.Text = this.Data.TemplatePath;
            this.TextBoxVersion.Text = this.Data.Version.ToString();
            this.ComboBoxSetupLocation.SelectedIndex = this.Data.ConfigLocation.GetHashCode();
            this.CheckBoxEnabled.Checked = this.Data.Enabled;

            if (this.data.HierarchyType == HierarchyType.Item)
            {
                this.ComboBoxLanguageOutput.SelectedValue = this.Data.LanguageOutputId;
                this.ComboBoxGeneratorOutput.SelectedValue = this.Data.GeneratorTypeId;
                this.PanelTemplate.Visible = true;
            }
            else
            {
                this.PanelTemplate.Visible = false;
            }
        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TemplateEnabled = (sender as CheckBox).Checked;
        }
    }
}