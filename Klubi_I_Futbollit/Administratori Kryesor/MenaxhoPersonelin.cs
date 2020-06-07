using Klubi_Futbollistik.BLL;
using Klubi_I_Futbollit.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klubi_I_Futbollit.Administratori_Kryesor
{
    public partial class MenaxhoPersonelin : Form
    {
        public MenaxhoPersonelin()
        {
            InitializeComponent();
            GjejPersonelin();
        }



        private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenyKryefaqja menyKryefaqja = new MenyKryefaqja();
            menyKryefaqja.ShowDialog();
        }

        private void MenaxhoTrajnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoTrajner menaxhoTrajner = new MenaxhoTrajner();
            menaxhoTrajner.ShowDialog();
        }

        private void MenaxhoLojtarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoLojtaret menaxhoLojtaret = new MenaxhoLojtaret();
            menaxhoLojtaret.ShowDialog();
        }

        private void MenaxhoNdeshjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoNdeshje menaxhoNdeshje = new MenaxhoNdeshje();
            menaxhoNdeshje.ShowDialog();
        }

        private void MenaxhoFormacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formacionet formacionet = new Formacionet();
            formacionet.ShowDialog();
        }

        private void MenaxhoGolashenuesinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoGolashenuesin menaxhoGolashenuesin = new MenaxhoGolashenuesin();
            menaxhoGolashenuesin.ShowDialog();
        }

        private void MenaxhoDelegatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoDelegat menaxhoDelegat = new MenaxhoDelegat();
            menaxhoDelegat.ShowDialog();
        }

        private void MenaxhoKluibnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoKlub menaxhoKlub = new MenaxhoKlub();
            menaxhoKlub.ShowDialog();
        }

        private void MenaxhoUshtrimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoUshtrime menaxhoUshtrime = new MenaxhoUshtrime();
            menaxhoUshtrime.ShowDialog();
        }

        private void MenaxhoVleresimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenaxhoVlersimet menaxhoVlersimet = new MenaxhoVlersimet();
            menaxhoVlersimet.ShowDialog();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtEmriPerdoruesit.Text == "" || txtFjalekalimi.Text == ""
                 || txtGjinia.Text == "" || txtDitelindja.Text == "" || txtVendlindja.Text == "" || txtGrupigjakut.Text == "" ||
                 txtShtetesia.Text == "" || txtVendbanimi.Text == "" || txtShtetesia.Text == ""
                 || txtEmail.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha fushat");

            }
            else
            {
                var personelicm = cmbRolet.SelectedValue.ToString(); 
                Personeli person = new Personeli();
                person.Emri = txtEmri.Text.Trim();
                person.Mbiemri = txtMbiemri.Text.Trim();
                person.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                person.Fjalkalimi = txtFjalekalimi.Text.Trim();
                person.Gjinia = txtGjinia.Text.Trim();
                person.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                person.Vendlindja = txtVendlindja.Text.Trim();
                person.GrupiGjakut = txtGrupigjakut.Text.Trim();
                person.Shteti = txtShtetesia.Text.Trim();
                person.Vendbanimi = txtVendbanimi.Text.Trim();
                person.Telefoni = txtNumriTelefonit.Text.Trim();
                person.Mail = txtEmail.Text.Trim();

                PersoneliBLL personeliBLL = new PersoneliBLL();
                personeliBLL.Regjistro(person);

                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalekalimi.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtGrupigjakut.Text = txtShtetesia.Text =
                    txtVendbanimi.Text = txtNumriTelefonit.Text = txtEmail.Text = "";
                MessageBox.Show("U regjistrua me sukses");

            }
        }
        public void GjejPersonelin()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=Gjeneta;Integrated Security=True");
            sqlcon.Open();
            SqlDataAdapter d = new SqlDataAdapter("[dbo].[usp_Role_MerrtegjithaRolet]", sqlcon);
            DataSet dt = new DataSet();
            d.Fill(dt);
            if (dt.Tables[0].Rows.Count > 0)
            {
                cmbRolet.DataSource = dt.Tables[0];
                cmbRolet.DisplayMember = "EmriIRolit";
                cmbRolet.ValueMember = "RoliId";
            }
            else
            {
                MessageBox.Show("Asnje personel nuk eshte gjetur");
            }
        }
        private void btnEditoLojtar_Click(object sender, EventArgs e)
        {
            var rez = MessageBox.Show("A jeni te sigurt qe deshironi te editoni", "Kujdes", MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {

                Personeli person = new Personeli();
                person.Emri = txtEmri.Text.Trim();
                person.Mbiemri = txtMbiemri.Text.Trim();
                person.EmriIPerdoruesit = txtEmriPerdoruesit.Text.Trim();
                person.Fjalkalimi = txtFjalekalimi.Text.Trim();
                person.Gjinia = txtGjinia.Text.Trim();
                person.Ditelindja = DateTime.Parse(txtDitelindja.Text.Trim());
                person.Vendlindja = txtVendlindja.Text.Trim();
                person.GrupiGjakut = txtGrupigjakut.Text.Trim();
                person.Shteti = txtShtetesia.Text.Trim();
                person.Vendbanimi = txtVendbanimi.Text.Trim();
                person.Telefoni = txtNumriTelefonit.Text.Trim();
                person.Mail = txtEmail.Text.Trim();
                person.PersonelID = int.Parse(txtKerkoMeID.Text.Trim());
                PersoneliBLL personeliBLL = new PersoneliBLL();
                personeliBLL.Edito(person);

                txtEmri.Text = txtMbiemri.Text = txtEmriPerdoruesit.Text = txtFjalekalimi.Text = txtGjinia.Text = txtDitelindja.Text = txtVendlindja.Text = txtGrupigjakut.Text = txtShtetesia.Text =
                    txtVendbanimi.Text = txtNumriTelefonit.Text = txtEmail.Text ="";
            }
        }
    }
}
