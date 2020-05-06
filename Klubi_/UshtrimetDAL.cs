using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klubi_Futbollistik.BO.Interface;
using Klubi_I_Futbollit.BO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Klubi_
{
    public class UshtrimetDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;


        public int Shto(Ushtrimet ushtrime)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Ushtrime_ShtoOseEdito]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Dita", ushtrime.Dita);
                command.Parameters.AddWithValue("@Ora", ushtrime.Ora);
                command.Parameters.AddWithValue("@InsertBy",1);
                command.Parameters.AddWithValue("@InsertDate", "01/01/1998");
                command.Parameters.AddWithValue("@LUB", 2);
                command.Parameters.AddWithValue("@LUD", "01/01/1997");
                command.Parameters.AddWithValue("@LUN", 2);
                command.Parameters.AddWithValue("@UshtrimiID",0);
                command.Parameters.AddWithValue("@KlubiID", 1);

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

        public int Update(Ushtrimet ushtrimi)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Ushtrime_ShtoOseEdito]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
            
                command.Parameters.AddWithValue("@Dita", ushtrimi.Dita);
                command.Parameters.AddWithValue("@Ora", ushtrimi.Ora);
                command.Parameters.AddWithValue("@InsertBy", 2);
                command.Parameters.AddWithValue("@InsertDate",DateTime.Now);
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", DateTime.Now);
                command.Parameters.AddWithValue("@LUN", 2);
                command.Parameters.AddWithValue("@UshtrimiID", ushtrimi.UshtrimetID);
                command.Parameters.AddWithValue("@KlubiID", 1);

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
        public DataTable GetAll()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_Ushtrime_MerriTeGjithaUshtrimet]", sqlcon);

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
        public void GjejUshtrimMeID(Ushtrimet ushtrime)
        {

            SqlConnection sqlcon = new SqlConnection(_connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Ushtrim_GjejMeIDUshtrim", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@UshtrimeID", ushtrime.UshtrimetID);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            sqlDataAdapter.Dispose();
            sqlcon.Close();

            ushtrime.Dita = dt.Rows[0]["Dita"].ToString();
            ushtrime.Ora = dt.Rows[0]["Ora"].ToString();
        }
        public int FshijMeID(Ushtrimet ushtrimet)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand sqc = new SqlCommand("[dbo].[usp_Ushtrim_FshijUshtrimMeID]", sqlcon);
                sqc.CommandType = CommandType.StoredProcedure;
                sqc.Parameters.AddWithValue("@UshtrimID", ushtrimet.UshtrimetID);
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
