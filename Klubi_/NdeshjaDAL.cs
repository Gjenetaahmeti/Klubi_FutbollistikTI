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
    public class NdeshjaDAL
    {
      //  public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;
        public int Fshij(Ndeshja model)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_FshijMeId_Ndeshje", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NdeshjaID", model.NdeshjaID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_MerrTeGjitha_Ndeshjet", sqlcon);
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

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_ShtooseEdito_Ndeshje", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DataENdeshjes", model.dataNdeshjes);
                command.Parameters.AddWithValue("@Sezoni", model.Sezoni);
                command.Parameters.AddWithValue("@RaportiIAmbulances", model.RaportiAmbulances);
                command.Parameters.AddWithValue("@RaportiIPolicis", model.RaportiPolicor);
                command.Parameters.AddWithValue("@NdeshjaID", 0);
                command.Parameters.AddWithValue("@KlubiVendasID", 1);
                command.Parameters.AddWithValue("@KlubiNikoqirID", 2);
                command.Parameters.AddWithValue("@FormacioniID", 1);
                command.Parameters.AddWithValue("@StadiumiID", 2);
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

        public int Update(Ndeshja ndeshjaModel)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_ShtooseEdito_Ndeshje]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NdeshjaID", ndeshjaModel.NdeshjaID);
                command.Parameters.AddWithValue("@DataENdeshjes", ndeshjaModel.dataNdeshjes);
                command.Parameters.AddWithValue("@Sezoni", ndeshjaModel.Sezoni);
                command.Parameters.AddWithValue("@RaportiIAmbulances", ndeshjaModel.RaportiAmbulances);
                command.Parameters.AddWithValue("@RaportiIPolicis", ndeshjaModel.RaportiPolicor);
                command.Parameters.AddWithValue("@KlubiVendasID", 1);
                command.Parameters.AddWithValue("@KlubiNikoqirID", 2);
                command.Parameters.AddWithValue("@FormacioniID", 1);
                command.Parameters.AddWithValue("@StadiumiID", 2);
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

        public void MerrNdeshjeMeID(Ndeshja ndeshja)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("usp_MerrNdeshjenMeID", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("@NdeshjaID", ndeshja.NdeshjaID);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                sqlda.Dispose();
                sqlcon.Close();
                ndeshja.dataNdeshjes = DateTime.Parse(dt.Rows[0]["DataENdeshjes"].ToString());
                ndeshja.Sezoni = dt.Rows[0]["Sezoni"].ToString();
                ndeshja.RaportiAmbulances = dt.Rows[0]["RaportiIAmbulances"].ToString();
                ndeshja.RaportiPolicor = dt.Rows[0]["RaportiIPolicise"].ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
