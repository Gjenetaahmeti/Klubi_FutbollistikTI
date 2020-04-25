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
    class NdeshjaDAL
    {
        public string _connectionstring = ConfigurationManager.ConnectionStrings["KlubiFutbollistikTI1"].ConnectionString;
        public int Fshij(Ndeshja model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Ndeshja_FshijNdeshje]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("NdeshjaID", model.NdeshjaID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_Ndeshja_MerriTeGjithaNdeshja]", _connectionstring);

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



        public int Shto(Ndeshja model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Ndeshja_ShtoNdeshje]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("DataNdeshjes", model.dataNdeshjes);
                command.Parameters.AddWithValue("VitiKalendarik", model.Vitikalendarik);
                command.Parameters.AddWithValue("Sezoni", model.Sezoni);
                command.Parameters.AddWithValue("Stadiumi", model.Stadiumi);
                command.Parameters.AddWithValue("RaportiAmbullances", model.RaportiAmbulances);
                command.Parameters.AddWithValue("RaportiPolicor", model.RaportiPolicor);
                command.Parameters.AddWithValue("KlubiMysafir", model.KlubiMysafir);
                command.Parameters.AddWithValue("KlubiNikoqir", model.KlubiNikoqir);
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

        public int Update(Ndeshja model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Ndeshja_EditoNdeshja]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("DataNdeshjes", model.dataNdeshjes);
                command.Parameters.AddWithValue("VitiKalendarik", model.Vitikalendarik);
                command.Parameters.AddWithValue("Sezoni", model.Sezoni);
                command.Parameters.AddWithValue("Stadiumi", model.Stadiumi);
                command.Parameters.AddWithValue("RaportiAmbullances", model.RaportiAmbulances);
                command.Parameters.AddWithValue("RaportiPolicor", model.RaportiPolicor);
                command.Parameters.AddWithValue("KlubiMysafir", model.KlubiMysafir);
                command.Parameters.AddWithValue("KlubiNikoqir", model.KlubiNikoqir);
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
