// --------------------------------------------------------------------------------------------------------------------
// <copyright file="T4OutputGenerator.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.IO;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Configuration;
    using DotNetScaffolder.Mapping.ApplicationServices;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Project;

    #endregion
    public abstract class BaseOutputGenerator : IOutputGenerator
    {
        public virtual void Generate(string packagePath, string modelFilePath) {
            FilePersistenceOptions options = new FilePersistenceOptions { Path = modelFilePath };
            var applicationService =
                new ProjectDefinitionApplicationServiceFile { FilePersistenceOptions = options };
            applicationService.Load(packagePath);
		
            var projectDefinition = applicationService.ProjectDefinition;
		
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("basePath", Path.GetDirectoryName(modelFilePath));
		    List<IDriver> drivers = new List<IDriver>();

            foreach(var domain in projectDefinition.Domains)
            {
                if(domain.Package == null) continue;
			
                var nc = ScaffoldConfig.ReturnNamingConvention(domain.NamingConventionId);
                var co = ScaffoldConfig.ReturnCollectionOption(domain.CollectionOptionId);

                var dataTypes = new List<IDataType>();
                drivers = new List<IDriver>();
                foreach( Guid driverTypeTypeId in domain.DriverIdList)
                {
					var drvr = ScaffoldConfig.ReturnDriver(driverTypeTypeId);
					drvr.DriverType.LoadConfig(parameters);
                    drivers.Add(drvr);
                }

                // Setup data types for template
                foreach(var template in domain.Package.Templates)
                {
                    if(template.Enabled)
                    {
                        var dt = ScaffoldConfig.ReturnDataType(template.DataType);
                        dt.DomainDefinition = domain;
                        dt.Load(parameters);
                        dt.NamingConvention = nc;
                        dt.CollectionOption = co;
			            dt.BaseNamespace = projectDefinition.BaseNameSpace;
                        dt.Drivers = drivers;
                        dataTypes.Add(dt);
                    }
                }
			
                ExecuteGenerators(dataTypes, domain);
            }

        }
        protected abstract void ExecuteGenerators(List<IDataType> dataTypes, DomainDefinition domain);
    }
}