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

namespace Klubi_I_Futbollit.UserControls.RaporteUserControls
{
    public partial class ShikoRaporteUserControl : UserControl
    {
        public ShikoRaporteUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            RaportiBLL obj = new RaportiBLL();
            dataGridView1.DataSource = obj.ShfaqListenERaporteve();
        }
    }
}
