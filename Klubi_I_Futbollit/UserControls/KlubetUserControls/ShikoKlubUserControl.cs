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

namespace Klubi_I_Futbollit.UserControls.KlubetUserControls
{
    public partial class ShikoKlubUserControl : UserControl
    {
        public ShikoKlubUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            KlubiBLL obj = new KlubiBLL();
            dataGridView1.DataSource = obj.ShfaqListenEKlubeve();
        }
    }
}
