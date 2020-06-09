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
    public partial class EditoDelegatUserControls : UserControl
    {
        public EditoDelegatUserControls()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Delegat delegat = new Delegat();
                delegat.Emri = txtEmri.Text.Trim();
                delegat.Mbiemri = txtMbiemri.Text.Trim();
                delegat.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                delegat.Fjalkalimi = txtFjalkalimi.Text.Trim();
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
                delegat.RaportiPasNdeshjes = txtRaportiPasndeshjes.Text.Trim();
                //  delegat.DelegatID = int.Parse(txtIdEDelegatit.Text.Trim());
                delegat.DelegatID = int.Parse(txtShkruajID.Text.Trim());
                DelegatBLL del = new DelegatBLL();
                del.Edito(delegat);
                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalkalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtShteti.Text =
                    txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = txtRoli.Text = txtRaportiPasndeshjes.Text = "";
            }
        }

        private void txtNumriTelefonit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delegat delegat = new Delegat();
            delegat.DelegatID = int.Parse(txtShkruajID.Text.Trim());
            DelegatBLL gjejdelegat = new DelegatBLL();
            gjejdelegat.GjejDelegatinMeID(delegat);
            txtEmri.Text = delegat.Emri;
            txtMbiemri.Text = delegat.Mbiemri;
            txtEmriPerdoruesit.Text = delegat.EmriIPerdoruesit;
            txtFjalkalimi.Text = delegat.Fjalkalimi;
            txtSpecializimi.Text = delegat.Specializimi;
            txtTitulli.Text = delegat.Titulli;
            txtGjinia.Text = delegat.Gjinia;
            txtDitelindja.Text = delegat.Ditelindja.ToString();
            txtVendlindja.Text = delegat.Vendlindja.ToString();
            txtShteti.Text = delegat.Shteti;
            txtVendbanimi.Text = delegat.Vendbanimi;
            txtTelefoni.Text = delegat.Telefoni.ToString();
            txtEmail.Text = delegat.Mail;
            txtRoli.Text = delegat.Roli;
            txtRaportiPasndeshjes.Text = delegat.RaportiPasNdeshjes;
            panel1.Visible = true;
        }
    }
}
