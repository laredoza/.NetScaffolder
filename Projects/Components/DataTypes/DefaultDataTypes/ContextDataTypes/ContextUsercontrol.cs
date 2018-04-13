using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes
{
    using DotNetScaffolder.Components.Common.Contract;
    public partial class ContextUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        public ContextDataType DataType { get; set; }

        public void SaveConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null) return;

            DataType.OutputFolder = OutputFolder.Text;
            DataType.Enabled = ContextEnabled.Checked;
            DataType.Namespace = Namespace.Text;
            DataType.ContextName = ContextName.Text;
            DataType.CreateDb = CreateDb.Checked;
            DataType.GenerateInterface = GenerateInterface.Checked;
            DataType.InheritFrom = InheritFromInterface.Text;
            DataType.LoggingEnabled = LoggingEnabled.Checked;
            DataType.ConstructionOptions = ConstructionOptions.SelectedText;
            DataType.SaveConfig(parameters);
        }

        public void LoadConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null) return;

            OutputFolder.Text = DataType.OutputFolder;
            ContextEnabled.Checked = DataType.Enabled;
            Namespace.Text = DataType.Namespace;
            ContextName.Text = DataType.ContextName;
            CreateDb.Checked = DataType.CreateDb;
            GenerateInterface.Checked = DataType.GenerateInterface;
            InheritFromInterface.Text = DataType.InheritFrom;
            LoggingEnabled.Checked = DataType.LoggingEnabled;
            ConstructionOptions.SelectedText = DataType.ConstructionOptions;
            DataType?.LoadConfig(parameters);
        }

        public ContextUserControl()
        {
            InitializeComponent();
        }
    }
}
