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
using Klubi_I_Futbollit.BO;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoUshtrimet : Form
    {
        public MenaxhoUshtrimet()
        {
            InitializeComponent();
        }

        private void BtnRegjistro_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrime = new Ushtrimet();
            ushtrime.Dita = txtDita.Text.Trim();
            ushtrime.Ora =txtOra.Text.Trim();

            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.Shto(ushtrime);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrime = new Ushtrimet();
            ushtrime.Dita = txtDita.Text.Trim();
            ushtrime.Ora = txtOra.Text.Trim();
            ushtrime.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.Update(ushtrime);
        }

        private void BtnShfaqTeGjitha_Click(object sender, EventArgs e)
        {
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();

            dgdMbushUshtrime.DataSource = ushtrimetDAL.GetAll();
        }

        private void BtnKerko_Click(object sender, EventArgs e)
        {     

            Ushtrimet ushtrimet = new Ushtrimet();
            ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.GjejUshtrimMeID(ushtrimet);
            txtDita.Text = ushtrimet.Dita;

            txtOra.Text = ushtrimet.Ora;
        }

        private void BtnFshij_Click(object sender, EventArgs e)
        {
            Ushtrimet kl = new Ushtrimet();
            kl.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.FshijMeID(kl);
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoPersonelin menaxhoPersonelin = new MenaxhoPersonelin();
            menaxhoPersonelin.ShowDialog();
            this.Close();
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

        private void MenaxhoKlubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoKlub menaxhoKlub = new MenaxhoKlub();
            menaxhoKlub.ShowDialog();
        }
    }
}
