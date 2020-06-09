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

namespace Klubi_I_Futbollit.UserControls.ReferatUserControls
{
    public partial class RegjistroReferatUserControl : UserControl
    {
        public RegjistroReferatUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtEmriPerdoruesit.Text == "" || txtFjalkalimi.Text == "" || txtSpecializimi.Text == "" || txtTitulli.Text == ""
              || txtGjinia.Text == "" || txtDitelindja.Text == "" || txtVendlindja.Text == "" || txtShteti.Text == "" || txtVendbanimi.Text == "" || txtTelefoni.Text == ""
              || txtEmail.Text == "" || txtPozita.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                Referi referi = new Referi();
                referi.Emri = txtEmri.Text.Trim();
                referi.Mbiemri = txtMbiemri.Text.Trim();
                referi.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                referi.Fjalkalimi = txtFjalkalimi.Text.Trim();
                referi.Specializimi = txtSpecializimi.Text.Trim();
                referi.Titulli = txtTitulli.Text.Trim();
                referi.Gjinia = txtGjinia.Text.Trim();
                referi.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                referi.Vendlindja = txtVendlindja.Text.Trim();
                referi.Shteti = txtShteti.Text.Trim();
                referi.Vendbanimi = txtVendbanimi.Text.Trim();
                referi.Telefoni = txtTelefoni.Text.Trim();
                referi.Mail = txtEmail.Text.Trim();
                referi.Pozita = txtPozita.Text.Trim();
                ReferiBLL del = new ReferiBLL();
                del.Regjistro(referi);
                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalkalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text =
                    txtVendlindja.Text = txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = txtPozita.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
    }
}
