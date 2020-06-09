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

namespace Klubi_I_Futbollit.UserControls.NdeshjetUserControls
{
    public partial class ShikoNdeshjeUserControl : UserControl
    {
        public ShikoNdeshjeUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radGridView1.Visible = true;
            NdeshjaBLL obj = new NdeshjaBLL();
            radGridView1.DataSource = obj.ShfaqListenENdeshjeve();
        }
    }
}
