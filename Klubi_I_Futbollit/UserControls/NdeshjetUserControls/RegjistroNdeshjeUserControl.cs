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
    public partial class RegjistroNdeshjeUserControl : UserControl
    {
        public RegjistroNdeshjeUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSezoni.Text == " " || txtRaportiAmbulances.Text == "" || txtRaportiPolicis.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {

                Ndeshja ndeshja = new Ndeshja();
                ndeshja.dataNdeshjes = DateTime.Parse(dtData.Text.Trim());
                ndeshja.Sezoni = txtSezoni.Text.Trim();
                ndeshja.RaportiAmbulances = txtRaportiAmbulances.Text.Trim();
                ndeshja.RaportiPolicor = txtRaportiPolicis.Text.Trim();
                NdeshjaBLL ndeshjaDAL = new NdeshjaBLL();
                ndeshjaDAL.Regjistro(ndeshja);
                dtData.Text = txtSezoni.Text = txtRaportiAmbulances.Text = txtRaportiPolicis.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
    }
}
