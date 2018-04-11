using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.Common.Contract
{
    public interface IDataTypeUI<in T, DT>
    {
        DT DataType { get; set; }

        void SaveConfig(T parameters);

        void LoadConfig(T parameters);
    }
}
