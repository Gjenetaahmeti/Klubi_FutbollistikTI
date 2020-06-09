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

namespace Klubi_I_Futbollit.UserControls.TrajnerUserControls
{
    public partial class EditoTrajnerUserControl : UserControl
    {
        public EditoTrajnerUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Trajneri trajneri = new Trajneri();
                trajneri.Emri = txtEmri.Text.Trim();
                trajneri.Mbiemri = txtMbiemri.Text.Trim();
                trajneri.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                trajneri.Fjalkalimi = txtFjalkalimi.Text.Trim();
                trajneri.Specializimi = txtSpecializimi.Text.Trim();
                trajneri.Titulli = txtTitulli.Text.Trim();
                trajneri.Gjinia = txtGjinia.Text.Trim();
                trajneri.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                trajneri.Vendlindja = txtVendlindja.Text.Trim();
                trajneri.Shteti = txtShteti.Text.Trim();
                trajneri.Vendbanimi = txtVendbanimi.Text.Trim();
                trajneri.Telefoni = txtTelefoni.Text.Trim();
                trajneri.Mail = txtEmail.Text.Trim();
                trajneri.TrajneriID = int.Parse(txtShkruajID.Text.Trim());
                TrajneriBLL trajner = new TrajneriBLL();
                trajner.Edito(trajneri);
                 
                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalkalimi.Text = txtSpecializimi.Text = txtTitulli.Text = txtGjinia.Text = txtDitelindja.Text =
                    txtVendlindja.Text = txtShteti.Text = txtVendbanimi.Text = txtTelefoni.Text = txtEmail.Text = "";
            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Trajneri trajneri = new Trajneri();
            trajneri.TrajneriID = int.Parse(txtShkruajID.Text.Trim());
            TrajneriBLL gjejTrajnerin = new TrajneriBLL();
            gjejTrajnerin.GjejTrajnerinMeID(trajneri);
            txtEmri.Text = trajneri.Emri;
            txtMbiemri.Text = trajneri.Mbiemri;
            txtEmriPerdoruesit.Text = trajneri.EmriIPerdoruesit;
            txtFjalkalimi.Text = trajneri.Fjalkalimi;
            txtSpecializimi.Text = trajneri.Specializimi;
            txtTitulli.Text = trajneri.Titulli;
            txtGjinia.Text = trajneri.Gjinia;
            txtDitelindja.Text = trajneri.Ditelindja.ToString();
            txtVendlindja.Text = trajneri.Vendlindja.ToString();
            txtShteti.Text = trajneri.Shteti;
            txtVendbanimi.Text = trajneri.Vendbanimi;
            txtTelefoni.Text = trajneri.Telefoni.ToString();
            txtEmail.Text = trajneri.Mail;
            panel1.Visible = true;
        }
    }
}
