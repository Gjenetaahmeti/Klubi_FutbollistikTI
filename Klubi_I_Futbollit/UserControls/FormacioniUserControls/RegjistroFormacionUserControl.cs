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

namespace Klubi_I_Futbollit.UserControls.FormacioniUserControls
{
    public partial class RegjistroFormacionUserControl : UserControl
    {
        public RegjistroFormacionUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPergjegjes.Text == " ")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                var der2 = comboBox1.SelectedValue.ToString();


                StatusiLojtarit statusiLojtarit = new StatusiLojtarit();
                statusiLojtarit.Pergjegjes = txtPergjegjes.Text.Trim();
                statusiLojtarit.Rezerv = txtRezerve.Text.Trim();
                statusiLojtarit.Huazim = txtHuazim.Text.Trim();
                statusiLojtarit.Shoqerues = txtShoqerues.Text.Trim();
                statusiLojtarit.Lojtariid = int.Parse(der2);
                StatusiLojtaritBLL statusiLojtaritDAL = new StatusiLojtaritBLL();
                statusiLojtaritDAL.Regjistro(statusiLojtarit);

                txtPergjegjes.Text = txtHuazim.Text = txtShoqerues.Text = comboBox1.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
    }
}
