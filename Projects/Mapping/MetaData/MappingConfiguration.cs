using MetaData.Enum;
using MetaData.Model;
using MetaData.Project;
using MetaData.Project.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaData
{
    public class MappingConfiguration
    {
        public Guid Id { get; set; }
        public string OutputFolder { get; set; }
        public string BaseNamespace { get; set; }
        public GenerationType GenerationType { get; set; }
        public List<Project.Domain> Domains { get; set; }
        public List<Driver> Drivers { get; set; }
        public Packages Packages { get; set; }
        public List<DataType> DataTypes { get; set; }
        public List<LanguageOutput> LanguageOutputs { get; set; }
        public List<TemplateGeneratorType> TemplateGenerationTypes { get; set; }
        public DatabaseModel Model { get; set; }

        public MappingConfiguration()
        {
            this.Domains = new List<Project.Domain>();
            this.Drivers = Driver.Load(Id);
            this.Packages = new Packages();
            this.Packages.Load();
            this.DataTypes = DataType.Load();
            this.LanguageOutputs = LanguageOutput.Load();
        }

    }
}
