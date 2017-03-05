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
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    using FormControls.Enum;

    #endregion

    /// <summary>
    /// The template details user control.
    /// </summary>
    public partial class TemplateDetailsUserControl : UserControl
    {
        #region Fields

        /// <summary>
        /// The data.
        /// </summary>
        private Template data;

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDetailsUserControl"/> class.
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
        /// Return output generators.
        /// </summary>
        /// <returns>
        /// The <see cref="object[]"/>.
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
        #region Properties

        /// <summary>
        /// Gets or sets the data.
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
        /// Gets or sets the tree node.
        /// </summary>
        public TreeNode TreeNode { get; set; }

        #endregion

        #region Other Methods

        /// <summary>
        /// The update data source.
        /// </summary>
        private void UpdateDataSource()
        {
            this.TextBoxName.Text = this.Data.Name;
            this.TextBoxTemplate.Text = this.Data.TemplatePath;
            this.TextBoxVersion.Text = this.Data.Version.ToString();
            this.ComboBoxSetupLocation.SelectedIndex = this.Data.ConfigLocation.GetHashCode();

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

        /// <summary>
        /// Gets or sets the template name.
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
                    Logger.Trace("TemplateName is not set as SelectedDomain is null.");
                }
            }
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            this.TemplateName = this.TextBoxName.Text;
        }
    }
}