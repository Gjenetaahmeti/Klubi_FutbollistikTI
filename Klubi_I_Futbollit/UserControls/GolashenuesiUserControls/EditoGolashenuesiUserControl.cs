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
    public partial class EditoGolashenuesiUserControl : UserControl
    {
        public EditoGolashenuesiUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Golashenuesit golashenuesit = new Golashenuesit();
            golashenuesit.GolashenuesiID = int.Parse(txtKerkoMeID.Text.Trim());
            GolashenuesiBLL gjejGolaShenuesin = new GolashenuesiBLL();
            gjejGolaShenuesin.GjejGolashenuesinmeID(golashenuesit);
            cmbLojtari.Text = golashenuesit.lojtariID.ToString();
            txtNumriGolave.Text = golashenuesit.NumriGolave.ToString();
            cmbNdeshja.Text = golashenuesit.ndeshjaID.ToString();
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                var lojtari = cmbLojtari.SelectedValue.ToString();
                var ndeshja = cmbNdeshja.SelectedValue.ToString();
                Golashenuesit golaShenuesit = new Golashenuesit();
                golaShenuesit.GolashenuesiID = int.Parse(txtKerkoMeID.Text);
                golaShenuesit.lojtariID = int.Parse(lojtari);
                golaShenuesit.NumriGolave = int.Parse(txtNumriGolave.Text.Trim());
                golaShenuesit.ndeshjaID = int.Parse(ndeshja);
                GolashenuesiBLL golashenuesiBLL = new GolashenuesiBLL();
                golashenuesiBLL.Edito(golaShenuesit);
                cmbLojtari.Text = cmbNdeshja.Text = txtNumriGolave.Text = "";
            }
        }
    }
}
