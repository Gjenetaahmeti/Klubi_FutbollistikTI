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

namespace Klubi_I_Futbollit.UserControls.KlubetUserControls
{
    public partial class EditoKlubUserControl : UserControl
    {
        public EditoKlubUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klubi kl = new Klubi();
            kl.KlubiID = int.Parse(txtGjejKlubMeID.Text.Trim());
            KlubiBLL klubiDAL = new KlubiBLL();
            klubiDAL.GjejKlubinMeID(kl);
            txtEmertimi.Text = kl.Emertimi;
            txtVendi.Text = kl.Vendi;
            txtKyetari.Text = kl.Kryetari;
            dtpDataeThemelimit.Text = kl.IThemeluar.ToString();
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                Klubi klubi = new Klubi();
                klubi.Emertimi = txtEmertimi.Text.Trim();
                klubi.Vendi = txtVendi.Text.Trim();
                klubi.Kryetari = txtKyetari.Text.Trim();
                klubi.IThemeluar = DateTime.Parse(dtpDataeThemelimit.Text.Trim());
                klubi.KlubiID = int.Parse(txtGjejKlubMeID.Text.Trim());
                KlubiBLL klubiDAL = new KlubiBLL();
                klubiDAL.Edito(klubi);
                txtEmertimi.Text = txtVendi.Text = txtKyetari.Text = dtpDataeThemelimit.Text = "";
            }
        }
    }
}
