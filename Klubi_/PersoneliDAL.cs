using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Klubi_Futbollistik.BO.Interface;
using Klubi_I_Futbollit.BO;

namespace Klubi_Futbollistik.DAL
{
    public class PersoneliDAL:CRUD<Personeli>
    {
        //  public string _connectionstring = ConfigurationManager.ConnectionStrings["KlubiFutbollistikTI1"].ConnectionString; 
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");


        //SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");

        public int Shto(Personeli model)
        {

            sqlcon.Open();
            SqlCommand command = new SqlCommand("[dbo].[usp_Personel_UpdatePersonel]", sqlcon);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersoneliID", model.ID);
            command.Parameters.AddWithValue("@Emri", model.Emri);
            command.Parameters.AddWithValue("@Mbiemri", model.Mbiemri);
            command.Parameters.AddWithValue("@Specializimi", model.Specializimi);
            command.Parameters.AddWithValue("@Titulli", model.Titulli);
            command.Parameters.AddWithValue("@VendiIPunes", model.VendiIPunes);
            command.Parameters.AddWithValue("@Gjinia", model.Gjinia);
            command.Parameters.AddWithValue("@Vendlindja", model.Vendlindja);
            command.Parameters.AddWithValue("@GrupiGjakut", model.GrupiIGjakut);
            command.Parameters.AddWithValue("@Shteti", model.Shteti);
            command.Parameters.AddWithValue("@VendBanimi", model.Vendbanimi);
            command.Parameters.AddWithValue("@Telefoni", model.Telefoni);
            command.Parameters.AddWithValue("@Mail", model.Mail);
            
            int rowAffected = command.ExecuteNonQuery();
                command.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
                return rowAffected;
          
        }
        public int Fshij(Personeli model)
        {
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Personel_FshijPersonel", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersoneliID", model.ID);
                int result=command.ExecuteNonQuery();
                command.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
                return result;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public List<Personeli> GetAll()
        {
            try
            {
                List<Personeli> rezultati = null;
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Personel_MerriTeGjithePersonel]", sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                rezultati = new List<Personeli>();
                while (reader.Read())
                {
                    Personeli personeli = TooObject(reader);
                    rezultati.Add(personeli);
                }
                return rezultati;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Personeli TooObject(SqlDataReader reader)
        {
            Personeli personeli = new Personeli();
            personeli.ID = int.Parse(reader["ID"].ToString());
            personeli.Mbiemri = reader["Mbiemri"].ToString();
            personeli.Specializimi = reader["Specializimi"].ToString();
            personeli.Titulli = reader["Titulli"].ToString();
            personeli.VendiIPunes = reader["VendiIPunes"].ToString();
            personeli.Gjinia = reader["Gjinia"].ToString();
            personeli.Vendlindja = reader["Vendlindja"].ToString();
            personeli.GrupiIGjakut = reader["GrupiIGjakut"].ToString();
            personeli.Shteti = reader["Shteti"].ToString();
            personeli.Vendbanimi = reader["Vendbanimi"].ToString();
            personeli.Telefoni = reader["Telefoni"].ToString();
            personeli.Mail = reader["Mail"].ToString();
            personeli.InsertBy = int.Parse(reader["InsertBy"].ToString());
            personeli.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());
            personeli.LUB = int.Parse(reader["LUB"].ToString());
            personeli.LUN = int.Parse(reader["LUN"].ToString());
            personeli.LUD = DateTime.Parse(reader["LUD"].ToString());
            return personeli;
        }
        

        public int Update(Personeli model)
        {
            try
            {
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

                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Personeli_EditoPersonel]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", model.ID);
                command.Parameters.AddWithValue("@Emri", model.Emri);
                command.Parameters.AddWithValue("@Mbiemri", model.Mbiemri);
                command.Parameters.AddWithValue("@Specializimi", model.Specializimi);
                command.Parameters.AddWithValue("@Titulli", model.Titulli);
                command.Parameters.AddWithValue("@VendiIPunes", model.VendiIPunes);
                command.Parameters.AddWithValue("@Gjinia", model.Gjinia);
                command.Parameters.AddWithValue("@Vendlindja", model.Vendlindja);
                command.Parameters.AddWithValue("@GrupiIGjakut", model.GrupiIGjakut);
                command.Parameters.AddWithValue("@Shteti", model.Shteti);
                command.Parameters.AddWithValue("@VendBanimi", model.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", model.Telefoni);
                command.Parameters.AddWithValue("@Mail", model.Mail);
                int rowAffected = command.ExecuteNonQuery();
                command.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
                return rowAffected;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}
