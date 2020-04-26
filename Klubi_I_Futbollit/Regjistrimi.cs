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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");
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
            PersoneliDAL obj1 = new PersoneliDAL();
            obj1.Update(personeli);

            

        }
        //public void MbushTeDhena()
        //{
        //    if (sqlcon.State==System.Data.ConnectionState.Closed)
        //    {
        //        sqlcon.Open();
        //        SqlDataAdapter sqlAdapter = new SqlDataAdapter("[dbo].[usp_Personel_MerriTeGjithePersonel]",sqlcon);
        //        sqlAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
        //        DataTable dtbl = new DataTable();
        //        sqlAdapter.Fill(dtbl);
        //        sqlcon.Close();
        //        dgdmbushtedhena.DataSource = dtbl;
        //        _ = dgdmbushtedhena.DataBindings;



        //    }
        //}

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
