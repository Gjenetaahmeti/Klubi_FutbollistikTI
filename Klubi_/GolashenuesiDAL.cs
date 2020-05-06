using Klubi_I_Futbollit.BO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_
{
    public class GolashenuesiDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
      //  public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;
        
        public int Shto(Golashenuesit golaShenuesi)//,Lojtari lojtari,Ndeshja ndeshja)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Golashenuesi_ShtooseEdito",sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GolashenuesiID", 0);
                command.Parameters.AddWithValue("@LojtariID", golaShenuesi.lojtariID);
                command.Parameters.AddWithValue("@Golat", golaShenuesi.NumriGolave);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@NdeshjaID", golaShenuesi.ndeshjaID);
                int rowAffected = command.ExecuteNonQuery();
                command.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
                return rowAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(Golashenuesit golaShenuesi)//,Lojtari lojtari, Ndeshja ndeshja)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Golashenuesi_ShtooseEdito", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GolashenuesiID", golaShenuesi.GolashenuesiID);
                command.Parameters.AddWithValue("@LojtariID", golaShenuesi.lojtariID);
                command.Parameters.AddWithValue("@Golat", golaShenuesi.NumriGolave);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@NdeshjaID", 1);
                int rowAffected = command.ExecuteNonQuery();
                command.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
                return rowAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void MerrGolashenuesinMeID(Golashenuesit golaShenuesi)//, Lojtari lojtari, Ndeshja ndeshja)
        {

            SqlConnection sqlcon = new SqlConnection(_connectionString);
            sqlcon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Golashenuesi_MerrGolashenuesMeID", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@GolashenuesiID", golaShenuesi.GolashenuesiID);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlDataAdapter.Dispose();
            sqlcon.Close();

            golaShenuesi.GolashenuesiID = int.Parse(dataTable.Rows[0]["GolaShenuesiId"].ToString());
            golaShenuesi.lojtariID = int.Parse(dataTable.Rows[0]["LojtariId"].ToString());
            golaShenuesi.NumriGolave = int.Parse(dataTable.Rows[0]["Golat"].ToString());
            golaShenuesi.ndeshjaID = int.Parse(dataTable.Rows[0]["NdeshjaId"].ToString());
        }
        public DataTable GetAll()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Golashenuesi_MerrTeGjithListen", sqlcon);
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

        public int Fshij(Golashenuesit golaShenuesi)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Golashenuesi_FshijGolashenuesin", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GolashenuesiID", golaShenuesi.GolashenuesiID);
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

    }
}
