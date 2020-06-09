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

namespace Klubi_I_Futbollit.UserControls.NdeshjetUserControls
{
    public partial class EditoNdeshjeUserControl : UserControl
    {
        public EditoNdeshjeUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ndeshja ndeshja = new Ndeshja();
            ndeshja.NdeshjaID = int.Parse(txtShkruajID.Text.Trim());
            NdeshjaBLL dali = new NdeshjaBLL();
            dali.GjejNdeshjenMeID(ndeshja);
            dtData.Text = ndeshja.dataNdeshjes.ToString();
            txtSezoni.Text = ndeshja.Sezoni;
            txtRaportiAmbulances.Text = ndeshja.RaportiAmbulances;
            txtRaportiPolicis.Text = ndeshja.RaportiPolicor;
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Ndeshja ndeshja = new Ndeshja();
                ndeshja.dataNdeshjes = DateTime.Parse(dtData.Text.Trim());
                ndeshja.Sezoni = txtSezoni.Text.Trim();
                ndeshja.RaportiAmbulances = txtRaportiAmbulances.Text.Trim();
                ndeshja.RaportiPolicor = txtRaportiPolicis.Text.Trim();
                ndeshja.NdeshjaID = int.Parse(txtShkruajID.Text);
                NdeshjaBLL ndeshjaDAL = new NdeshjaBLL();
                ndeshjaDAL.Edito(ndeshja);
                dtData.Text = txtSezoni.Text = txtRaportiAmbulances.Text = txtRaportiPolicis.Text = "";
            }
        }
    }
}
