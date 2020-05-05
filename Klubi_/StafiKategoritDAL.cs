using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Klubi_Futbollistik.BO.Interface;
using Klubi_I_Futbollit.BO;

namespace Klubi_
{
    public class StafiKategoritDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        //  public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;

        public int Fshij(StafiKategorit model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_StafiKategorive_FshijgjithaStaf]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("KategoriaID", model.KategoriaID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_StafiKategorive_MerrTegjithaStaf]", _connectionString);
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



        public int Shto(StafiKategorit model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_StafiKategorive_ShtoStaf]", connection);
                command.CommandType = CommandType.StoredProcedure; 
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Pozita", model.Pozita);
                command.Parameters.AddWithValue("KontrataDerMe", model.KontrataDerMe);
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

        public int Update(StafiKategorit model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_StafiKategorive_EditoStaf]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Pozita", model.Pozita);
                command.Parameters.AddWithValue("KontrataDerMe", model.KontrataDerMe);
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
