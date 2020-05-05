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
    public class VlersimetDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        //  public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;

        public int Fshij(Vlersimet model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Vlersimet_FshijVlersimetMeID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StatusiID", model.StatusiID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Vlersimet_MerrTeGjithaVlersimet", _connectionString);
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



        public int Shto(Vlersimet model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Vlersimet_ShtooseEdito]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StatusiID", 0);
                command.Parameters.AddWithValue("@LojtariID", model.lojtariID);
                command.Parameters.AddWithValue("@Vlersimi", model.Vlersimi);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("InsertDate", "01/01/1999");
                command.Parameters.AddWithValue("LUB", 1);
                command.Parameters.AddWithValue("LUD", "01/01/1999");
                command.Parameters.AddWithValue("LUN", 1);
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

        public int Update(Vlersimet model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Vlersimet_ShtooseEdito]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StatusiID", model.StatusiID);
                command.Parameters.AddWithValue("@LojtariID", model.lojtariID);
                command.Parameters.AddWithValue("@Vlersimi", model.Vlersimi);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("InsertDate", "01/01/1999");
                command.Parameters.AddWithValue("LUB", 1);
                command.Parameters.AddWithValue("LUD", "01/01/1999");
                command.Parameters.AddWithValue("LUN", 1);
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
        public void MerrVlersimeMeID(Vlersimet v)
        {
            SqlConnection sqlcon = new SqlConnection(_connectionString);
            sqlcon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Vlersimet_MerrVlersimetMeID", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StatusiID", v.StatusiID);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlDataAdapter.Dispose();
            sqlcon.Close();

            v.lojtariID = int.Parse(dataTable.Rows[0]["LojtariID"].ToString());
            v.Vlersimi = decimal.Parse(dataTable.Rows[0]["Vleresimi"].ToString());
        }
    }
}
