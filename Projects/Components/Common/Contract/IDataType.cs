using FormControls.TreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.Common.Contract
{
    using System.Net.Configuration;

    using DotNetScaffolder.Mapping.MetaData.Model;

    public interface IDataType<in T>
    {
        IHierarchy ReturnNavigation();

        IDataTypeUI<T, DT> AddConfigUI<DT>(object parameters);

        bool SaveConfig(T parameters);

        void LoadConfig(T parameters);

        Table MetaData { get; set; }
    }

    public interface IDataType : IDataType<IDictionary<string,string>>
    {
    }
}
