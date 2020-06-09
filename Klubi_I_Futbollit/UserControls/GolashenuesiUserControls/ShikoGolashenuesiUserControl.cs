using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_I_Futbollit.BLL;

namespace Klubi_I_Futbollit.UserControls.GolashenuesiUserControls
{
    public partial class ShikoGolashenuesiUserControl : UserControl
    {
        public ShikoGolashenuesiUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radGridView1.Visible = true;
            GolashenuesiBLL obj = new GolashenuesiBLL();
            radGridView1.DataSource = obj.ShfaqListenEGolaShenuesve();
        }
    }
}
