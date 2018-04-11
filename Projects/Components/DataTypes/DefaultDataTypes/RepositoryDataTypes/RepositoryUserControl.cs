using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.RepositoryDataTypes
{
    using DotNetScaffolder.Components.Common.Contract;

    public partial class RepositoryUserControl : UserControl, IDataTypeUI<IDictionary<string, string>>
    {
        public RepositoryUserControl()
        {
            InitializeComponent();
        }

        public RepositoryDataType DataType { get; set; }

        public void SaveConfig(IDictionary<string, string> parameters)
        {
            DataType?.SaveConfig(parameters);
        }

        public void LoadConfig(IDictionary<string, string> parameters)
        {
            DataType?.LoadConfig(parameters);
        }
    }
}
