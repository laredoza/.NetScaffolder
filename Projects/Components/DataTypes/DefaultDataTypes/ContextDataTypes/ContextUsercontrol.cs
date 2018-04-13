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

    using FormControls.TreeView;

    public partial class ContextUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        public ContextDataType DataType { get; set; }

        public ContextData SelectedContext { get; set; }

        public void SaveConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null || SelectedContext == null) return;

            SelectedContext = DataType.Contexts.First(o => o.Id == SelectedContext.Id);

            UpdateContext();

            DataType.Save(parameters);
        }

        public void LoadConfig(IDictionary<string, string> parameters)
        {
            if (DataType == null) return;

            DataType?.Load(parameters);

            if (parameters.ContainsKey("name"))
            {
                SelectedContext = DataType.Contexts.FirstOrDefault(o => o.Id.ToString() == parameters["name"]);
            }

            btnNew.Visible = SelectedContext == null;

            if (SelectedContext == null)
            {
                SetupDefault();
            }

            UpdateUI();
        }

        private void SetupDefault()
        {
            SelectedContext = new ContextData
                                  {
                                      Id = Guid.NewGuid()
                                  };
        }

        public event EventHandler<IDataType<IDictionary<string, string>>> OnNavigationChanged;

        public ContextUserControl()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UpdateContext();
            DataType.Contexts.Add(SelectedContext);

            OnNavigationChanged?.Invoke(this, DataType);
            SetupDefault();
            UpdateUI();
        }

        private void UpdateContext()
        {
            SelectedContext.OutputFolder = OutputFolder.Text;
            SelectedContext.Enabled = ContextEnabled.Checked;
            SelectedContext.Namespace = Namespace.Text;
            SelectedContext.ContextName = ContextName.Text;
            SelectedContext.CreateDb = CreateDb.Checked;
            SelectedContext.GenerateInterface = GenerateInterface.Checked;
            SelectedContext.InheritFrom = InheritFromInterface.Text;
            SelectedContext.LoggingEnabled = LoggingEnabled.Checked;
            SelectedContext.ConstructionOptions = ConstructionOptions.SelectedText;
        }

        private void UpdateUI()
        {
            OutputFolder.Text = SelectedContext.OutputFolder;
            ContextEnabled.Checked = SelectedContext.Enabled;
            Namespace.Text = SelectedContext.Namespace;
            ContextName.Text = SelectedContext.ContextName;
            CreateDb.Checked = SelectedContext.CreateDb;
            GenerateInterface.Checked = SelectedContext.GenerateInterface;
            InheritFromInterface.Text = SelectedContext.InheritFrom;
            LoggingEnabled.Checked = SelectedContext.LoggingEnabled;
            ConstructionOptions.SelectedText = SelectedContext.ConstructionOptions;
        }
    }
}
