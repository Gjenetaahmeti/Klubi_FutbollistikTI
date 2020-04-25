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
    public class StatusiLojtaritDAL
    {
        public string _connectionstring = ConfigurationManager.ConnectionStrings["KlubiFutbollistikTI1"].ConnectionString;
        public int Fshij(StatusiLojtarit model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_StatusiLojtarit_FshijStatusinLojtarit]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("StatusiID", model.StatusiID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_StatusiLojtarit_MerrTeGjitha]", _connectionstring);
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



        public int Shto(StatusiLojtarit model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_StatusiLojtarit_ShtoStatusiLojtarit]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Pergjegjes", model.Pergjegjes);
                command.Parameters.AddWithValue("Rezerve", model.Rezerv);
                command.Parameters.AddWithValue("Huazim", model.Huazim);
                command.Parameters.AddWithValue("Shoqerues", model.Shoqerues);
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

        public int Update(StatusiLojtarit model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_StatusiLojtarit_Edito]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Pergjegjes", model.Pergjegjes);
                command.Parameters.AddWithValue("Rezerve", model.Rezerv);
                command.Parameters.AddWithValue("Huazim", model.Huazim);
                command.Parameters.AddWithValue("Shoqerues", model.Shoqerues);
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
