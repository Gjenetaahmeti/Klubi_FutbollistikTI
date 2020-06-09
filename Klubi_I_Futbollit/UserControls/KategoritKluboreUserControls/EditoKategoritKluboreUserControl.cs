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

namespace Klubi_I_Futbollit.UserControls.KategoritKluboreUserControls
{
    public partial class EditoKategoritKluboreUserControl : UserControl
    {
        public EditoKategoritKluboreUserControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KategoriteKlubore kl = new KategoriteKlubore();
            kl.KategoriaID = int.Parse(txtGjejmeid.Text.Trim());
            KategoriteKluboreBLL kategorite = new KategoriteKluboreBLL();
            kategorite.GjejKategorinMeID(kl);
            txtEmertimi.Text = kl.Emertimi;
            txtPrej.Text = kl.Prej.ToString();
            txtDeri.Text = kl.Deri.ToString();
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                KategoriteKlubore kategorit = new KategoriteKlubore();
                kategorit.Emertimi = txtEmertimi.Text.Trim();
                kategorit.Deri = int.Parse(txtDeri.Text.Trim());
                kategorit.Prej = int.Parse(txtPrej.Text.Trim());
                kategorit.KategoriaID = int.Parse(txtGjejmeid.Text);
                KategoriteKluboreBLL kategori = new KategoriteKluboreBLL();
                kategori.Edito(kategorit);

                txtEmertimi.Text = txtDeri.Text = txtPrej.Text = "";
            }
        }
    }
}
