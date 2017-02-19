using Common.Logging;
using DotNetScaffolder.Core.Common.Serializer;
using DotNetScaffolder.Mapping.MetaData.Enum;
using DotNetScaffolder.Mapping.MetaData.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotNetScaffolder.Mapping.MetaData.Application.ApplicationServices
{
    public class ConfigurationAplicationServiceFile : IConfigurationAplicationService
    {
        public ConfigurationAplicationServiceFile()
        {
            Logger.Trace($"Started ConfigurationAplicationServiceFile()");
            this.ApplicationSettings = new ApplicationSettings();
            this.FilePersistenceOptions = new FilePersistenceOptions();
            Logger.Trace($"Completed ConfigurationAplicationServiceFile()");
        }

        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        public ApplicationSettings ApplicationSettings { get; set; }

        /// <summary>
        /// Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public Dictionary<ValidationType, string> ValidationResult { get; set; }

        /// <summary>
        ///     Gets or sets the file persistence options.
        /// </summary>
        public FilePersistenceOptions FilePersistenceOptions { get; set; }

        public void Load()
        {
            Logger.Trace($"Started Load() - Path: {this.FilePersistenceOptions.Path}");
            this.ApplicationSettings = ObjectXMLSerializer<ApplicationSettings>.Load(this.FilePersistenceOptions.Path);
            Logger.Trace($"Completed Load() - Path: {this.FilePersistenceOptions.Path}");
        }

        public void Save()
        {
            Logger.Trace($"Started Save() - Path: {this.FilePersistenceOptions.Path}");

            this.ValidationResult = this.ApplicationSettings.Validate();

            if (this.ValidationResult.Count == 0)
            {
                ObjectXMLSerializer<ApplicationSettings>.Save(
                    this.ApplicationSettings,
                    this.FilePersistenceOptions.Path,
                    SerializedFormat.Document);
            }
            else
            {
                Logger.Error($"Validation error: {this.ValidationResult.ToString()}");
                throw new ApplicationException($"Validation error: {this.ValidationResult.ToString()}");
            }

            Logger.Trace($"Completed Save() - Path: {this.FilePersistenceOptions.Path}");
        }

        public Dictionary<ValidationType, string> Validate()
        {
            Logger.Trace($"Started Validate()");
            this.ValidationResult.Clear();

            this.ApplicationSettings.Validate();

            foreach (var validation in this.ApplicationSettings.ValidationResult)
            {
                this.ValidationResult.Add(validation.Key, validation.Value);
            }

            Logger.Trace($"Completed Validate()");
            return this.ValidationResult;
        }
    }
}
