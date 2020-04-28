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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");

        public string T = "";
        public RegjistroLojtar()
        {
            InitializeComponent();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            Personeli person = new Personeli();
            person.Emri = txtEmri.Text.Trim();
            person.Mbiemri = txtMbiemri.Text.Trim();
            person.Gjinia = txtGjinia.Text.Trim();
            person.Vendlindja = txtVendlindja.Text.Trim();
            person.GrupiIGjakut = txtGrupigjakut.Text.Trim();
            person.Shteti = txtShtetesia.Text.Trim();
            person.Vendbanimi = txtVendbanimi.Text.Trim();
            person.Telefoni = txtNumriTelefonit.Text.Trim();
            person.Mail = txtEmail.Text.Trim();
            Lojtari lojtari = new Lojtari();
            lojtari.Pesha = decimal.Parse(txtPesha.Text.Trim());
            lojtari.Gjatesia = decimal.Parse(txtGjatesia.Text.Trim());
            LojtariDAL dal = new LojtariDAL();
            dal.Shto(person, lojtari);
        }

        private void btnEditoLojtar_Click(object sender, EventArgs e)
        {
            Personeli person = new Personeli();
            person.Emri = txtEmri.Text.Trim();
            person.Mbiemri = txtMbiemri.Text.Trim();
            person.Gjinia = txtGjinia.Text.Trim();
            person.Vendlindja = txtVendlindja.Text.Trim();
            person.GrupiIGjakut = txtGrupigjakut.Text.Trim();
            person.Shteti = txtShtetesia.Text.Trim();
            person.Vendbanimi = txtVendbanimi.Text.Trim();
            person.Telefoni = txtNumriTelefonit.Text.Trim();
            person.Mail = txtEmail.Text.Trim();
            Lojtari lojtari = new Lojtari();
            lojtari.Pesha = decimal.Parse(txtPesha.Text.Trim());
            lojtari.Gjatesia = decimal.Parse(txtGjatesia.Text.Trim());
            LojtariDAL dal = new LojtariDAL();
            dal.Update(person, lojtari);
        }

      

        private void MbushLojtarT()
        {
            sqlcon.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[MerriLojtarimePerson]", sqlcon);
            sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlAdapter.Fill(dtbl);
            sqlAdapter.Dispose();
            sqlcon.Close();
            dgdMbushLojtar.DataSource = dtbl;
            T = dtbl.Rows[0]["LojtariID"].ToString();
        }

        private void dgdMbushLojtar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
            MbushLojtarT();
        }
        private void editoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgdMbushLojtar.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(index + 1);
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[MerriLojtartMePerson_MeID]", sqlcon);
                sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlAdapter.SelectCommand.Parameters.AddWithValue("@LojtariID", int.Parse(T));
                DataTable dtbl = new DataTable();
                sqlAdapter.Fill(dtbl);
                sqlAdapter.Dispose();
                sqlcon.Close();
                txtEmri.Text = dtbl.Rows[0]["Emri"].ToString();
                txtMbiemri.Text = dtbl.Rows[0]["Mbiemri"].ToString();
                txtGjinia.Text = dtbl.Rows[0]["Gjinia"].ToString();
                txtVendlindja.Text = dtbl.Rows[0]["Vendlindja"].ToString();
                txtGrupigjakut.Text = dtbl.Rows[0]["GrupiGjakut"].ToString();
                txtShtetesia.Text = dtbl.Rows[0]["Shteti"].ToString();
                txtVendbanimi.Text = dtbl.Rows[0]["VendBanimi"].ToString();
                txtNumriTelefonit.Text = dtbl.Rows[0]["Telefoni"].ToString();
                txtEmail.Text = dtbl.Rows[0]["Mail"].ToString();
                txtPesha.Text = dtbl.Rows[0]["Pesha"].ToString();
                txtGjatesia.Text = dtbl.Rows[0]["Gjatesia"].ToString();

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
