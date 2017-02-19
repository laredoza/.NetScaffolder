namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    using System;
    using System.Collections.Generic;
    using Enum;
    using Common.Logging;
    using System.Xml.Serialization;    /// <summary>
                                       /// This class is used to represent the base data types used by 
                                       /// the generator.
                                       /// </summary>
                                       /// <example>
                                       /// Context, Entity, Repository 
                                       /// </example>
    public class DataType : IValidate
    {
        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        public Guid Id { get; set; }
        public string Name { get; set; }

        [XmlIgnore]
        public Dictionary<ValidationType, string> ValidationResult { get; set; }

        public Dictionary<ValidationType, string> Validate()
        {
            Logger.Trace("Started Validate()");
            this.ValidationResult.Clear();

            if (this.Id == Guid.Empty)
            {
                this.ValidationResult.Add(ValidationType.DomainId, "DomainId should not be empty");
            }

            if (string.IsNullOrEmpty(this.Name))
            {
                this.ValidationResult.Add(ValidationType.DomainName, "DomainName should not be empty");
            }
            
            Logger.Trace("Completed Validate()");
            return this.ValidationResult;
        }

        public DataType()
        {
            Logger.Trace("Started DataType()");
            this.ValidationResult = new Dictionary<ValidationType, string>();
            Logger.Trace("Completed DataType()");
        }
    }
}
