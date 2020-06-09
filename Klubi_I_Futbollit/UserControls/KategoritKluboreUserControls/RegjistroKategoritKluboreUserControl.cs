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
using Klubi_I_Futbollit.BLL;

namespace Klubi_I_Futbollit.UserControls.KategoritKluboreUserControls
{
    public partial class RegjistroKategoritKluboreUserControl : UserControl
    {
        public RegjistroKategoritKluboreUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmertimi.Text == " " || txtDeri.Text == "" || txtPrej.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                KategoriteKlubore kategorit = new KategoriteKlubore();
                kategorit.Emertimi = txtEmertimi.Text.Trim();
                kategorit.Deri = int.Parse(txtDeri.Text.Trim());
                kategorit.Prej = int.Parse(txtPrej.Text.Trim());

                KategoriteKluboreBLL kategoria = new KategoriteKluboreBLL();
                kategoria.Regjistro(kategorit);

                txtEmertimi.Text = txtDeri.Text = txtPrej.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
    }
}
