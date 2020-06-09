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

namespace Klubi_I_Futbollit.UserControls.GolashenuesiUserControls
{
    public partial class RegjistroGolashenuesiUserControl : UserControl
    {
        public RegjistroGolashenuesiUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumriGolave.Text == " ")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                var lojtari = cmbLojtari.SelectedValue.ToString();
                var ndeshja = cmbNdeshja.SelectedValue.ToString();
                Golashenuesit golaShenuesit = new Golashenuesit();
                golaShenuesit.lojtariID = int.Parse(lojtari);
                golaShenuesit.NumriGolave = int.Parse(txtNumriGolave.Text.Trim());
                golaShenuesit.ndeshjaID = int.Parse(ndeshja);
                GolashenuesiBLL golashenuesiBLL = new GolashenuesiBLL();
                golashenuesiBLL.Regjistro(golaShenuesit);
                cmbLojtari.Text = cmbNdeshja.Text = txtNumriGolave.Text = "";
                MessageBox.Show("U regjistrua me sukses");
            }
        }
    }
}
