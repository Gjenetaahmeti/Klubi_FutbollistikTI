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
  public  class KlubiDAL
    {
        public string _connectionstring = ConfigurationManager.ConnectionStrings["KlubiFutbollistikTI1"].ConnectionString;
        public int Fshij(Klubi model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Klubi_FshijKlubin", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("KlubiID", model.KlubiID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Klubi_MerriTeGjithaKlubi", _connectionstring);

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
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Klubi_ShtoKlub", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emertimi", model.Emertimi);
                command.Parameters.AddWithValue("Vendi", model.Vendi);
                command.Parameters.AddWithValue("Stadiumi", model.Stadiumi);
                command.Parameters.AddWithValue("Kryetari", model.Kryetari);
                command.Parameters.AddWithValue("Rezultati", model.Rezultati);
                command.Parameters.AddWithValue("Themeluar", model.Themeluar);
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

        public int Update(Klubi model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Klubi_EditoKlub", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emertimi", model.Emertimi);
                command.Parameters.AddWithValue("Vendi", model.Vendi);
                command.Parameters.AddWithValue("Stadiumi", model.Stadiumi);
                command.Parameters.AddWithValue("Kryetari", model.Kryetari);
                command.Parameters.AddWithValue("Rezultati", model.Rezultati);
                command.Parameters.AddWithValue("Themeluar", model.Themeluar);
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
