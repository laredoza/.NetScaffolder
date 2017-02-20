﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetScaffolder.Mapping.MetaData.Enum;
using DotNetScaffolder.Mapping.MetaData.Project.Packages;
using Common.Logging;
using System.Xml.Serialization;
using DotNetScaffolder.Core.Common.Validation;

namespace DotNetScaffolder.Mapping.MetaData.Application
{
    public class ApplicationSettings : IValidate
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        public List<Template> Templates { get; set; }

        public List<DataType> DataTypes { get; set; }

        /// <summary>
        /// Gets or sets the validation result.
        /// </summary>
        [XmlIgnore]
        public List<Validation> ValidationResult { get; set; }

        public List<Validation> Validate()
        {
            Logger.Trace("Started Validate()");
            this.ValidationResult.Clear();

            foreach (var dataType in this.DataTypes)
            {
                dataType.Validate();

                foreach (var tempResult in dataType.ValidationResult)
                {
                    this.ValidationResult.Add(tempResult);
                }
            }

            foreach (var template in this.Templates)
            {
                template.Validate();

                foreach (var validationResult in template.ValidationResult)
                {
                    this.ValidationResult.Add(validationResult);
                }
            }

            Logger.Trace("Completed Validate()");
            return this.ValidationResult;
        }

        public ApplicationSettings()
        {
            Logger.Trace("Started ApplicationSettings()");
            this.Templates = new List<Template>();
            this.ValidationResult = new List<Validation>();
            this.DataTypes = new List<DataType>();
            Logger.Trace("Completed ApplicationSettings()");
        }
    }
}