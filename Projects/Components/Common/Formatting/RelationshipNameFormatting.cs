using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Mapping.MetaData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.Common
{
    public static class RelationshipNameFormatting
    {
        public static string FormatReferencedPropertyName(Relationship rel, INamingConvention nc = null, IEnumerable<Relationship> relationships = null)
        {
            return FormatName(rel.ReferencedTableName, rel.RelationshipAlias, rel.ReferencedColumnName, nc, relationships);
        }

        public static string FormatParentPropertyName(Relationship rel, INamingConvention nc = null, IEnumerable<Relationship> relationships = null)
        {
            return FormatName(rel.ReferencedTableName, rel.RelationshipAlias, rel.ColumnName, nc, relationships);
        }

        public static string FormatName(string tableName, string alias, string colName, INamingConvention nc = null, IEnumerable<Relationship> relationships = null)
        {
            string formattedName = string.IsNullOrEmpty(alias) ? tableName : alias;

            if (relationships != null && relationships.Count(o => o.ReferencedTableName == formattedName) > 1)
            {
                formattedName = $"{formattedName}_{colName}";
            }

            return nc != null ? nc.ApplyNamingConvention(formattedName) : formattedName;
        }
    }
}
