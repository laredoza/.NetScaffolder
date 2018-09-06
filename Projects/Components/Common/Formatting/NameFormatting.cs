using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.Common.Formatting
{
    using System.Security.Cryptography.X509Certificates;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Model;

    public static class NameFormatting
    {
        public static string TransformCompositeKeys(IEnumerable<Column> pks, string prefix, INamingConvention nc = null)
        {
            string mapping = string.Empty;

            foreach (var col in pks)
            {
                mapping = $"{mapping}{prefix}.{FormatName(col.ColumnName, nc)}, ";
            }

            return mapping.TrimEnd(' ').TrimEnd(',');
        }

        public static string FormatName(string name, INamingConvention nc = null)
        {
            return nc != null ? nc.ApplyNamingConvention(name) : name;
        }
    }
}
