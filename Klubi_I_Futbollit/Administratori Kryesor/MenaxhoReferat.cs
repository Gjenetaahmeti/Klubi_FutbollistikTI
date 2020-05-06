using Klubi_;
using Klubi_I_Futbollit.BLL;
using Klubi_I_Futbollit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoReferat : Form
    {
        public MenaxhoReferat()
        {
            InitializeComponent();
        }
        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtEmriPerdoruesit.Text == "" || txtFjalkalimi.Text == "" || txtSpecializimi.Text == "" || txtTitulli.Text == ""
              || txtGjinia.Text == "" || txtDitelindja.Text == "" || txtVendlindja.Text == "" || txtShteti.Text == "" || txtVendbanimi.Text == "" || txtTelefoni.Text == ""
              || txtEmail.Text == ""||txtPozita.Text=="")
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
                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalkalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text = txtDitelindja.text =
                    txtVendlindja.Text = txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = txtPozita.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Referi referi = new Referi();
            referi.ReferiID = int.Parse(txtKerko.Text.Trim());
            ReferiBLL gjejRefer = new ReferiBLL();
            gjejRefer.GjejReferMeID(referi);
            txtEmri.Text = referi.Emri;
            txtMbiemri.Text = referi.Mbiemri;
            txtEmriPerdoruesit.Text = referi.EmriIPerdoruesit;
            txtFjalkalimi.Text = referi.Fjalkalimi;
            txtSpecializimi.Text = referi.Specializimi;
            txtTitulli.Text = referi.Titulli;
            txtGjinia.Text = referi.Gjinia;
            txtDitelindja.Text = referi.Ditelindja.ToString();
            txtVendlindja.Text = referi.Vendlindja.ToString();
            txtShteti.Text = referi.Shteti;
            txtVendbanimi.Text = referi.Vendbanimi;
            txtTelefoni.Text = referi.Telefoni.ToString();
            txtEmail.Text = referi.Mail;
            txtPozita.Text = referi.Pozita;
        }

        private void Edito_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
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
                referi.ReferiID = int.Parse(txtKerko.Text.Trim());
                ReferiBLL dal = new ReferiBLL();
                dal.Edito(referi);
                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalkalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text = txtDitelindja.text =
                    txtVendlindja.Text = txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = txtPozita.Text = "";
            }
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoPersonelin menaxhoPersonelin = new MenaxhoPersonelin();
            menaxhoPersonelin.ShowDialog();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenyKryefaqja menyKryefaqja = new MenyKryefaqja();
            menyKryefaqja.ShowDialog();
        }

        private void MenaxhoLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoLojtaret menaxhoLojtaret = new MenaxhoLojtaret();
            menaxhoLojtaret.ShowDialog();
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

        private void MenaxhoFormacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formacionet formacionet = new Formacionet();
            formacionet.ShowDialog();
        }

        private void MenaxhoGolashenuesinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoGolashenuesin menaxhoGolashenuesin = new MenaxhoGolashenuesin();
            menaxhoGolashenuesin.ShowDialog();
        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoDelegat menaxhoDelegat = new MenaxhoDelegat();
            menaxhoDelegat.ShowDialog();
        }

        private void MenaxhoKluibnToolStripMenuItem_Click(object sender, EventArgs e)
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
