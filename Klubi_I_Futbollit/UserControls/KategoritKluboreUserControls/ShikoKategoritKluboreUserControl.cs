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

namespace Klubi_I_Futbollit.UserControls.KategoritKluboreUserControls
{
    public partial class ShikoKategoritKluboreUserControl : UserControl
    {
        public ShikoKategoritKluboreUserControl()
        {
            InitializeComponent();
        }

        private void ShikoKategoritKluboreUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            KategoriteKluboreBLL obj = new KategoriteKluboreBLL();
            dataGridView1.DataSource = obj.ShfaqListenEKategorivee();
        }
    }
}
