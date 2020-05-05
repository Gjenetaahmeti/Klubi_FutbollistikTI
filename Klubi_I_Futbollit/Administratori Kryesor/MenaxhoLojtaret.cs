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
using Klubi_I_Futbollit.BLL;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoLojtaret : Form
    {

        public MenaxhoLojtaret()
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
            LojtariBLL lojtariBLL = new LojtariBLL();
            lojtariBLL.Regjistro(person);
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
            LojtariBLL lojtariEditoBll = new LojtariBLL();
            lojtariEditoBll.Edito(person);
        }
        private void btnShfaq_Click(object sender, EventArgs e)
        {
            //LojtariDAL obj = new LojtariDAL();
            //dgdMbushLojtar.DataSource = obj.GetAll();

            LojtariBLL lojtariShfaqja = new LojtariBLL();
            dgdMbushLojtar.DataSource = lojtariShfaqja.ShfaqLojtaret();
        }
        private void BtnGjejLojtart_Click(object sender, EventArgs e)
        {
            Lojtari lojtar =  new Lojtari();
            lojtar.LojtariID= int.Parse(txtShkruajID.Text.Trim());
            LojtariBLL gjejLojtarin = new LojtariBLL();
            gjejLojtarin.GjejLojtarMeID(lojtar);
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
            LojtariBLL lojtariBLL = new LojtariBLL();
            lojtariBLL.Fshij(lojtari);
        }

        private void MenaxhoPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoPersonelin personelin = new Administratori_Kryesor.MenaxhoPersonelin())
            {

                personelin.ShowDialog();
            }
        }

        private void MenaxhoTrajnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoTrajner trajneri = new Administratori_Kryesor.MenaxhoTrajner())
            {

                trajneri.ShowDialog();
            }
        }

        private void MenaxhoNdeshjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoNdeshje ndeshje = new Administratori_Kryesor.MenaxhoNdeshje())
            {

                ndeshje.ShowDialog();
            }
        }

        private void MenaxhoFormacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Formacionet formacionet = new Formacionet())
            {

                formacionet.ShowDialog();
            }
        }

        private void MenaxhoGolashenuesinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoGolashenuesin golashenuesi = new Administratori_Kryesor.MenaxhoGolashenuesin())
            {

                golashenuesi.ShowDialog();
            }
        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoDelegat delegat = new Administratori_Kryesor.MenaxhoDelegat())
            {

                delegat.ShowDialog();
            }
        }

        private void MenaxhoKluibnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Administratori_Kryesor.MenaxhoKlub klub = new Administratori_Kryesor.MenaxhoKlub())
            {

                klub.ShowDialog();
            }
        }

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(MenyKryefaqja mk =new MenyKryefaqja())
            {
                mk.ShowDialog();
            }
        }
    }
}
