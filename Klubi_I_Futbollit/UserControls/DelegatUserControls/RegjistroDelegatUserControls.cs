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

namespace Klubi_I_Futbollit.UserControls.DelegatUserControls
{
    public partial class RegjistroDelegatUserControls : UserControl
    {
        public RegjistroDelegatUserControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtEmriPerdoruesit.Text == "" || txtFjalekalimi.Text == "" || txtSpecializimi.Text == "" || txtTitulli.Text == ""
             || txtGjinia.Text == "" || txtDitelindja.Text == "" || txtVendlindja.Text == "" || txtShteti.Text == "" || txtVendbanimi.Text == "" || txtTelefoni.Text == ""
             || txtEmail.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");

            }
            else
            {
                Delegat delegat = new Delegat();
                delegat.Emri = txtEmri.Text.Trim();
                delegat.Mbiemri = txtMbiemri.Text.Trim();
                delegat.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                delegat.Fjalkalimi = txtFjalekalimi.Text.Trim();
                delegat.Specializimi = txtSpecializimi.Text.Trim();
                delegat.Titulli = txtTitulli.Text.Trim();
                delegat.Gjinia = txtGjinia.Text.Trim();
                delegat.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                delegat.Vendlindja = txtVendlindja.Text.Trim();
                delegat.Shteti = txtShteti.Text.Trim();
                delegat.Vendbanimi = txtVendbanimi.Text.Trim();
                delegat.Telefoni = txtTelefoni.Text.Trim();
                delegat.Mail = txtEmail.Text.Trim();
                delegat.Roli = txtRoli.Text.Trim();
                delegat.RaportiPasNdeshjes = txtRaportiPasNdeshjes.Text.Trim();
                DelegatBLL del = new DelegatBLL();
                del.Regjistro(delegat);
                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalekalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtShteti.Text =
                    txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = txtRoli.Text = txtRaportiPasNdeshjes.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
    }
}
