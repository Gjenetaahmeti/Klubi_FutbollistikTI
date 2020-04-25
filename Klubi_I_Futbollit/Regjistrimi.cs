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
            // personeli.Gjinia = bool.Parse(txtGjinia.Text);
            // personeli.Ditelindja = DateTime.Parse(txtDitelindja.Text);
            personeli.Vendlindja = txtVendlindja.Text.Trim();
            personeli.GrupiIGjakut = txtGrupiGjakut.Text.Trim();
            personeli.Shteti = txtShteti.Text.Trim();
            personeli.Vendbanimi = txtVendbanimi.Text.Trim();
            personeli.Telefoni = txtNrKontaktues.Text.Trim();
            personeli.Mail = txtMail.Text.Trim();
            personeli.AnetaretEGrupit = txtAnetariGrupit.Text.Trim();
            personeli.NderrimiIPunes = txtNdrrimiPunes.Text.Trim();
            PersoneliDAL obj = new PersoneliDAL();
            obj.Shto(personeli);
        }
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
