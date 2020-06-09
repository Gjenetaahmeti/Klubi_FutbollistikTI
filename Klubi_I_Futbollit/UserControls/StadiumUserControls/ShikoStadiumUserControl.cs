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

namespace Klubi_I_Futbollit.UserControls.StadiumUserControls
{
    public partial class ShikoStadiumUserControl : UserControl
    {
        public ShikoStadiumUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radGridView1.Visible = true;
            StadiumiBLL obj = new StadiumiBLL();
            radGridView1.DataSource = obj.ShfaqListenEStadiumeve();
        }
    }
}
