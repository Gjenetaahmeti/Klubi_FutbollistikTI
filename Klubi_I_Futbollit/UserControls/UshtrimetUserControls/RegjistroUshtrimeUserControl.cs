using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_I_Futbollit.BO;
using Klubi_;

namespace Klubi_I_Futbollit.UserControls.UshtrimetUserControls
{
    public partial class RegjistroUshtrimeUserControl : UserControl
    {
        public RegjistroUshtrimeUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDita.Text == " " || txtOra.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                Ushtrimet ushtrimet = new Ushtrimet();
                ushtrimet.Dita = txtDita.Text.Trim();
                ushtrimet.Ora = txtOra.Text.Trim();
                UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
                ushtrimetDAL.Shto(ushtrimet);
                txtDita.Text = txtOra.Text = "";
                MessageBox.Show("U regjistrua me sukses");
            }
        }
    }
}
