namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    using System;
    using System.Collections.Generic;

    public class LanguageOutput
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public static List<LanguageOutput> Load()
        {
            List<LanguageOutput> result = new List<LanguageOutput>();
            result.Add(new LanguageOutput { Id = Guid.NewGuid(), Name = "C#" });
            result.Add(new LanguageOutput { Id = Guid.NewGuid(), Name = "VB" });
            result.Add(new LanguageOutput { Id = Guid.NewGuid(), Name = "CSHTML" });
            return result;
        }
    }
}
