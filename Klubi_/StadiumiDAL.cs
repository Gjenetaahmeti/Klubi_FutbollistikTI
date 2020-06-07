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
    public class StadiumiDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        //  public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;

        public DataTable GetAll()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_Stadiumet_MerriKrejtStadiumet]", sqlcon);

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



        public int Shto(Stadiumi stadiumi)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Stadiume_ShtoOseEditoStadiume]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Emertimi", stadiumi.Emertimi);
                command.Parameters.AddWithValue("@Vendi", stadiumi.Vendi);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@StadiumeID", 0);
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

        public int Update(Stadiumi stadiumi)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Stadiume_ShtoOseEditoStadiume]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Emertimi", stadiumi.Emertimi);
                command.Parameters.AddWithValue("@Vendi", stadiumi.Vendi);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@StadiumeID", stadiumi.StadiumiID);

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

        public void GjejStadiumMeID(Stadiumi stadiumi)
        {

            SqlConnection sqlcon = new SqlConnection(_connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_Stadiume_GjejMeIDStadium]", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StadiumeID", stadiumi.StadiumiID);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            sqlDataAdapter.Dispose();
            sqlcon.Close();

            stadiumi.Emertimi = dt.Rows[0]["Emertimi"].ToString();
            stadiumi.Vendi = dt.Rows[0]["Vendi"].ToString();
        }

        public int FshijMeID(Stadiumi stadiumi)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand sqc = new SqlCommand("[dbo].[usp_Stadiume_FshijStadiumMeID]", sqlcon);
                sqc.CommandType = CommandType.StoredProcedure;
                sqc.Parameters.AddWithValue("@Stadiumi", stadiumi.StadiumiID);
                int result = sqc.ExecuteNonQuery();
                sqc.Dispose();
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
