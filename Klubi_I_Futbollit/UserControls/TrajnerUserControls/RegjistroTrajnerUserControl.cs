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

namespace Klubi_I_Futbollit.UserControls.TrajnerUserControls
{
    public partial class RegjistroTrajnerUserControl : UserControl
    {
        public RegjistroTrajnerUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtEmriPerdoruesit.Text == "" || txtFjalkalimi.Text == "" || txtSpecializimi.Text == "" || txtTitulli.Text == ""
                || txtGjinia.Text == "" || txtDitelindja.Text == "" || txtVendlindja.Text == "" || txtShteti.Text == "" || txtVendbanimi.Text == "" || txtTelefoni.Text == ""
                || txtEmail.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");

            }
            else
            {
                Trajneri trajneri = new Trajneri();
                trajneri.Emri = txtEmri.Text.Trim();
                trajneri.Mbiemri = txtMbiemri.Text.Trim();
                trajneri.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                trajneri.Fjalkalimi = txtFjalkalimi.Text.Trim();
                trajneri.Specializimi = txtSpecializimi.Text.Trim();
                trajneri.Titulli = txtTitulli.Text.Trim();
                trajneri.Gjinia = txtGjinia.Text.Trim();
                trajneri.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                trajneri.Vendlindja = txtVendlindja.Text.Trim();
                trajneri.Shteti = txtShteti.Text.Trim();
                trajneri.Vendbanimi = txtVendbanimi.Text.Trim();
                trajneri.Telefoni = txtTelefoni.Text.Trim();
                trajneri.Mail = txtEmail.Text.Trim();
                TrajneriBLL trajner = new TrajneriBLL();
                trajner.Regjistro(trajneri);
                MessageBox.Show("U regjistrua me sukses");
                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalkalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text =
                    txtVendlindja.Text = txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = "";
            }
        }
    }
}
