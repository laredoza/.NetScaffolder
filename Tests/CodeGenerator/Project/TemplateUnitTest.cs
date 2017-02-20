using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetScaffolder.Mapping.MetaData.Project.Packages;

namespace DotNetScaffolder.Test.Project.Packages
{
    /// <summary>
    /// Summary description for TemplateUnitTest
    /// </summary>
    [TestClass]
    public class TemplateUnitTest
    {
        [TestMethod]
        public void TemplateUnitTest_Test()
        {
            Template template = new Template();
            template.Validate();

            Assert.IsNotNull(template.ValidationResult, "ValidationResult should not be null");
            Assert.AreEqual(8, template.ValidationResult.Count, "There should be 6 validation results");

            template.Id = Guid.NewGuid();
            template.Name = "Template Name";
            template.TemplatePath = "test.t4";
            template.Version = 1; 
            //comment
            template.DataType.Id = Guid.NewGuid();
            template.DataType.Name = "Data type 1";
            template.GeneratorTypeId = Guid.NewGuid();
            template.LanguageOutputId = Guid.NewGuid();

            template.Validate();
            Assert.AreEqual(0, template.ValidationResult.Count, "There should be 0 validation results");
        }
    }
}
