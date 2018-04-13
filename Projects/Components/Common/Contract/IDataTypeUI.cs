using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.Common.Contract
{
    using FormControls.TreeView;

    public interface IDataTypeUI<T>
    {
        void SaveConfig(T parameters);

        void LoadConfig(T parameters);

        event EventHandler<IDataType<T>> OnNavigationChanged;
    }
}
