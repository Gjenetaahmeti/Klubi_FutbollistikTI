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
    public partial class MenaxhoRaporte : Form
    {
        public MenaxhoRaporte()
        {
            InitializeComponent();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {

            if (dtpDataNdeshjes.Text==""|| txtSezoni.Text == " " || rtbRaportiAmbullances.Text == "" || rtbRaportiPolicor.Text == ""||rtbRaporti.Text=="")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {

                Raporti raporti = new Raporti();
                raporti.dataNdeshjes = DateTime.Parse(dtpDataNdeshjes.Text.Trim());
                raporti.Sezoni = txtSezoni.Text.Trim();
                raporti.RaportiAmbulances = rtbRaportiAmbullances.Text.Trim();
                raporti.RaportiPolicor = rtbRaportiPolicor.Text.Trim();
                raporti.Raportii = rtbRaporti.Text.Trim();
                RaportiBLL raportibll = new RaportiBLL();
                raportibll.Regjistro(raporti);
                dtpDataNdeshjes.Text = txtSezoni.Text = rtbRaportiAmbullances.Text = rtbRaportiPolicor.Text = rtbRaporti.Text= "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Raporti raporti = new Raporti();
            raporti.NdeshjaID = int.Parse(txtGjejMeid.Text.Trim());
            RaportiBLL dali = new RaportiBLL();
            dali.GjejRaportMeID(raporti);
            dtpDataNdeshjes.Text = raporti.dataNdeshjes.ToString();
            txtSezoni.Text = raporti.Sezoni;
            rtbRaportiAmbullances.Text = raporti.RaportiAmbulances;
            rtbRaportiPolicor.Text = raporti.RaportiPolicor;
            rtbRaporti.Text = raporti.Raportii;
        }

        private void btnEdito_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Raporti raporti = new Raporti();
                raporti.dataNdeshjes = DateTime.Parse(dtpDataNdeshjes.Text.Trim());
                raporti.Sezoni = txtSezoni.Text.Trim();
                raporti.RaportiAmbulances = rtbRaportiAmbullances.Text.Trim();
                raporti.RaportiPolicor = rtbRaportiPolicor.Text.Trim();
                raporti.Raportii = rtbRaporti.Text.Trim();
                raporti.NdeshjaID = int.Parse(txtGjejMeid.Text);
                RaportiBLL raportibll = new RaportiBLL();
                raportibll.Edito(raporti);
                dtpDataNdeshjes.Text = txtSezoni.Text = rtbRaportiAmbullances.Text = rtbRaportiPolicor.Text = rtbRaporti.Text = "";
            }
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {

            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Raporti raporti = new Raporti();
                raporti.NdeshjaID = int.Parse(txtGjejMeid.Text.Trim());
                RaportiBLL raportibll = new RaportiBLL();
                raportibll.Fshij(raporti);
                dtpDataNdeshjes.Text = txtSezoni.Text = rtbRaportiAmbullances.Text = rtbRaportiPolicor.Text = rtbRaporti.Text = "";

            }
        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
            RaportiBLL raportibll = new RaportiBLL();
            dgvMbushRaporte.DataSource = raportibll.ShfaqListenERaporteve();
            dtpDataNdeshjes.Text = txtSezoni.Text = rtbRaportiAmbullances.Text = rtbRaportiPolicor.Text = rtbRaporti.Text = "";

        }
    }
}
