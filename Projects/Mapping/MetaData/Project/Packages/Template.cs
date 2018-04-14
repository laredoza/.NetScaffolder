// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Template.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using Common.Logging;

    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Enum;

    using FormControls.Enum;
    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The template.
    /// </summary>
    [Serializable]
    public class Template : Hierarchy, IValidate
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        public Template()
        {
            Logger.Trace("Started Template()");
            ValidationResult = new List<Validation>();
            Enabled = false;
            DataType = Guid.Empty;
            DefaultSettings = new List<string>();
            Children = new List<Hierarchy>();
            Logger.Trace("Completed Template()");
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the config location.
        /// </summary>
        public ConfigLocation ConfigLocation { get; set; }

        /// <summary>
        ///     Gets or sets the data type.
        /// </summary>
        public Guid DataType { get; set; }

        /// <summary>
        ///     Gets or sets the default settings.
        /// </summary>
        public List<string> DefaultSettings { get; set; }

        /// <summary>
        ///     Gets or sets the generator type id.
        /// </summary>
        public Guid GeneratorTypeId { get; set; }

        /// <summary>
        ///     Gets or sets the language output id.
        /// </summary>
        public Guid LanguageOutputId { get; set; }

        /// <summary>
        ///     Gets or sets the template path.
        /// </summary>
        public string TemplatePath { get; set; }

        /// <summary>
        ///     Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        public double Version { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The return template items.
        /// </summary>
        /// <param name="templates">
        /// The templates.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Template> ReturnTemplateItems(List<Template> templates)
        {
            List<Template> results = new List<Template>();

            foreach (Template template in templates)
            {
                results.AddRange(ReturnTemplateItems(template));
            }

            return results;
        }

        /// <summary>
        ///     Return template items.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Template> ReturnTemplateItems()
        {
            return ReturnTemplateItems(this);
        }

        /// <summary>
        /// Return template items.
        /// </summary>
        /// <param name="template">
        /// The template.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Template> ReturnTemplateItems(Template template)
        {
            List<Template> result = new List<Template>();

            if (template.HierarchyType == HierarchyType.Item)
            {
                result.Add(template);
            }
            else
            {
                foreach (Hierarchy child in template.Children)
                {
                    if (template.HierarchyType == HierarchyType.Item)
                    {
                        result.Add(child as Template);
                    }
                    else
                    {
                        result.AddRange(ReturnTemplateItems(child as Template));
                    }
                }
            }

            return result;
        }

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<Validation> Validate()
        {
            Logger.Trace("Started Validate()");
            ValidationResult.Clear();

            if (Id == Guid.Empty)
            {
                ValidationResult.Add(new Validation(ValidationType.TemplateId, "TemplateId may not be empty"));
            }

            if (string.IsNullOrEmpty(Name))
            {
                ValidationResult.Add(new Validation(ValidationType.TemplateName, "TemplateName may not be empty"));
            }

            if (HierarchyType == HierarchyType.Item)
            {
                if (string.IsNullOrEmpty(TemplatePath))
                {
                    ValidationResult.Add(
                        new Validation(ValidationType.TemplatePath, "TemplatePath may not be empty"));
                }

                if (LanguageOutputId == Guid.Empty)
                {
                    ValidationResult.Add(
                        new Validation(
                            ValidationType.TemplateLanguageOutputId,
                            "TemplateLanguageOutputId may not be empty"));
                }

                if (GeneratorTypeId == Guid.Empty)
                {
                    ValidationResult.Add(
                        new Validation(
                            ValidationType.TemplateGeneratorTypeId,
                            "TemplateLanguageOutputId may not be empty"));
                }

                // Todo: Add back
                // this.DataType.Validate();

                // foreach (var validationResult in this.DataType.ValidationResult)
                // {
                // this.ValidationResult.Add(validationResult);
                // }
            }

            if (Version == 0)
            {
                ValidationResult.Add(
                    new Validation(ValidationType.TemplateVersion, "TemplateVersion may not be 0"));
            }

            // Template child;
            Template child;
            foreach (var hierarchy in Children)
            {
                child = hierarchy as Template;
                child.Validate();

                foreach (var validation in child.ValidationResult)
                {
                    ValidationResult.Add(validation);
                }
            }

            // Todo: Handle LanguageOutput & TemplateGeneratorType
            Logger.Trace("Completed Validate()");
            return ValidationResult;
        }

        #endregion
    }
}