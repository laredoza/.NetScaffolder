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
        public static string FormatName(string tableName, string alias, INamingConvention nc = null, IEnumerable<string> names = null)
        {
            string formattedName = string.IsNullOrEmpty(alias) ? tableName : alias;

            if (names != null)
            {
                int index = 1;
                int checkCount = 1;
                string updatedName = formattedName;

                while (names.Count(o => o == updatedName) > checkCount)
                {
                    updatedName = $"{formattedName}{index}";
                    index++;
                    checkCount = 0;
                }

                formattedName = updatedName;
            }

            return nc != null ? nc.ApplyNamingConvention(formattedName) : formattedName;
        }
    }
}
