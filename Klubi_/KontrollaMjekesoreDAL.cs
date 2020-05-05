using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klubi_Futbollistik.BO.Interface;
using Klubi_I_Futbollit.BO;
namespace Klubi_
{
   public class KontrollaMjekesoreDAL
    {
      //  public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;
        public int Fshij(Kontrolla_Mjekesore model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_KontrollaMjeksore_FshijKontrollaMjeksore", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("KontrollaID", model.KontrollaMjekesoreID);
                int result = command.ExecuteNonQuery();
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

        public DataTable GetAll()
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_KontrollaMjekesore_MerriTeGjithaKontrollatMjekesore", _connectionString);

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



        public int Shto(Kontrolla_Mjekesore model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_KontrollaMjekesore_ShtoKontrollMjekesore", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("KontrollaData", model.KontrollaData);
                command.Parameters.AddWithValue("Kontrolla", model.Kontrolla);
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

        public int Update(Kontrolla_Mjekesore model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("[usp_KontrollaMjekesore_EditoKontrollaMjekesore]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("KontrollaData", model.KontrollaData);
                command.Parameters.AddWithValue("Kontrolla", model.Kontrolla);
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
    }
}
