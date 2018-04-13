using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract.UI;

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.Edmxs
{
    public partial class EdmxUserControl : UserControl, IDefaultDataSourceUI
    {
        public EdmxUserControl()
        {
            InitializeComponent();
        }

        public object Parameters { get; set; }

        public void LoadData()
        {
            throw new NotImplementedException();
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
