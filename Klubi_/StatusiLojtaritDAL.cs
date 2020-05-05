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
        //public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;
        public int Fshij(StatusiLojtarit model)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Formacioni_FshijMeIDFormacion]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("StatusiID", model.StatusiID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_Formacioni_MerriKrejtFormacion]", sqlcon);
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



        public int Shto(StatusiLojtarit model,Lojtari lojtar)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Formacioni_ShtooseEditoFormacion", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Pergjegjes", model.Pergjegjes);
                command.Parameters.AddWithValue("@Rezerve", model.Rezerv);
                command.Parameters.AddWithValue("@Huazim", model.Huazim);
                command.Parameters.AddWithValue("@Shoqerues", model.Shoqerues);
                command.Parameters.AddWithValue("@StatusiID", 0);
                command.Parameters.AddWithValue("@LojtariID", lojtar.LojtariID);
                command.Parameters.AddWithValue("@FormacioniID", 1);
    
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

        public int Update(StatusiLojtarit model,Lojtari lojtari)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Formacioni_ShtooseEditoFormacion", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Pergjegjes", model.Pergjegjes);
                command.Parameters.AddWithValue("Rezerve", model.Rezerv);
                command.Parameters.AddWithValue("Huazim", model.Huazim);
                command.Parameters.AddWithValue("Shoqerues", model.Shoqerues);
                command.Parameters.AddWithValue("StatusiID", model.StatusiID);
                command.Parameters.AddWithValue("LojtariID", lojtari.LojtariID);
                command.Parameters.AddWithValue("FormacioniID", 1);
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

        public void MerriMeIdFormacion(StatusiLojtarit formacioni)
        {

            SqlConnection sqlcon = new SqlConnection(_connectionString);
            sqlcon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_Formacioni_MerriFormacionID]", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("StatusiID", formacioni.StatusiID);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlDataAdapter.Dispose();
            sqlcon.Close();

            formacioni.Pergjegjes = dataTable.Rows[0]["Pergjegjes"].ToString();
            formacioni.Rezerv = dataTable.Rows[0]["Rezerve"].ToString();
            formacioni.Huazim = dataTable.Rows[0]["Huazim"].ToString();
            formacioni.Shoqerues = dataTable.Rows[0]["Shoqerues"].ToString();
        }
    }
}
