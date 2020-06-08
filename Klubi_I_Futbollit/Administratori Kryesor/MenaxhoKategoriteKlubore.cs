using Klubi_;
using Klubi_I_Futbollit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_;
using Klubi_I_Futbollit.BLL;
using Klubi_I_Futbollit.BO;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoKategoriteKlubore : Form
    {
        public MenaxhoKategoriteKlubore()
        {
            InitializeComponent();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (txtEmertimi.Text == " " || txtDeri.Text == "" || txtPrej.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");
            }
            else
            {
                KategoriteKlubore kategorit = new KategoriteKlubore();
                kategorit.Emertimi = txtEmertimi.Text.Trim();
                kategorit.Deri = int.Parse(txtDeri.Text.Trim());
                kategorit.Prej =int.Parse(txtPrej.Text.Trim());

                KategoriteKluboreBLL kategoria = new KategoriteKluboreBLL();
                kategoria.Regjistro(kategorit);

                txtEmertimi.Text = txtDeri.Text = txtPrej.Text =  "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }

        private void btnEdito_Click(object sender, EventArgs e)
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

        private void btnKerkoMeID_Click(object sender, EventArgs e)
        {
            KategoriteKlubore kl = new KategoriteKlubore();
            kl.KategoriaID = int.Parse(txtGjejmeid.Text.Trim());
            KategoriteKluboreBLL kategorite = new KategoriteKluboreBLL();
            kategorite.GjejKategorinMeID(kl);
            txtEmertimi.Text = kl.Emertimi;
            txtPrej.Text = kl.Prej.ToString();
            txtDeri.Text = kl.Deri.ToString();
        }

        private void btnFshij_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te fshij", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                KategoriteKlubore kl = new KategoriteKlubore();
                kl.KategoriaID = int.Parse(txtGjejmeid.Text.Trim());
                KategoriteKluboreBLL klubiDAL = new KategoriteKluboreBLL();
                klubiDAL.Fshij(kl);
                txtEmertimi.Text = txtDeri.Text = txtPrej.Text = "";
            }
        }

        private void btnSHfaq_Click(object sender, EventArgs e)
        {
            KategoriteKluboreBLL klubi = new KategoriteKluboreBLL();


            dgvMbushKategorit.DataSource = klubi.ShfaqListenEKategorivee();
            txtEmertimi.Text = txtPrej.Text = txtDeri.Text = "";
        }
    }
}
