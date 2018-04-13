using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using FormControls.TreeView;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    using System.IO;

    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Model;

    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Context")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4430")]
    public class ContextDataType : IDataType
    {
        public List<ContextData> Contexts { get; private set; }

        private const string FILE_NAME = "Context.mdl";

        public ContextDataType()
        {
            Contexts = new List<ContextData>();
        }

        public IHierarchy ReturnNavigation()
        {
            var parent = new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4430"), Name = "Context" };

            if (Contexts.Any())
            {
                foreach (var context in this.Contexts)
                {
                    parent.Children.Add(new Hierarchy
                                            {
                                                ParentId = parent.Id,
                                                Id = context.Id,
                                                Name = context.ContextName
                                            });
                }
            }

            return parent;
        }

        public IDataTypeUI<IDictionary<string, string>> CreateUI(IDictionary<string,string> parameters)
        {
            var newControl = new ContextUserControl
                                 {
                                     Visible = true,
                                     Dock = DockStyle.Fill,
                                     DataType = this
                                 };
            return newControl;
        }

        public IDataTypeUI<IDictionary<string, string>> CreateUI()
        {
            return CreateUI(null);
        }

        public bool Save(IDictionary<string, string> parameters)
        {
            if (parameters == null) return false;

            if (!parameters.ContainsKey("basePath"))
            {
                return false;
            }

            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);
            ObjectXMLSerializer<List<ContextData>>.Save(this.Contexts, filePath);
            return true;
        }

        public void Load(IDictionary<string, string> parameters)
        {
            if (parameters == null) return;

            if (!parameters.ContainsKey("basePath"))
            {
                return;
            }

            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);

            if (File.Exists(filePath))
            {
                Contexts = ObjectXMLSerializer<List<ContextData>>.Load(filePath);
            }
        }

        public Table MetaData { get; set; }
    }

    public class ContextData
    {
        public Guid Id { get; set; }

        public string Namespace { get; set; } = "Context";

        public string OutputFolder { get; set; } = "Context";

        public bool Enabled { get; set; } = false;

        public string ContextName { get; set; } = "Context";

        public string InheritFrom { get; set; }

        public bool CreateDb { get; set; }

        public bool GenerateInterface { get; set; }

        public bool LoggingEnabled { get; set; }

        public string ConstructionOptions { get; set; }
    }
}
