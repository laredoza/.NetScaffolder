// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HandleBarsOutputGenerator.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings

    using System.ComponentModel.Composition;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Domain;
    using System;
    using System.Collections.Generic;
    using DotNetScaffolder.Core.Configuration;
    using HandlebarsDotNet;
    using System.IO;
    using DotNetScaffolder.Mapping.ApplicationServices;

    #endregion

    /// <summary>
    /// The t4 output generator.
    /// </summary>
    [Export(typeof(IOutputGenerator))]
    [ExportMetadata("NameMetaData", "HandleBars")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4413")]
    public class HandleBarsOutputGenerator : BaseOutputGenerator
    {
        protected override void ExecuteGenerators(List<IDataType> dataTypes, DomainDefinition domain, string modelFilePath)
        {
            // Execute generation using initialised data types

            this.RegisterHelpers(modelFilePath);

            foreach (var dataType in dataTypes)
            {
                var dataTypeGenerator = this.ReturnDataTypeGenerator(dataType);
                if (dataTypeGenerator != null)
                {
                    dataTypeGenerator.Run(dataType, domain, dataTypes, modelFilePath);
                }
            }
        }
        private IDataTypeGenerator ReturnDataTypeGenerator(IDataType dataType)
        {
            IDataTypeGenerator result = null;
            foreach (var dataGenerator in ScaffoldConfig.DataTypeGenerators)
            {
                result = dataGenerator.Value;

                if (result.UsedForDataType(dataType))
                {
                    return result;
                }
            }

            return null;
        }

        private void RegisterHelpers(string modelFilePath)
        {
            // HandlebarsBlockHelper _stringEqualityBlockHelper = (TextWriter output, HelperOptions options, dynamic context, object[] arguments) =>
            // {
            //     if (arguments.Length != 2)
            //     {
            //         throw new HandlebarsException("{{StringEqualityBlockHelper}} helper must have exactly two argument");
            //     }
            //     string left = arguments[0] as string;
            //     string right = arguments[1] as string;
            //     if (left == right)
            //     {
            //         options.Template(output, null);
            //     }
            //     else
            //     {
            //         options.Inverse(output, null);
            //     }
            // };

            // Handlebars.RegisterHelper("eq", _stringEqualityBlockHelper);

            Handlebars.RegisterHelper("add_copyright", (writer, context, parameters) =>
            {
                string source = File.ReadAllText($"{Path.GetDirectoryName(modelFilePath)}/HandleBars/Helpers/CopyrightHeader.hbr");
                source = source.Replace("--Filename",context.FileName);
                source = source.Replace("--Year",context.Year.ToString());

                writer.WriteSafeString(source);
            });

            // string source = @"Click here: {{link_to}}";

            // var template = Handlebars.Compile(source);

            // var data = new
            // {
            //     url = "https://github.com/rexm/handlebars.net",
            //     text = "Handlebars.Net"
            // };

            // var result = template(data);

        }

    }
}