namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    using System;
    using System.Collections.Generic;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using Common.Logging;
    using System.Xml.Serialization;
    public class Template : IValidate
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string TemplatePath { get; set; }
        public DataType DataType { get; set; }
        public ConfigLocation ConfigLocation { get; set; }
        public double Version { get; set; }

        public Guid LanguageOutputId { get; set; }
        public Guid GeneratorTypeId { get; set; }
        public List<string> DefaultSettings { get; set; }

        [XmlIgnore]
        public Dictionary<ValidationType, string> ValidationResult{ get; set; }

        public Template()
        {
            Logger.Trace("Started Template()");
            this.ValidationResult = new Dictionary<ValidationType, string>();
            this.Enabled = false;
            this.DataType = new DataType();
            this.DefaultSettings = new List<string>();
            Logger.Trace("Completed Template()");
        }

        public Dictionary<ValidationType, string> Validate()
        {
            Logger.Trace("Started Validate()");
            this.ValidationResult.Clear();

            if (this.Id == Guid.Empty)
            {
                this.ValidationResult.Add(ValidationType.TemplateId, "TemplateId may not be empty");
            }

            if (string.IsNullOrEmpty(this.Name))
            {
                this.ValidationResult.Add(ValidationType.TemplateName, "TemplateName may not be empty");
            }

            if (string.IsNullOrEmpty(this.TemplatePath))
            {
                this.ValidationResult.Add(ValidationType.TemplatePath, "TemplatePath may not be empty");
            }

            if (this.LanguageOutputId == Guid.Empty)
            {
                this.ValidationResult.Add(ValidationType.TemplateLanguageOutputId, "TemplateLanguageOutputId may not be empty");
            }

            if (this.GeneratorTypeId == Guid.Empty)
            {
                this.ValidationResult.Add(ValidationType.TemplateGeneratorTypeId, "TemplateLanguageOutputId may not be empty");
            }

            //Todo: Add back
            //this.DataType.Validate();

            //foreach (var validationResult in this.DataType.ValidationResult)
            //{
            //    this.ValidationResult.Add(validationResult.Key, validationResult.Value);
            //}

            if (this.Version == 0)
            {
                this.ValidationResult.Add(ValidationType.TemplateVersion, "TemplateVersion may not be 0");
            }

            //Todo: Handle LanguageOutput & TemplateGeneratorType
            Logger.Trace("Completed Validate()");
            return this.ValidationResult;
        }
    }
}
