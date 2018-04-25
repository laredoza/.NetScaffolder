using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Mapping.MetaData.Model;
using FormControls.TreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    public abstract class BaseDataType : IDataType
    {
        protected BaseDataType(string fileName) => FileName = fileName;

        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        protected readonly string FileName = string.Empty;

        public Table MetaData { get; set; }

        public abstract IDataTypeUI<IDictionary<string, string>> CreateUI(IDictionary<string, string> parameters);

        public abstract IDataTypeUI<IDictionary<string, string>> CreateUI();

        public abstract void Load(IDictionary<string, string> parameters);

        public abstract Hierarchy ReturnNavigation();

        public abstract bool Save(IDictionary<string, string> parameters);

        [XmlIgnore]
        public string BaseNamespace { get; set; }

        [XmlIgnore]
        public INamingConvention NamingConvention { get; set; }

        [XmlIgnore]
        public ISourceType SourceType { get; set; }

        [XmlIgnore]
        public ICollectionOption CollectionOption { get; set; }
    }
}
