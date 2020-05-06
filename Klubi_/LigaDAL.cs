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
  public  class LigaDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        //  public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;

        public DataTable GetAll()
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Klubi_MerriTeGjithaKlubi", _connectionString);

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



        public int Shto(Klubi model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Klubi_ShtoKlub", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emertimi", model.Emertimi);
                command.Parameters.AddWithValue("Vendi", model.Vendi);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
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

        public int Update(Klubi model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Klubi_EditoKlub", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emertimi", model.Emertimi);
                command.Parameters.AddWithValue("Vendi", model.Vendi);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
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
