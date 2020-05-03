using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klubi_Futbollistik.BO;
using Klubi_;
using Klubi_Futbollistik.DAL;
using Klubi_I_Futbollit.BO;
using System.Data.SqlClient;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class RegjistroLojtar : Form
    {

        public RegjistroLojtar()
        {
            InitializeComponent();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            Lojtari person = new Lojtari();
            person.Emri = txtEmri.Text.Trim();
            person.Mbiemri = txtMbiemri.Text.Trim();
            person.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
            person.Fjalkalimi = txtFjalekalimi.Text.Trim();
            person.NumriFanelles = int.Parse(txtNumriIfanelles.Text.Trim());
            person.Gjinia = txtGjinia.Text.Trim();
            person.Ditelindja =DateTime.Parse(txtDitelindja.Text.Trim());
            person.Vendlindja = txtVendlindja.Text.Trim();
            person.GrupiGjakut = txtGrupigjakut.Text.Trim();
            person.Shteti = txtShtetesia.Text.Trim();
            person.Vendbanimi = txtVendbanimi.Text.Trim();
            person.Telefoni = txtNumriTelefonit.Text.Trim();
            person.Mail = txtEmail.Text.Trim();
            person.Pesha = decimal.Parse(txtPesha.Text.Trim());
            person.Gjatesia = decimal.Parse(txtGjatesia.Text.Trim());
            LojtariDAL dal = new LojtariDAL();
            dal.Shto( person);
        }

        private void btnEditoLojtar_Click(object sender, EventArgs e)
        {
            Lojtari person = new Lojtari();
            person.Emri = txtEmri.Text.Trim();
            person.Mbiemri = txtMbiemri.Text.Trim();
            person.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
            person.Fjalkalimi = txtFjalekalimi.Text.Trim();
            person.NumriFanelles = int.Parse(txtNumriIfanelles.Text.Trim());
            person.Gjinia = txtGjinia.Text.Trim();
            person.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
            person.Vendlindja = txtVendlindja.Text.Trim();
            person.GrupiGjakut = txtGrupigjakut.Text.Trim();
            person.Shteti = txtShtetesia.Text.Trim();
            person.Vendbanimi = txtVendbanimi.Text.Trim();
            person.Telefoni = txtNumriTelefonit.Text.Trim();
            person.Mail = txtEmail.Text.Trim();
            person.Pesha = decimal.Parse(txtPesha.Text.Trim());
            person.Gjatesia = decimal.Parse(txtGjatesia.Text.Trim());
            person.LojtariID = int.Parse(txtShkruajID.Text.Trim());
            LojtariDAL dal = new LojtariDAL();
            dal.Update(person);
        }
        private void btnShfaq_Click(object sender, EventArgs e)
        {
            LojtariDAL obj = new LojtariDAL();
            dgdMbushLojtar.DataSource = obj.GetAll();
        }
        private void BtnGjejLojtart_Click(object sender, EventArgs e)
        {
            Lojtari lojtar =  new Lojtari();
            lojtar.LojtariID= int.Parse(txtShkruajID.Text.Trim());
            LojtariDAL gjejlojtarin = new LojtariDAL();
            gjejlojtarin.GjejLojtarinMeID(lojtar);
            txtEmri.Text = lojtar.Emri;
            txtMbiemri.Text = lojtar.Mbiemri;
            txtEmriPerdoruesit.Text = lojtar.EmriIPerdoruesit;
            txtFjalekalimi.Text = lojtar.Fjalkalimi;
            txtNumriIfanelles.Text = lojtar.NumriFanelles.ToString();
            txtGjinia.Text = lojtar.Gjinia;
            txtDitelindja.Text = lojtar.Ditelindja.ToString();
            txtVendlindja.Text = lojtar.Vendlindja.ToString();
            txtGrupigjakut.Text = lojtar.GrupiGjakut;
            txtShtetesia.Text = lojtar.Shteti;
            txtVendbanimi.Text = lojtar.Vendbanimi;
            txtNumriTelefonit.Text = lojtar.Telefoni.ToString();
            txtEmail.Text = lojtar.Mail;
            txtPesha.Text = lojtar.Pesha.ToString();
            txtGjatesia.Text = lojtar.Gjatesia.ToString();
            btnFshijLojtarin.Visible = true;
            btnEditoLojtar.Visible = true;
            btnRegjistro.Visible = false;
            btnShfaq.Visible = false;
        }
        private void BtnFshijLojtarin_Click(object sender, EventArgs e)
        {
            Lojtari lojtari = new Lojtari();
            lojtari.LojtariID = int.Parse(txtShkruajID.Text.Trim());
            LojtariDAL Fshijlojtari = new LojtariDAL();
            Fshijlojtari.Fshij(lojtari);
        }
    }
}
