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

    public interface IDataType<T>
    {
        IHierarchy ReturnNavigation();

        IDataTypeUI<T> CreateUI(T parameters);
        IDataTypeUI<T> CreateUI();

        bool Save(T parameters);

        void Load(T parameters);

        Table MetaData { get; set; }
    }

    public interface IDataType : IDataType<IDictionary<string,string>>
    {
    }
}
