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
using Klubi_Futbollistik;
using Klubi_I_Futbollit.BO;


namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoDelegat : Form
    {
        public MenaxhoDelegat()
        {
            InitializeComponent();
        }

        private void Btnregjistrodelegat_Click(object sender, EventArgs e)
        {
            Delegat delegat = new Delegat();
            delegat.Emri = txtEmri.Text.Trim();
            delegat.Mbiemri = txtMbiemri.Text.Trim();
            delegat.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
            delegat.Fjalkalimi = txtFjalkalimi.Text.Trim();
            delegat.Specializimi = txtSpecializimi.Text.Trim();
            delegat.Titulli = txtTitulli.Text.Trim();
            delegat.Gjinia = txtGjinia.Text.Trim();
            delegat.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
            delegat.Vendlindja = txtVendlindja.Text.Trim();
            delegat.Shteti = txtShteti.Text.Trim();
            delegat.Vendbanimi = txtVendbanimi.Text.Trim();
            delegat.Telefoni = txtTelefoni.Text.Trim();
            delegat.Mail = txtEmail.Text.Trim();

            delegat.Roli = txtRoli.Text.Trim();
            delegat.RaportiPasNdeshjes = txtRaportiPasndeshjes.Text.Trim();
            DelegatDAL del = new DelegatDAL();
            del.Shto(delegat);
        }

        private void BtnShfaqDelegat_Click(object sender, EventArgs e)
        {
            DelegatDAL obj = new DelegatDAL ();
            dgvMbushDelegat.DataSource = obj.GetAll();
        }

        private void BtnEdito_Click_1(object sender, EventArgs e)
        {
            Delegat delegat = new Delegat();
            delegat.Emri = txtEmri.Text.Trim();
            delegat.Mbiemri = txtMbiemri.Text.Trim();
            delegat.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
            delegat.Fjalkalimi = txtFjalkalimi.Text.Trim();
            delegat.Specializimi = txtSpecializimi.Text.Trim();
            delegat.Titulli = txtTitulli.Text.Trim();
            delegat.Gjinia = txtGjinia.Text.Trim();
            delegat.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
            delegat.Vendlindja = txtVendlindja.Text.Trim();
            delegat.Shteti = txtShteti.Text.Trim();
            delegat.Vendbanimi = txtVendbanimi.Text.Trim();
            delegat.Telefoni = txtTelefoni.Text.Trim();
            delegat.Mail = txtEmail.Text.Trim();
            delegat.Roli = txtRoli.Text.Trim();
            delegat.RaportiPasNdeshjes = txtRaportiPasndeshjes.Text.Trim();
          //  delegat.DelegatID = int.Parse(txtIdEDelegatit.Text.Trim());
            delegat.DelegatID = int.Parse(txtShkruajID.Text.Trim());
            DelegatDAL del = new DelegatDAL();
            del.Update(delegat);
        }

        private void BtnKerko_Click_1(object sender, EventArgs e)
        {
            Delegat delegat = new Delegat();
            delegat.DelegatID = int.Parse(txtShkruajID.Text.Trim());
            DelegatDAL gjejdelegat = new DelegatDAL();
            gjejdelegat.GjejDelegatMeID(delegat);
            txtEmri.Text = delegat.Emri;
            txtMbiemri.Text = delegat.Mbiemri;
            txtEmriPerdoruesit.Text = delegat.EmriIPerdoruesit;
            txtFjalkalimi.Text = delegat.Fjalkalimi;
            txtSpecializimi.Text = delegat.Specializimi;
            txtTitulli.Text = delegat.Titulli;
            txtGjinia.Text = delegat.Gjinia;
            txtDitelindja.Text = delegat.Ditelindja.ToString();
            txtVendlindja.Text = delegat.Vendlindja.ToString();
            txtShteti.Text = delegat.Shteti;
            txtVendbanimi.Text = delegat.Vendbanimi;
            txtTelefoni.Text = delegat.Telefoni.ToString();
            txtEmail.Text = delegat.Mail;

   
        }

        private void BtnfshijDelegat_Click(object sender, EventArgs e)
        {
            Delegat delegat = new Delegat();
            delegat.DelegatID = int.Parse(txtShkruajID.Text.Trim());
            DelegatDAL fshijdelegat = new DelegatDAL();
            fshijdelegat.Fshij(delegat);
        }




    }
}

