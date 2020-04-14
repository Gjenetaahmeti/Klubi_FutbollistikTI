using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Klubi_Futbollistik.BO;
using Klubi_Futbollistik.BO.Interface;

namespace Klubi_Futbollistik.DAL
{
    class PersoneliDAL:CRUD<PersoneliBO>
    {
        public string _connectionstring = ConfigurationManager.ConnectionStrings["KlubiFutbollistikTI1"].ConnectionString; 
        public int Shto(PersoneliBO model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Personel_ShtoPersonel", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emri", model.Emri);
                command.Parameters.AddWithValue("Mbiemri", model.Mbiemri);
                command.Parameters.AddWithValue("Specializimi", model.Specializimi);
                command.Parameters.AddWithValue("Titulli", model.Titulli);
                command.Parameters.AddWithValue("VendiIPunes", model.VendiIPunes);
                command.Parameters.AddWithValue("Gjinia", model.Gjinia);
                command.Parameters.AddWithValue("Ditelindja", model.Ditelindja);
                command.Parameters.AddWithValue("GrupiIGjakut", model.GrupiIGjakut);
                command.Parameters.AddWithValue("Shteti", model.Shteti);
                command.Parameters.AddWithValue("Vendbanimi", model.Vendbanimi);
                command.Parameters.AddWithValue("Telefoni", model.Telefoni);
                command.Parameters.AddWithValue("Mail", model.Mail);
                command.Parameters.AddWithValue("AnetareteGrupit", model.AnetaretEGrupit);
                command.Parameters.AddWithValue("NderrimiIPunes", model.NderrimiIPunes);
                command.Parameters.AddWithValue("InsertBy", model.InsertBy);
                command.Parameters.AddWithValue("InsertDate", model.InsertDate);
                command.Parameters.AddWithValue("LUB", model.LUB);
                command.Parameters.AddWithValue("LUN", model.LUN);
                command.Parameters.AddWithValue("LUD", model.LUD);
                int rowAffected = command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                connection.Dispose();
                return rowAffected;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public int Fshij(PersoneliBO model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Personel_FshijPersonel", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id", model.ID);
                int result=command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                connection.Dispose();
                return result;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public List<PersoneliBO> GetAll()
        {
            try
            {
                List<PersoneliBO> rezultati = null;
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Personel_GetAllPersonel", connection);
                SqlDataReader reader = command.ExecuteReader();
                rezultati = new List<PersoneliBO>();
                while (reader.Read())
                {
                    PersoneliBO personeli = TooObject(reader);
                    rezultati.Add(personeli);
                }
                return rezultati;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public PersoneliBO TooObject(SqlDataReader reader)
        {
            PersoneliBO personeli = new PersoneliBO();
            personeli.ID = int.Parse(reader["ID"].ToString());
            personeli.Mbiemri = reader["Mbiemri"].ToString();
            personeli.Specializimi = reader["Specializimi"].ToString();
            personeli.Titulli = reader["Titulli"].ToString();
            personeli.VendiIPunes = reader["VendiIPunes"].ToString();
            personeli.Gjinia = bool.Parse(reader["Gjinia"].ToString());
            personeli.Vendlindja = reader["Vendlindja"].ToString();
            personeli.GrupiIGjakut = reader["GrupiIGjakut"].ToString();
            personeli.Shteti = reader["Shteti"].ToString();
            personeli.Vendbanimi = reader["Vendbanimi"].ToString();
            personeli.Telefoni = reader["Telefoni"].ToString();
            personeli.Mail = reader["Mail"].ToString();
            personeli.AnetaretEGrupit = reader["AnetareteGrupit"].ToString();
            personeli.NderrimiIPunes = reader["NderrimiIPunes"].ToString();
            personeli.InsertBy = int.Parse(reader["InsertBy"].ToString());
            personeli.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());
            personeli.LUB = int.Parse(reader["LUB"].ToString());
            personeli.LUN = int.Parse(reader["LUN"].ToString());
            personeli.LUD = DateTime.Parse(reader["LUD"].ToString());
            return personeli;
        }
        

        public int Update(PersoneliBO model)
        {
            throw new NotImplementedException();
        }
    }
}
