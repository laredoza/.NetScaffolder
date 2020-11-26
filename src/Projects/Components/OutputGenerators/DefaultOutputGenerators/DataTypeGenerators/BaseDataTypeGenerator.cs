// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseDataTypeGenerator.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Mapping.MetaData.Domain;
using HandlebarsDotNet;
using System.Collections.Generic;
using System.IO;
using System;
using DotNetScaffolder.Components.Common;

namespace DotNetScaffolder.Components.OutputGenerators.DefaultOutputGenerators
{
    #region Usings
    #endregion

    /// <summary>
    /// The Base Data Type Generator.
    /// </summary>
    public class BaseDataTypeGenerator : IDataTypeGenerator
    {
        protected void PrepareTemplateData(IDataType dataType, DomainDefinition domain)
        {
            foreach (var model in domain.Tables)
            {
                // var entityDataType = (dataType as EntityDataType);
                foreach (var relationship in model.DistinctChildRelationshipsWithManyManyMultiplicity)
                {
                    relationship.ChildRelationshipNameWithNamingConvention = RelationshipNameFormatting.FormatName(relationship.ReferencedTableName, relationship.RelationshipAlias, dataType.NamingConvention);
                    relationship.ChildReferencedTableNameWithNamingConvention = dataType.NamingConvention.ApplyNamingConvention(relationship.ReferencedTableName);
                }
                foreach (var relationship in model.DistinctChildRelationshipsWithoutManyMultiplicity)
                {
                    relationship.ChildRelationshipNameWithNamingConvention = RelationshipNameFormatting.FormatName(relationship.ReferencedTableName, relationship.RelationshipAlias, dataType.NamingConvention);
                    relationship.ChildReferencedTableNameWithNamingConvention = dataType.NamingConvention.ApplyNamingConvention(relationship.ReferencedTableName);
                }

                foreach (var relationship in model.DistinctParentRelationships)
                {
                    relationship.ParentRelationshipNameWithNamingConvention = RelationshipNameFormatting.FormatName(relationship.ReferencedTableName, relationship.RelationshipAlias, dataType.NamingConvention);
                    relationship.ParentReferencedTableNameWithNamingConvention = dataType.NamingConvention.ApplyNamingConvention(relationship.ReferencedTableName);
                }
                dataType.MetaData = model;

                if (dataType.MetaData.PrimaryKeyColumns != null && dataType.MetaData.PrimaryKeyColumns.Count > 0)
                {
                    dataType.MetaData.PrimaryKeyColumns[0].IsFirstPrimaryKeyColumn = true;
                }
            }
        }
        public virtual void Run(IDataType dataType, DomainDefinition domain, List<IDataType> dataTypes, string modelFilePath)
        {
            throw new NotImplementedException();
        }
        public virtual bool UsedForDataType(IDataType dataType)
        {
            throw new NotImplementedException();
        }
        protected void RenderToFile(string fileContent, string outputPath)
        {
            using (StreamWriter file = new StreamWriter(outputPath))
            {
                file.WriteLine(fileContent);
            }
        }
        protected string ReturnBasePath(string modelFilePath)
        {
            var path = Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(modelFilePath)));
            return path.Parent.FullName;
        }
        protected System.Func<object, string> RegisterTemplate(string modelFilePath, string templateName)
        {
            string source = File.ReadAllText($"{modelFilePath}/HandleBars/{templateName}");
            return Handlebars.Compile(source);
        }
    }
}