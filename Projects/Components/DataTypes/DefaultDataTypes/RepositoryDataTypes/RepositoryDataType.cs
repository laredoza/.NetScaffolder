using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using FormControls.TreeView;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.RepositoryDataTypes;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    using System.IO;

    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Model;

    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Repository")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4450")]
    public class RepositoryDataType : IDataType
    {
        public string Namespace { get; set; } = "Repository";

        public string OutputFolder { get; set; } = "Repository";

        public bool Enabled { get; set; } = false;

        private const string FILE_NAME = "Repository.mdl";

        public RepositoryDataType()
        {

        }

        public IHierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4450"), Name = "Repository" };
        }

        public IDataTypeUI<IDictionary<string, string>> CreateUI(IDictionary<string, string> parameters)
        {
            RepositoryUserControl newControl = new RepositoryUserControl
                                                   {
                                                       Visible = true,
                                                       Dock = DockStyle.Fill,
                                                       DataType = this
                                                   };
            return newControl;
        }

        public IDataTypeUI<IDictionary<string, string>> CreateUI()
        {
            return this.CreateUI(null);
        }

        public bool Save(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);
            ObjectXMLSerializer<RepositoryDataType>.Save(this, filePath);
            return true;
        }

        public void Load(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);

            if (File.Exists(filePath))
            {
                var appService = ObjectXMLSerializer<RepositoryDataType>.Load(filePath);
                if (appService != null)
                {
                }
            }
        }

        public Table MetaData { get; set; }
    }
}
