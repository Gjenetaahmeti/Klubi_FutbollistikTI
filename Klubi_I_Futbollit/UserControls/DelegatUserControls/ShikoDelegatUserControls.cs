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

namespace Klubi_I_Futbollit.UserControls.DelegatUserControls
{
    public partial class ShikoDelegatUserControls : UserControl
    {
        public ShikoDelegatUserControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radGridView1.Visible = true;
            DelegatBLL obj = new DelegatBLL();
            radGridView1.DataSource = obj.ShfaqListenEDelegateve();
        }   
    }
}
