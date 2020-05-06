using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_;
using Klubi_Futbollistik;
using Klubi_I_Futbollit.BLL;
using Klubi_I_Futbollit.BO;


namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoDelegat : Form
    {
        public MenaxhoDelegat()
        {
            InitializeComponent();
        }

        private void Btnregjistrodelegat_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtEmriPerdoruesit.Text == "" || txtFjalkalimi.Text == "" || txtSpecializimi.Text == "" || txtTitulli.Text == ""
             || txtGjinia.Text == "" || txtDitelindja.Text == "" || txtVendlindja.Text == "" || txtShteti.Text == "" || txtVendbanimi.Text == "" || txtTelefoni.Text == ""
             || txtEmail.Text == "" )
            {
                MessageBox.Show("Plotesoni te gjitha fushat");

            }
            else
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
                DelegatBLL del = new DelegatBLL();
                del.Regjistro(delegat);
                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalkalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtShteti.Text =
                    txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = txtRoli.Text = txtRaportiPasndeshjes.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }

        private void BtnShfaqDelegat_Click(object sender, EventArgs e)
        {
            DelegatBLL obj = new DelegatBLL();
            dgvMbushDelegat.DataSource = obj.ShfaqListenEDelegateve();
            txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalkalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtShteti.Text =
               txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = txtRoli.Text = txtRaportiPasndeshjes.Text = "";

        }

        private void BtnEdito_Click_1(object sender, EventArgs e)
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

        private void BtnKerko_Click_1(object sender, EventArgs e)
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
        }

        private void BtnfshijDelegat_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Delegat delegat = new Delegat();
                delegat.DelegatID = int.Parse(txtShkruajID.Text.Trim());
                DelegatBLL fshijdelegat = new DelegatBLL();
                fshijdelegat.Fshij(delegat);
                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalkalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtShteti.Text =
                    txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = txtRoli.Text = txtRaportiPasndeshjes.Text = "";
            }
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenyKryefaqja mk = new MenyKryefaqja();
            mk.ShowDialog();
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoPersonelin menaxhoPersonelin = new MenaxhoPersonelin();
            menaxhoPersonelin.ShowDialog();
        }

        private void MenaxhoLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoDelegat menaxhoDelegat = new MenaxhoDelegat();
            menaxhoDelegat.ShowDialog();
        }

        private void MenaxhoTrajnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoTrajner menaxhoTrajner = new MenaxhoTrajner();
            menaxhoTrajner.ShowDialog();
        }

        private void MenaxhoNdeshjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoNdeshje menaxhoNdeshje = new MenaxhoNdeshje();
            menaxhoNdeshje.ShowDialog();
        }

        private void MenaxhoFormacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formacionet formacionet = new Formacionet();
            formacionet.ShowDialog();
        }

        private void MenaxhoGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoGolashenuesin menaxhoGolashenuesin = new MenaxhoGolashenuesin();
            menaxhoGolashenuesin.ShowDialog();
        }

        private void MenaxhoKlubinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoKlub menaxhoKlub = new MenaxhoKlub();
            menaxhoKlub.ShowDialog();
        }

        private void MenaxhoUshtrimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoUshtrime menaxhoUshtrime = new MenaxhoUshtrime();
            menaxhoUshtrime.ShowDialog();
        }

        private void MenaxhoVleresimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoVlersimet menaxhoVlersimet = new MenaxhoVlersimet();
            menaxhoVlersimet.ShowDialog();
        }
    }
}

