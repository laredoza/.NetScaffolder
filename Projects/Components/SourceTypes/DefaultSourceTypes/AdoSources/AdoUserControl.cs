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

namespace DotNetScaffolder.Components.SourceTypes.DefaultSourceTypes.AdoSources
{
    public partial class AdoUserControl : UserControl, IDefaultDataSourceUI
    {
        public AdoUserControl()
        {
            InitializeComponent();
        }

        public object Parameters { get; set; }

        public void SaveData()
        {
            throw new NotImplementedException();
        }

        void LoadData()
        {
            throw new NotImplementedException();
        }

        void IDefaultDataSourceUI.LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
