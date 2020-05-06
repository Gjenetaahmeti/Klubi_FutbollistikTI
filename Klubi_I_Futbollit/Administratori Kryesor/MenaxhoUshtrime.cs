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
    public partial class MenaxhoUshtrime : Form
    {
        public MenaxhoUshtrime()
        {
            InitializeComponent();
        }

        private void BtnRuaj_Click(object sender, EventArgs e)
        {
            if (txtDita.Text== " " || txtOra.Text=="")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                Ushtrimet ushtrimet = new Ushtrimet();
                ushtrimet.Dita = txtDita.Text.Trim();
                ushtrimet.Ora = txtOra.Text.Trim();

                UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
                ushtrimetDAL.Shto(ushtrimet);
            }
           
        }

        private void BtnKerkoMeID_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrimet = new Ushtrimet();
            ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();

            ushtrimetDAL.GjejUshtrimMeID(ushtrimet);
            txtDita.Text = ushtrimet.Dita;
            txtOra.Text = ushtrimet.Ora;

        }

        private void BtnEdito_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrimet = new Ushtrimet();
            ushtrimet.Dita = txtDita.Text.Trim();
            ushtrimet.Ora = txtOra.Text.Trim();
            ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.Update(ushtrimet);
        }

        private void BtnFshij_Click(object sender, EventArgs e)
        {
            Ushtrimet ushtrimet = new Ushtrimet();
            ushtrimet.UshtrimetID = int.Parse(txtGjejMeID.Text.Trim());
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            ushtrimetDAL.FshijMeID(ushtrimet);
        }

        private void BtnShfaqTeGjitha_Click(object sender, EventArgs e)
        {
            UshtrimetDAL ushtrimetDAL = new UshtrimetDAL();
            dgdMbushUshtrime.DataSource = ushtrimetDAL.GetAll();
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
            MenaxhoLojtaret menaxho = new MenaxhoLojtaret();
            menaxho.ShowDialog();
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

        private void MenaxhoVleresimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoVlersimet menaxhoVlersimet = new MenaxhoVlersimet();
            menaxhoVlersimet.ShowDialog();
        }
    }
}
