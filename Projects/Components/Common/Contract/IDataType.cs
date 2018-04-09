using FormControls.TreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.Common.Contract
{
    using System.Net.Configuration;

    public interface IDataType
    {
        IHierarchy ReturnNavigation();

        object AddConfigUI(object parameters);

        bool SaveConfig();

        void LoadConfig(string basePath);
    }
}
