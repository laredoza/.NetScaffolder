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
        public static string FormatReferencedPropertyName(Relationship rel, INamingConvention nc = null, List<Relationship> relationships = null)
        {
            string formattedName = string.IsNullOrEmpty(rel.RelationshipAlias) ? rel.ReferencedTableName : rel.RelationshipAlias;

            if(relationships != null && relationships.Count(o=> o.ReferencedTableName == formattedName) > 1)
            {
                formattedName = $"{formattedName}_{rel.ColumnName}";
            }

            return nc != null ? nc.ApplyNamingConvention(formattedName) : formattedName;
        }
    }
}
