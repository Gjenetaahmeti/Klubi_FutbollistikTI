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

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoReferat : Form
    {
        public MenaxhoReferat()
        {
            InitializeComponent();
        }
        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            Referi referi = new Referi();
            referi.Emri = txtEmri.Text.Trim();
            referi.Mbiemri = txtMbiemri.Text.Trim();
            referi.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
            referi.Fjalkalimi = txtFjalkalimi.Text.Trim();
            referi.Specializimi = txtSpecializimi.Text.Trim();
            referi.Titulli = txtTitulli.Text.Trim();
            referi.Gjinia = txtGjinia.Text.Trim();
            referi.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
            referi.Vendlindja = txtVendlindja.Text.Trim();
            referi.Shteti = txtShteti.Text.Trim();
            referi.Vendbanimi = txtVendbanimi.Text.Trim();
            referi.Telefoni = txtTelefoni.Text.Trim();
            referi.Mail = txtEmail.Text.Trim();
            referi.Pozita = txtPozita.Text.Trim();
            ReferiDAL del = new ReferiDAL();
            del.Shto(referi);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Referi referi = new Referi();
            referi.ReferiID = int.Parse(txtKerko.Text.Trim());
            ReferiDAL gjejRefer = new ReferiDAL();
            gjejRefer.GjejReferMeID(referi);
            txtEmri.Text = referi.Emri;
            txtMbiemri.Text = referi.Mbiemri;
            txtEmriPerdoruesit.Text = referi.EmriIPerdoruesit;
            txtFjalkalimi.Text = referi.Fjalkalimi;
            txtSpecializimi.Text = referi.Specializimi;
            txtTitulli.Text = referi.Titulli;
            txtGjinia.Text = referi.Gjinia;
            txtDitelindja.Text = referi.Ditelindja.ToString();
            txtVendlindja.Text = referi.Vendlindja.ToString();
            txtShteti.Text = referi.Shteti;
            txtVendbanimi.Text = referi.Vendbanimi;
            txtTelefoni.Text = referi.Telefoni.ToString();
            txtEmail.Text = referi.Mail;
            txtPozita.Text = referi.Pozita;
        }

        private void Edito_Click(object sender, EventArgs e)
        {
            Referi referi = new Referi();
            referi.Emri = txtEmri.Text.Trim();
            referi.Mbiemri = txtMbiemri.Text.Trim();
            referi.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
            referi.Fjalkalimi = txtFjalkalimi.Text.Trim();
            referi.Specializimi = txtSpecializimi.Text.Trim();
            referi.Titulli = txtTitulli.Text.Trim();
            referi.Gjinia = txtGjinia.Text.Trim();
            referi.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
            referi.Vendlindja = txtVendlindja.Text.Trim();
            referi.Shteti = txtShteti.Text.Trim();
            referi.Vendbanimi = txtVendbanimi.Text.Trim();
            referi.Telefoni = txtTelefoni.Text.Trim();
            referi.Mail = txtEmail.Text.Trim();
            referi.Pozita = txtPozita.Text.Trim();
            referi.ReferiID = int.Parse(txtKerko.Text.Trim());
            ReferiDAL dal = new ReferiDAL();
            dal.Edito(referi);
        }
    }
}
