using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    using System.Data.Entity;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var context = new SellRightContext())
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<SellRightContext>());
                context.Database.Initialize(true);
            }
        }
    }
}
