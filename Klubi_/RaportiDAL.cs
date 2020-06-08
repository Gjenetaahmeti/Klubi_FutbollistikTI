using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klubi_I_Futbollit.BO;
namespace Klubi_
{
   public class RaportiDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        //  public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;

        public int Fshij(Raporti model)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Raport_FshijRaportMeID]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@RaportID", model.NdeshjaID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_Raporte_MerriRaportet]", sqlcon);
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



        public int Shto(Raporti model)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Raporte_ShtoOseEditoRaport]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DataENdeshjes", model.dataNdeshjes);
                command.Parameters.AddWithValue("@Sezoni", model.Sezoni);
                command.Parameters.AddWithValue("@RaportiAmbulances", model.RaportiAmbulances);
                command.Parameters.AddWithValue("@RaportiPolicis", model.RaportiPolicor);
                command.Parameters.AddWithValue("@Raporti", model.Raportii);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@NdeshjaID", 0);
     
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

        public int Update(Raporti raporti)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Raporte_ShtoOseEditoRaport", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NdeshjaID", raporti.NdeshjaID);
                command.Parameters.AddWithValue("@DataENdeshjes", raporti.dataNdeshjes);
                command.Parameters.AddWithValue("@Sezoni", raporti.Sezoni);
                command.Parameters.AddWithValue("@RaportiAmbulances", raporti.RaportiAmbulances);
                command.Parameters.AddWithValue("@RaportiPolicis", raporti.RaportiPolicor);
                command.Parameters.AddWithValue("@Raporti", raporti.Raportii);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
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

        public void MerrNdeshjeMeID(Raporti raporti)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("usp_Raport_GjejRaportMeID", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("@RaportID", raporti.NdeshjaID);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                sqlda.Dispose();
                sqlcon.Close();
                raporti.dataNdeshjes = DateTime.Parse(dt.Rows[0]["DataENdeshjes"].ToString());
                raporti.Sezoni = dt.Rows[0]["Sezoni"].ToString();
                raporti.RaportiAmbulances = dt.Rows[0]["RaportiAmbulances"].ToString();
                raporti.RaportiPolicor = dt.Rows[0]["RaportiPolicise"].ToString();
                raporti.Raportii = dt.Rows[0]["Raporti"].ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
