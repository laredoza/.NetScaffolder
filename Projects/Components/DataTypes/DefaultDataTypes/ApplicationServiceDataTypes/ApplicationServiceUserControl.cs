using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes
{
    using DotNetScaffolder.Components.Common.Contract;
    public partial class ApplicationServiceUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        public ApplicationServiceUserControl()
        {
            InitializeComponent();
        }

        public ApplicationServiceDataType DataType { get; set; }

        public void SaveConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null) return;

            DataType.Enabled = this.AppServiceEnabled.Checked;
            DataType.Namespace = this.AppServiceNamespace.Text;
            DataType.OutputFolder = this.AppServiceOutputFolder.Text;
            DataType.SaveConfig(parameters);
        }

        public void LoadConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null) return;

            DataType.LoadConfig(parameters);

            AppServiceEnabled.Checked = this.DataType.Enabled;
            AppServiceNamespace.Text = this.DataType.Namespace;
            AppServiceOutputFolder.Text = this.DataType.OutputFolder;
        }
    }
}
