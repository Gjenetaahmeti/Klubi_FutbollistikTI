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
using Klubi_I_Futbollit.BO;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoTrajner : Form
    {
        public MenaxhoTrajner()
        {
            InitializeComponent();
        }

        private void btnRegjistroTrajner_Click(object sender, EventArgs e)
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
            TrajneriDAL trajner = new TrajneriDAL();
            trajner.Shto(trajneri);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Trajneri trajneri = new Trajneri();
            trajneri.TrajneriID = int.Parse(txtShkruajID.Text.Trim());
            TrajneriDAL gjejTrajnerin = new TrajneriDAL();
            gjejTrajnerin.GjejTrajnerinMeID(trajneri);
            txtEmri.Text = trajneri.Emri;
            txtMbiemri.Text = trajneri.Mbiemri;
            txtEmriPerdoruesit.Text = trajneri.EmriIPerdoruesit;
            txtFjalkalimi.Text = trajneri.Fjalkalimi;
            txtSpecializimi.Text = trajneri.Specializimi;
            txtTitulli.Text = trajneri.Titulli;
            txtGjinia.Text = trajneri.Gjinia;
            txtDitelindja.Text = trajneri.Ditelindja.ToString();
            txtVendlindja.Text = trajneri.Vendlindja.ToString();
            txtShteti.Text = trajneri.Shteti;
            txtVendbanimi.Text = trajneri.Vendbanimi;
            txtTelefoni.Text = trajneri.Telefoni.ToString();
            txtEmail.Text = trajneri.Mail;
            btnFshije.Visible = true;
            btnEdito.Visible = true;
            btnRegjistroTrajner.Visible = false;
            btnShfaqTrajnerat.Visible = false;
        }

        private void btnEdito_Click(object sender, EventArgs e)
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
            trajneri.TrajneriID = int.Parse(txtShkruajID.Text.Trim());
            TrajneriDAL trajner = new TrajneriDAL();
            trajner.Update(trajneri);
        }
        private void btnFshije_Click(object sender, EventArgs e)
        {
            Trajneri trajner = new Trajneri();
            trajner.TrajneriID = int.Parse(txtShkruajID.Text.Trim());
            TrajneriDAL fshijTrajnerin = new TrajneriDAL();
            fshijTrajnerin.Fshij(trajner);
        }
        private void btnShfaqTrajnerat_Click(object sender, EventArgs e)
        {
            TrajneriDAL obj = new TrajneriDAL();
            dgdShfaqTrajnerat.DataSource = obj.GetAll();
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenyKryefaqja menyKryefaqja = new MenyKryefaqja();
            menyKryefaqja.ShowDialog();
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoPersonelin menaxhoPersonelin = new MenaxhoPersonelin();
            menaxhoPersonelin.ShowDialog();
        }

        private void MenaxhoLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoLojtaret menaxho = new MenaxhoLojtaret();
            menaxho.ShowDialog();
        }

        private void MenaxhoNdeshjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoNdeshje menaxhoNdeshje = new MenaxhoNdeshje();
            menaxhoNdeshje.ShowDialog();
        }

        private void FormacioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formacionet formacionet = new Formacionet();
            formacionet.ShowDialog();
        }

        private void MenaxhoGolashenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoGolashenuesin menaxhoGolashenuesin = new MenaxhoGolashenuesin();
            menaxhoGolashenuesin.ShowDialog();
        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoDelegat menaxhoDelegat = new MenaxhoDelegat();
            menaxhoDelegat.ShowDialog();
        }

        private void MenaxhoKlubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoKlub menaxhoKlub = new MenaxhoKlub();
            menaxhoKlub.ShowDialog();
        }
    }
}
