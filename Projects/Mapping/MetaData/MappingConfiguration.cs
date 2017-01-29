namespace DotNetScaffolder.Mapping.MetaData
{
    using System;
    using System.Collections.Generic;

    using DotNetScaffolder.Mapping.MetaData.Domain;
    using DotNetScaffolder.Mapping.MetaData.Enum;
    using DotNetScaffolder.Mapping.MetaData.Model;
    using DotNetScaffolder.Mapping.MetaData.Project;
    using DotNetScaffolder.Mapping.MetaData.Project.Packages;

    public class MappingConfiguration
    {
        public Guid Id { get; set; }
        public string OutputFolder { get; set; }
        public string BaseNamespace { get; set; }
        public GenerationType GenerationType { get; set; }
        public List<DomainDefinition> Domains { get; set; }
        //public List<Driver> Drivers { get; set; }
        public Packages Packages { get; set; }
        public List<DataType> DataTypes { get; set; }
        public List<LanguageOutput> LanguageOutputs { get; set; }
        public List<TemplateGeneratorType> TemplateGenerationTypes { get; set; }
        public DatabaseModel Model { get; set; }

        public MappingConfiguration()
        {
            this.Domains = new List<DomainDefinition>();
            //this.Drivers = Driver.Load(this.Id);
            this.Packages = new Packages();
            this.Packages.Load();
            this.DataTypes = DataType.Load();
            this.LanguageOutputs = LanguageOutput.Load();
        }

    }
}
