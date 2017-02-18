namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    using System;
    using System.Collections.Generic;

    using DotNetScaffolder.Mapping.MetaData.Enum;

    public class Template
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public string TemplatePath { get; set; }
        public DataType DataType { get; set; }
        public ConfigLocation ConfigLocation { get; set; }
        public double Version { get; set; }
        public LanguageOutput LanguageOutput { get; set; }
        public TemplateGeneratorType GeneratorType { get; set; }
        public List<string> DefaultSettings { get; set; }

        public Template()
        {
            this.Enabled = false;
        }
    }
}
