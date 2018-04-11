using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes
{
    public interface IDefaultDataSourceUI
    {
        Object Parameters { get; set; }
        void Load();
        void Save();
    }
}
