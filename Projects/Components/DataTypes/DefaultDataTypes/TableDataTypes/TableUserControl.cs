using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.TableDataTypes
{
    using DotNetScaffolder.Components.Common.Contract;

    public partial class TableUserControl : UserControl, IDataTypeUI<IDictionary<string, string>, TableDataType>
    {
        public TableUserControl()
        {
            InitializeComponent();
        }

        public TableDataType DataType { get; set; }

        public void SaveConfig(IDictionary<string, string> parameters)
        {
        }

        public void LoadConfig(IDictionary<string, string> parameters)
        {
        }
    }
}
