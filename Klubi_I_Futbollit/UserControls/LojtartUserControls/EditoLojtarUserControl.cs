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

namespace Klubi_I_Futbollit.UserControls.LojtartUserControls
{
    public partial class EditoLojtarUserControl : UserControl
    {
        public EditoLojtarUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lojtari lojtar = new Lojtari();
            lojtar.LojtariID = int.Parse(txtShkruajID.Text.Trim());
            LojtariBLL gjejLojtarin = new LojtariBLL();
            gjejLojtarin.GjejLojtarMeID(lojtar);
            txtEmri.Text = lojtar.Emri.ToString();
            txtMbiemri.Text = lojtar.Mbiemri.ToString();
            txtEmriPerdoruesit.Text = lojtar.EmriIPerdoruesit.ToString();
            txtFjalekalimi.Text = lojtar.Fjalkalimi.ToString();
            txtNumriIfanelles.Text = lojtar.NumriFanelles.ToString();
            txtGjinia.Text = lojtar.Gjinia.ToString();
            txtDitelindja.Text = lojtar.Ditelindja.ToString();
            txtVendlindja.Text = lojtar.Vendlindja.ToString();
            txtGrupigjakut.Text = lojtar.GrupiGjakut.ToString();
            txtShtetesia.Text = lojtar.Shteti.ToString();
            txtVendbanimi.Text = lojtar.Vendbanimi.ToString();
            txtNumriTelefonit.Text = lojtar.Telefoni.ToString();
            txtEmail.Text = lojtar.Mail.ToString();
            txtPesha.Text = lojtar.Pesha.ToString();
            txtGjatesia.Text = lojtar.Gjatesia.ToString();
            panel1.Visible = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Lojtari person = new Lojtari();
                person.Emri = txtEmri.Text.Trim();
                person.Mbiemri = txtMbiemri.Text.Trim();
                person.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                person.Fjalkalimi = txtFjalekalimi.Text.Trim();
                person.NumriFanelles = int.Parse(txtNumriIfanelles.Text.Trim());
                person.Gjinia = txtGjinia.Text.Trim();
                person.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                person.Vendlindja = txtVendlindja.Text.Trim();
                person.GrupiGjakut = txtGrupigjakut.Text.Trim();
                person.Shteti = txtShtetesia.Text.Trim();
                person.Vendbanimi = txtVendbanimi.Text.Trim();
                person.Telefoni = txtNumriTelefonit.Text.Trim();
                person.Mail = txtEmail.Text.Trim();
                person.Pesha = decimal.Parse(txtPesha.Text.Trim());
                person.Gjatesia = decimal.Parse(txtGjatesia.Text.Trim());
                person.LojtariID = int.Parse(txtShkruajID.Text.Trim());
                LojtariBLL lojtariEditoBll = new LojtariBLL();
                lojtariEditoBll.Edito(person);

                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalekalimi.Text = txtNumriIfanelles.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtGrupigjakut.Text = txtShtetesia.Text =
                    txtVendbanimi.Text = txtNumriTelefonit.Text = txtEmail.Text = txtPesha.Text = txtGjatesia.Text = "";
            }
        }
    }
}
