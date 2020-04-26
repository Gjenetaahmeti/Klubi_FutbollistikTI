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
using Klubi_Futbollistik.BO;
using Klubi_Futbollistik.DAL;
using Klubi_I_Futbollit.BO;

namespace Klubi_I_Futbollit
{
    public partial class Regjistrimi : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");
        public Regjistrimi()
        {
            InitializeComponent();
        }

        private void btnRegjistroPersonel_Click(object sender, EventArgs e)
        {
           // SHto();
            Personeli personeli = new Personeli();
            personeli.Emri = txtEmri.Text.Trim();
            personeli.Mbiemri = txtMbiemri.Text.Trim();
            personeli.Specializimi = txtSpecializimi.Text.Trim();
            personeli.Titulli = txtTitulli.Text.Trim();
            personeli.VendiIPunes = txtVendiIPunes.Text.Trim();
             personeli.Gjinia = txtGjinia.Text.Trim();
            // personeli.Ditelindja = DateTime.Parse(txtDitelindja.Text);
            personeli.Vendlindja = txtVendlindja.Text.Trim();
            personeli.GrupiIGjakut = txtGrupiGjakut.Text.Trim();
            personeli.Shteti = txtShteti.Text.Trim();
            personeli.Vendbanimi = txtVendbanimi.Text.Trim();
            personeli.Telefoni = txtNrKontaktues.Text.Trim();
            personeli.Mail = txtMail.Text.Trim();
            PersoneliDAL obj = new PersoneliDAL();
            obj.Shto(personeli);
        }

        private void BtnEdito_Click(object sender, EventArgs e)
        {


            MbushTeDhena();
           // Edito();
            //Personeli personeli = new Personeli();
            //personeli.Emri = txtEmri.Text.Trim();
            //personeli.Mbiemri = txtMbiemri.Text.Trim();
            //personeli.Specializimi = txtSpecializimi.Text.Trim();
            //personeli.Titulli = txtTitulli.Text.Trim();
            //personeli.VendiIPunes = txtVendiIPunes.Text.Trim();
            //personeli.Gjinia = txtGjinia.Text.Trim();
            //// personeli.Ditelindja = DateTime.Parse(txtDitelindja.Text);
            //personeli.Vendlindja = txtVendlindja.Text.Trim();
            //personeli.GrupiIGjakut = txtGrupiGjakut.Text.Trim();
            //personeli.Shteti = txtShteti.Text.Trim();
            //personeli.Vendbanimi = txtVendbanimi.Text.Trim();
            //personeli.Telefoni = txtNrKontaktues.Text.Trim();
            //personeli.Mail = txtMail.Text.Trim();
            //PersoneliDAL obj1 = new PersoneliDAL();
            //obj1.Update(personeli);

            Personeli personeli = new Personeli();
            txtEmri.Text = personeli.Emri;



        }

        private void dgdmbushtedhena_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MbushTeDhena()
        {
            if (sqlcon.State == System.Data.ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[usp_Personel_MerriTeGjithePersonel]", sqlcon);
                sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlAdapter.Fill(dtbl);
                sqlcon.Close();
                dgdmbushtedhena.DataSource = dtbl;

            }
        }
        private void Edito()
        {
            //Personeli person = new Personeli();
            //if (sqlcon.State == ConnectionState.Closed)
            //    sqlcon.Open();
            //SqlDataAdapter sqlDa = new SqlDataAdapter("usp_Personeli_EditoPersonel", sqlcon);
            //sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sqlDa.SelectCommand.Parameters.AddWithValue("@ID", person.ID);
            //DataTable dtbl = new DataTable();
            //sqlDa.Fill(dtbl);
            //sqlcon.Close();
            //txtEmri.Text = dtbl.Rows[0]["Emri"].ToString();
            //txtMbiemri.Text = dtbl.Rows[0]["Mbiemri"].ToString();
            //txtSpecializimi.Text = dtbl.Rows[0]["Specializimi"].ToString();
            //txtTitulli.Text = dtbl.Rows[0]["Titulli"].ToString();
            //txtVendiIPunes.Text = dtbl.Rows[0]["VendiIPunes"].ToString();
            //txtGjinia.Text = dtbl.Rows[0]["Gjinia"].ToString();
            //txtVendlindja.Text = dtbl.Rows[0]["Vendlindja"].ToString();
            //txtGrupiGjakut.Text = dtbl.Rows[0]["GrupiGjakut"].ToString();
            //txtShteti.Text = dtbl.Rows[0]["Shteti"].ToString();
            //txtVendbanimi.Text = dtbl.Rows[0]["VendBanimi"].ToString();
            //txtNrKontaktues.Text = dtbl.Rows[0]["Telefoni"].ToString();
            //txtMail.Text = dtbl.Rows[0]["Mail"].ToString();
        }

        private void btnEditoPersonelin_Click(object sender, EventArgs e)
        {
            Personeli person = new Personeli();
            if (sqlcon.State == System.Data.ConnectionState.Closed)
            {
                sqlcon.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[usp_Personel_MerriTeGjithePersonel]", sqlcon);
                sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlAdapter.Fill(dtbl);
                sqlcon.Close();
                SqlDataAdapter sqlDa = new SqlDataAdapter("usp_Personeli_EditoPersonel", sqlcon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@ID", person.ID);
                dgdmbushtedhena.DataSource = dtbl;
                txtEmri.Text = dtbl.Rows[0]["Emri"].ToString();
                txtMbiemri.Text = dtbl.Rows[0]["Mbiemri"].ToString();
                txtSpecializimi.Text = dtbl.Rows[0]["Specializimi"].ToString();
                txtTitulli.Text = dtbl.Rows[0]["Titulli"].ToString();
                txtVendiIPunes.Text = dtbl.Rows[0]["VendiPunes"].ToString();
                txtGjinia.Text = dtbl.Rows[0]["Gjinia"].ToString();
                txtVendlindja.Text = dtbl.Rows[0]["Vendlindja"].ToString();
                txtGrupiGjakut.Text = dtbl.Rows[0]["GrupiGjakut"].ToString();
                txtShteti.Text = dtbl.Rows[0]["Shteti"].ToString();
                txtVendbanimi.Text = dtbl.Rows[0]["VendBanimi"].ToString();
                txtNrKontaktues.Text = dtbl.Rows[0]["Telefoni"].ToString();
                txtMail.Text = dtbl.Rows[0]["Mail"].ToString();
                btnEditoPersonelin.Text = "Ruaj Te Dhenat";
            }
        }

        private void editoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgdmbushtedhena.SelectedCells[0].RowIndex;

            MessageBox.Show(index.ToString());

            //sqlcon.Open();
            //SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[usp_Personel_MerriTeGjithePersonel]", sqlcon);
            //sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //DataTable dtbl = new DataTable();
            //sqlAdapter.Fill(dtbl);
            //sqlcon.Close();
            //dgdmbushtedhena.DataSource = dtbl;
            //txtEmri.Text = dtbl.Rows[0]["Emri"].ToString();
            //txtMbiemri.Text = dtbl.Rows[0]["Mbiemri"].ToString();
            //txtSpecializimi.Text = dtbl.Rows[0]["Specializimi"].ToString();
            //txtTitulli.Text = dtbl.Rows[0]["Titulli"].ToString();
            //txtVendiIPunes.Text = dtbl.Rows[0]["VendiPunes"].ToString();
            //txtGjinia.Text = dtbl.Rows[0]["Gjinia"].ToString();
            //txtVendlindja.Text = dtbl.Rows[0]["Vendlindja"].ToString();
            //txtGrupiGjakut.Text = dtbl.Rows[0]["GrupiGjakut"].ToString();
            //txtShteti.Text = dtbl.Rows[0]["Shteti"].ToString();
            //txtVendbanimi.Text = dtbl.Rows[0]["VendBanimi"].ToString();
            //txtNrKontaktues.Text = dtbl.Rows[0]["Telefoni"].ToString();
            //txtMail.Text = dtbl.Rows[0]["Mail"].ToString();
        }
        //  private void 
        //private void SHto()
        //{
        //    SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=KlubiFutbollistikTI1;Integrated Security=True");
        //    sqlcon.Open();
        //    SqlCommand command = new SqlCommand("shto", sqlcon);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@Emri", txtEmri.Text.Trim());
        //    command.Parameters.AddWithValue("@Mbiemri", txtMbiemri.Text.Trim());
        //    command.ExecuteNonQuery();
        //    sqlcon.Close();
        //}
    }
}
