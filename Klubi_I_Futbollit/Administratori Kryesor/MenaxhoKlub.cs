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
using Klubi_I_Futbollit.BLL;
using Klubi_I_Futbollit.BO;


namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoKlub : Form
    {
        public MenaxhoKlub()
        {
            InitializeComponent();
        }

        private void BtnRegjistro_Click(object sender, EventArgs e)
        {
            if (txtEmertimi.Text == "" || txtVendi.Text == "" || txtKyetari.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");

            }
            else
            {

                Klubi klubi = new Klubi();
                klubi.Emertimi = txtEmertimi.Text.Trim();
                klubi.Vendi = txtEmertimi.Text.Trim();
                klubi.Kryetari = txtKyetari.Text.Trim();
                klubi.IThemeluar = DateTime.Parse(dtpDataeThemelimit.Text.Trim());

                KlubiBLL klubiDAL = new KlubiBLL();
                klubiDAL.Regjistro(klubi);
                MessageBox.Show("U regjistrua me sukses!", MessageBoxButtons.OK.ToString());

            }
        }

        private void BtnKerkoKlubMeID_Click(object sender, EventArgs e)
        {
            Klubi kl = new Klubi();
            kl.KlubiID = int.Parse(txtGjejKlubMeID.Text.Trim());
            KlubiBLL klubiDAL = new KlubiBLL();
            klubiDAL.GjejKlubinMeID(kl);
            txtEmertimi.Text = kl.Emertimi;
            txtVendi.Text = kl.Vendi;
            txtKyetari.Text = kl.Kryetari;
            dtpDataeThemelimit.Text = kl.IThemeluar.ToString();



        }

        private void BtnEdito_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi ta editoni?", "Kujdes", MessageBoxButtons.YesNo);

            if (rez == DialogResult.Yes)
            {
                Klubi klubi = new Klubi();
                klubi.Emertimi = txtEmertimi.Text.Trim();
                klubi.Vendi = txtEmertimi.Text.Trim();
                klubi.Kryetari = txtKyetari.Text.Trim();
                klubi.IThemeluar = DateTime.Parse(dtpDataeThemelimit.Text.Trim());
                klubi.KlubiID = int.Parse(txtGjejKlubMeID.Text.Trim());
                KlubiBLL klubiDAL = new KlubiBLL();
                klubiDAL.Edito(klubi);
            }
        }

        private void BtnFshijKlub_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi ta fshini?", "Kujdes", MessageBoxButtons.YesNo);

            if (rez == DialogResult.Yes)
            {
                Klubi kl = new Klubi();
                kl.KlubiID = int.Parse(txtGjejKlubMeID.Text.Trim());
                KlubiBLL klubiDAL = new KlubiBLL();
                klubiDAL.Fshij(kl);
            }
        }

        private void BtnShfaq_Click(object sender, EventArgs e)
        {
            KlubiBLL klubi = new KlubiBLL();
         

            dgdMbushKlub.DataSource = klubi.ShfaqListenEKlubeve();
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

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoDelegat menaxhoDelegat = new MenaxhoDelegat();
            menaxhoDelegat.ShowDialog();
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
