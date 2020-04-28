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
    public partial class RegjistrimiPersonelit : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");

        public RegjistrimiPersonelit()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
       //     SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");
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
        }
        private void dgdmbushtedhena_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==19)
            {
                MessageBox.Show((e.RowIndex+1).ToString()+" Gjenta click");
                int id = Convert.ToInt32(e.RowIndex+1);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[usp_Personel_PersonelID]", sqlcon);
                sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlAdapter.SelectCommand.Parameters.AddWithValue("@ID", id);
                DataTable dtbl = new DataTable();
                sqlAdapter.Fill(dtbl);
                sqlcon.Close();
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
                btnRegjistroPersonel.Text = "Ndrysho";

            }

        }
        public void MbushTeDhena()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");
            sqlcon.Open();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[usp_Personel_MerriTeGjithePersonel]", sqlcon);
                sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable dtbl = new DataTable();
                sqlAdapter.Fill(dtbl);
                sqlAdapter.Dispose();
                sqlcon.Close();
                dgdmbushtedhena.DataSource = dtbl;

                //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                //btn.HeaderText = "Buttons";
                //btn.Name = "btnEdito";
                //btn.Text = "Edito";
                //btn.UseColumnTextForButtonValue = true;
                
                //dgdmbushtedhena.Columns.Add(btn);
                //DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
           
                //btn2.Name = "btnFshij";
                //btn2.Text = "Fshij";
                //btn2.UseColumnTextForButtonValue = true;

                //dgdmbushtedhena.Columns.Add(btn2);
            
        }
        


      //private void btnEditoPersonelin_Click(object sender, EventArgs e)
      //  {
      //      Personeli person = new Personeli();
      //      if (sqlcon.State == System.Data.ConnectionState.Closed)
      //      {
      //          sqlcon.Open();
      //          SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[usp_Personel_MerriTeGjithePersonel]", sqlcon);
      //          sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
      //          DataTable dtbl = new DataTable();
      //          sqlAdapter.Fill(dtbl);
      //          sqlcon.Close();
      //          SqlDataAdapter sqlDa = new SqlDataAdapter("usp_Personeli_EditoPersonel", sqlcon);
      //          sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
      //          sqlDa.SelectCommand.Parameters.AddWithValue("@ID", person.ID);
      //          dgdmbushtedhena.DataSource = dtbl;
      //          txtEmri.Text = dtbl.Rows[0]["Emri"].ToString();
      //          txtMbiemri.Text = dtbl.Rows[0]["Mbiemri"].ToString();
      //          txtSpecializimi.Text = dtbl.Rows[0]["Specializimi"].ToString();
      //          txtTitulli.Text = dtbl.Rows[0]["Titulli"].ToString();
      //          txtVendiIPunes.Text = dtbl.Rows[0]["VendiPunes"].ToString();
      //          txtGjinia.Text = dtbl.Rows[0]["Gjinia"].ToString();
      //          txtVendlindja.Text = dtbl.Rows[0]["Vendlindja"].ToString();
      //          txtGrupiGjakut.Text = dtbl.Rows[0]["GrupiGjakut"].ToString();
      //          txtShteti.Text = dtbl.Rows[0]["Shteti"].ToString();
      //          txtVendbanimi.Text = dtbl.Rows[0]["VendBanimi"].ToString();
      //          txtNrKontaktues.Text = dtbl.Rows[0]["Telefoni"].ToString();
      //          txtMail.Text = dtbl.Rows[0]["Mail"].ToString();
      //          btnEditoPersonelin.Text = "Ruaj Te Dhenat";
      //      }
      //  }

        private void editoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnUpdate.Enabled = true;
            int index = dgdmbushtedhena.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(index + 1);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[usp_Personel_PersonelID]", sqlcon);
            sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlAdapter.SelectCommand.Parameters.AddWithValue("@ID", id);
            DataTable dtbl = new DataTable();
            sqlAdapter.Fill(dtbl);
            sqlAdapter.Dispose();
            sqlcon.Close();
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Personeli personeli = new Personeli();

            int index = dgdmbushtedhena.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(index + 1);
            personeli.ID = id;
            personeli.Emri = txtEmri.Text.Trim();
            personeli.Mbiemri = txtMbiemri.Text.Trim();
            personeli.Specializimi = txtSpecializimi.Text.Trim();
            personeli.Titulli = txtTitulli.Text.Trim();
            personeli.VendiIPunes = txtVendiIPunes.Text.Trim();
            personeli.Gjinia = txtGjinia.Text.Trim();
            personeli.Vendlindja = txtVendlindja.Text.Trim();
            personeli.GrupiIGjakut = txtGrupiGjakut.Text.Trim();
            personeli.Shteti = txtShteti.Text.Trim();
            personeli.Vendbanimi = txtVendbanimi.Text.Trim();
            personeli.Telefoni = txtNrKontaktues.Text.Trim();
            personeli.Mail = txtMail.Text.Trim();
            PersoneliDAL obj = new PersoneliDAL();
            obj.Update(personeli);

            //sqlcon.Open();
            //SqlCommand command = new SqlCommand("[dbo].[usp_Personeli_EditoPersonel]", sqlcon);
            //command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@ID", id);
            //command.Parameters.AddWithValue("@Emri", txtEmri.Text);
            //command.Parameters.AddWithValue("@Mbiemri", txtMbiemri.Text);
            //command.Parameters.AddWithValue("@Specializimi", txtSpecializimi.Text);
            //command.Parameters.AddWithValue("@Titulli", txtTitulli.Text);
            //command.Parameters.AddWithValue("@VendiIPunes", txtVendiIPunes.Text);
            //command.Parameters.AddWithValue("@Gjinia", txtGjatesia.Text);
            //command.Parameters.AddWithValue("@Vendlindja", txtVendlindja.Text);
            //command.Parameters.AddWithValue("@GrupiIGjakut", txtGrupiGjakut.Text);
            //command.Parameters.AddWithValue("@Shteti", txtShteti.Text);
            //command.Parameters.AddWithValue("@VendBanimi", txtVendbanimi.Text);
            //command.Parameters.AddWithValue("@Telefoni", txtNrKontaktues.Text);
            //command.Parameters.AddWithValue("@Mail", txtMail.Text);
            //command.ExecuteNonQuery();
            //command.Dispose();
            //sqlcon.Close();
            //sqlcon.Dispose();
        }
        private void fshijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgdmbushtedhena.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(index + 1);
            

            Personeli person = new Personeli();
            person.ID = id;
            PersoneliDAL obj = new PersoneliDAL();
            obj.Fshij(person);
        }
    }
}
