using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klubi_I_Futbollit.BO;
using Klubi_Futbollistik;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Klubi_
{
  public  class PersoneliDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        //  public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;

        public int Fshij(Personeli model)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_FshijLojtarMeID", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
             //   command.Parameters.AddWithValue("@LojtariID", model.PersonelID);
                int result = command.ExecuteNonQuery();
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

        public DataTable GetAll()
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Personel_merriTegjithePersonel", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception e)
            {
                return null;
            }
        }



        public void Shto(Personeli personeli)
        {

            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "[dbo].[usp_Personel_ShtoPersonel]";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = sqlcon;

                command.Parameters.AddWithValue("@Emri", personeli.Emri);
                command.Parameters.AddWithValue("@Mbiemri", personeli.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", personeli.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalkalimi", personeli.Fjalkalimi);
                command.Parameters.AddWithValue("@Gjinia", personeli.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", personeli.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", personeli.Vendlindja);
                command.Parameters.AddWithValue("@GrupiIGjakut", personeli.GrupiGjakut);
                command.Parameters.AddWithValue("@Shteti", personeli.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", personeli.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", personeli.Telefoni);
                command.Parameters.AddWithValue("@Mail", personeli.Mail);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@PersoneliID", 0);

                command.ExecuteNonQuery();
                command.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Personeli personeli)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Personel_ShtoPersonel]", sqlcon);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Emri", personeli.Emri);
                command.Parameters.AddWithValue("@Mbiemri", personeli.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", personeli.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalkalimi", personeli.Fjalkalimi);
                command.Parameters.AddWithValue("@Gjinia", personeli.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", personeli.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", personeli.Vendlindja);
                command.Parameters.AddWithValue("@GrupiIGjakut", personeli.GrupiGjakut);
                command.Parameters.AddWithValue("@Shteti", personeli.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", personeli.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", personeli.Telefoni);
                command.Parameters.AddWithValue("@Mail", personeli.Mail);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void GjejPersonelMeID(Personeli personeli)
        {

            SqlConnection sqlcon = new SqlConnection(_connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_GjejLojtarMeID", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@LojtariID", personeli.PersonelID);
            DataTable dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            sqlDataAdapter.Dispose();
            sqlcon.Close();
            personeli.Emri = dtbl.Rows[0]["Emri"].ToString();
            personeli.Mbiemri = dtbl.Rows[0]["Mbiemri"].ToString();
            personeli.EmriIPerdoruesit = dtbl.Rows[0]["EmriIPerdoruesit"].ToString();
            personeli.Fjalkalimi = dtbl.Rows[0]["Fjalekalimi"].ToString();
            personeli.Gjinia = dtbl.Rows[0]["Gjinia"].ToString();
            personeli.Ditelindja = DateTime.Parse(dtbl.Rows[0]["Ditelindja"].ToString());
            personeli.Vendlindja = dtbl.Rows[0]["Vendlindja"].ToString();
            personeli.GrupiGjakut = dtbl.Rows[0]["GrupiIGjakut"].ToString();
            personeli.Shteti = dtbl.Rows[0]["Shteti"].ToString();
            personeli.Vendbanimi = dtbl.Rows[0]["Vendbanimi"].ToString();
            personeli.Telefoni = dtbl.Rows[0]["Telefoni"].ToString();
            personeli.Mail = dtbl.Rows[0]["Email"].ToString();

        }
    }
}
