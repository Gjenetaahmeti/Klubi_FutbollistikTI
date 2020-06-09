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
    public partial class RegjistroRaporteUserControl : UserControl
    {
        public RegjistroRaporteUserControl()
        {
            InitializeComponent();
        }

        private void rtbRaportiPolicor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpDataNdeshjes.Text == "" || txtSezoni.Text == " " || rtbRaportiAmbullances.Text == "" || rtbRaportiPolicor.Text == "" || rtbRaporti.Text == "")
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
                dtpDataNdeshjes.Text = txtSezoni.Text = rtbRaportiAmbullances.Text = rtbRaportiPolicor.Text = rtbRaporti.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
    }
}
