// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFDriverType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EF6
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;

    #endregion

    /// <summary>
    ///     The ef driver type.
    /// </summary>
    [Export(typeof(IDriverType))]
    public class EFDriverType : IDriverType
    {
        public EFDriverType(string fileName)
        {
            this.FileName = fileName;
        }

        #region Public Properties
        
        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        protected readonly string FileName = string.Empty;

        /// <summary>
        /// The id.
        /// </summary>
        public Guid Id => new Guid("2BC1B0C4-1E41-9146-82CF-599181CE4410");

        /// <summary>
        /// The name.
        /// </summary>
        public string Name => "Entity Framework 6";

        /// <summary>
        ///     Gets or sets a value indicating whether create db.
        /// </summary>
        public bool CreateDb { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether lazy loading enabled.
        /// </summary>
        public bool LazyLoadingEnabled { get; set; }


        /// <summary>
        ///     Gets or sets a value indicating whether logging enabled.
        /// </summary>
        public bool LoggingEnabled { get; set; }


        /// <summary>
        ///     Gets or sets a value indicating whether proxy creation enabled.
        /// </summary>
        public bool ProxyCreationEnabled { get; set; }


        /// <summary>
        ///     Gets or sets a value indicating whether include column order.
        /// </summary>
        public bool IncludeColumnOrder { get; set; }
        public List<Validation> ValidationResult { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// The load config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void LoadConfig(object parameters)
        {
            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;

            var filePath = Path.Combine(parameterList["basePath"], this.FileName);

            if (File.Exists(filePath))
            {
                var driverType = ObjectXMLSerializer<EFDriverType>.Load(filePath);
                if (driverType != null)
                {
                    //this.Namespace = dto.Namespace;
                    //this.OutputFolder = dto.OutputFolder;
                    //this.OutputPath = dto.OutputPath;
                    //this.InheritFrom = dto.InheritFrom;
                    //this.UseInterface = dto.UseInterface;
                    //this.AddInjectConstructor = dto.AddInjectConstructor;
                }
            }
        }

        /// <summary>
        /// The save config.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public bool SaveConfig(object parameters)
        {
            IDictionary<string, string> parameterList = parameters as IDictionary<string, string>;
            var filePath = Path.Combine(parameterList["basePath"], this.FileName);
            ObjectXMLSerializer<EFDriverType>.Save(this, filePath);
            return true;
        }

        public List<Validation> Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}