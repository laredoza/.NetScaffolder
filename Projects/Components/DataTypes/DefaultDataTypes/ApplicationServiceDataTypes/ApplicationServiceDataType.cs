using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using FormControls.TreeView;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    using System.IO;

    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Project;

    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Application Service")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4420")]

    public class ApplicationServiceDataType : IDataType
    {
        public string Namespace { get; set; } = "ApplicationService";

        public string OutputFolder { get; set; } = "Application Service";

        public bool Enabled { get; set; } = false;

        private string filePath = string.Empty;

        public ApplicationServiceDataType()
        {

        }

        public object AddConfigUI(object parameters)
        {
            Control parent = parameters as Control;
            ApplicationServiceUserControl newControl = new ApplicationServiceUserControl
                                                           {
                                                               AppServiceEnabled = { Checked = this.Enabled },
                                                               AppServiceNamespace = { Text = this.Namespace },
                                                               AppServiceOutputFolder = { Text = this.OutputFolder },
                                                               Visible = true,
                                                               Dock = DockStyle.Fill
                                                           };
            newControl.BringToFront();
            parent.Controls.Add(newControl);
            return newControl;
        }

        public bool SaveConfig()
        {
            ObjectXMLSerializer<ApplicationServiceDataType>.Save(this, filePath);
            return true;
        }

        public void LoadConfig(string basePath)
        {
            filePath = Path.Combine(basePath, "ApplicationServiceDataType.mdl");
            if (File.Exists(filePath))
            {
                var appService = ObjectXMLSerializer<ApplicationServiceDataType>.Load(filePath);
                if (appService != null)
                {
                }
            }
        }

        public IHierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4420"), Name = "Application Service" };
        }
    }
}
