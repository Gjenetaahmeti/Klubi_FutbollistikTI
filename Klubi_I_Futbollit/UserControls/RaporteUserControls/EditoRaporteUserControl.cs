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

namespace Klubi_I_Futbollit.UserControls.RaporteUserControls
{
    public partial class EditoRaporteUserControl : UserControl
    {
        public EditoRaporteUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
