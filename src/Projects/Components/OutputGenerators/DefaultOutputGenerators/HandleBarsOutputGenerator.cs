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
            Handlebars.RegisterHelper("StringEqualityBlockHelper", (output, options, context, arguments) => 
            {
                if (arguments.Length != 2)
                {
                    throw new HandlebarsException("{{#StringEqualityBlockHelper}} helper must have exactly two arguments");
                }

                var left = arguments[0];
                var right = arguments[1] as string;
                if (left == right) options.Template(output, context);
                else options.Inverse(output, context);
            });

            Handlebars.RegisterHelper("BooleanOr", (output, options, context, arguments) => 
            {
                if (arguments.Length == 0)
                {
                    throw new HandlebarsException("{{#BooleanOr}} helper must have more than one argument");
                }

                bool result = false;
                bool value = false;

                for (int i = 0; i < arguments.Length; i++)
                {
                    value = (bool)arguments[i];

                    if (value)
                    {
                        result = true;
                        break;
                    }
                }

                if (result) 
                {
                    options.Template(output, context);
                }
                else {
                    options.Inverse(output, context);
                }
            });

            Handlebars.RegisterHelper("BooleanAnd", (output, options, context, arguments) => 
            {
                if (arguments.Length == 0)
                {
                    throw new HandlebarsException("{{#BooleanAnd}} helper must have more than one argument");
                }

                bool result = arguments.Length > 0;
                bool value = false;

                for (int i = 0; i < arguments.Length; i++)
                {
                    value = (bool)arguments[i];

                    if (!value)
                    {
                        result = false;
                        break;
                    }
                }

                if (result) 
                {
                    options.Template(output, context);
                }
                else {
                    options.Inverse(output, context);
                }
            });

            

            // Handlebars.RegisterHelper("eq", _stringEqualityBlockHelper);

            Handlebars.RegisterHelper("add_copyright", (writer, context, parameters) =>
            {
                string source = File.ReadAllText($"{Path.GetDirectoryName(modelFilePath)}/HandleBars/Helpers/CopyrightHeader.hbr");
                source = source.Replace("--Filename",context.FileName);
                source = source.Replace("--Year",context.Year.ToString());

                writer.WriteSafeString(source);
            });

            // Handlebars.RegisterHelper("add_copyright", (writer, context, parameters) =>
            // {
            //     string source = File.ReadAllText($"{Path.GetDirectoryName(modelFilePath)}/HandleBars/Helpers/CopyrightHeader.hbr");
            //     source = source.Replace("--Filename",context.FileName);
            //     source = source.Replace("--Year",context.Year.ToString());

            //     writer.WriteSafeString(source);
            // });

            Handlebars.RegisterHelper("add_copyright", (writer, context, parameters) =>
            {
                string source = File.ReadAllText($"{Path.GetDirectoryName(modelFilePath)}/HandleBars/Helpers/CopyrightHeader.hbr");
                source = source.Replace("--Filename",context.FileName);
                source = source.Replace("--Year",context.Year.ToString());

                writer.WriteSafeString(source);
            });



//             Handlebars.RegisterHelper({
//     eq: (v1, v2) => v1 === v2,
//     ne: (v1, v2) => v1 !== v2,
//     lt: (v1, v2) => v1 < v2,
//     gt: (v1, v2) => v1 > v2,
//     lte: (v1, v2) => v1 <= v2,
//     gte: (v1, v2) => v1 >= v2,
//     and() {
//         return Array.prototype.every.call(arguments, Boolean);
//     },
//     or() {
//         return Array.prototype.slice.call(arguments, 0, -1).some(Boolean);
//     }
// });


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