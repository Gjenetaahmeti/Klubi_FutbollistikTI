using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Klubi_Futbollistik;
using Klubi_I_Futbollit.BO;
using System.Configuration;

namespace Klubi_
{
    public class TrajneriDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        //  public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;

        public DataTable GetAll()
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_ShfaqTeGjitheTrajner", _connectionString);
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
        public void Shto(Trajneri trajner)
        {

            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_ShtooseEditoTrajner", sqlcon);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Emri", trajner.Emri);
                command.Parameters.AddWithValue("@Mbiemri", trajner.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", trajner.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalekalimi", trajner.Fjalkalimi);
                command.Parameters.AddWithValue("@Specializimi", trajner.Specializimi);
                command.Parameters.AddWithValue("@Titulli", trajner.Titulli);
                command.Parameters.AddWithValue("@Gjinia", trajner.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", trajner.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", trajner.Vendlindja);
                command.Parameters.AddWithValue("@Shteti", trajner.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", trajner.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", trajner.Telefoni);
                command.Parameters.AddWithValue("@Email", trajner.Mail);
                command.Parameters.AddWithValue("@PersoneliID", 0);
                command.Parameters.AddWithValue("@KlubiID", 1);
                command.Parameters.AddWithValue("@RoliID", 2);

                command.ExecuteNonQuery();
                command.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Trajneri trajner)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_ShtooseEditoTrajner", sqlcon);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Emri", trajner.Emri);
                command.Parameters.AddWithValue("@Mbiemri", trajner.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", trajner.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalekalimi", trajner.Fjalkalimi);
                command.Parameters.AddWithValue("@Specializimi", trajner.Specializimi);
                command.Parameters.AddWithValue("@Titulli", trajner.Titulli);
                command.Parameters.AddWithValue("@Gjinia", trajner.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", trajner.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", trajner.Vendlindja);
                command.Parameters.AddWithValue("@Shteti", trajner.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", trajner.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", trajner.Telefoni);
                command.Parameters.AddWithValue("@Email", trajner.Mail);
                command.Parameters.AddWithValue("@PersoneliID", trajner.TrajneriID);
                command.Parameters.AddWithValue("@KlubiID", 1);
                command.Parameters.AddWithValue("@RoliID", 2);

                command.ExecuteNonQuery();
                command.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GjejTrajnerinMeID(Trajneri trajneri)
        {
            SqlConnection sqlcon = new SqlConnection(_connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_GjejTrajnerMeID", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TrajneriID", trajneri.TrajneriID);
            DataTable dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            sqlDataAdapter.Dispose();
            sqlcon.Close();
            trajneri.Emri = dtbl.Rows[0]["Emri"].ToString();
            trajneri.Mbiemri = dtbl.Rows[0]["Mbiemri"].ToString();
            trajneri.EmriIPerdoruesit = dtbl.Rows[0]["EmriIPerdoruesit"].ToString();
            trajneri.Fjalkalimi = dtbl.Rows[0]["Fjalekalimi"].ToString();
            trajneri.Specializimi = dtbl.Rows[0]["Specializimi"].ToString();
            trajneri.Titulli = dtbl.Rows[0]["Titulli"].ToString();
            trajneri.Gjinia = dtbl.Rows[0]["Gjinia"].ToString();
            trajneri.Ditelindja = DateTime.Parse(dtbl.Rows[0]["Ditelindja"].ToString());
            trajneri.Vendlindja = dtbl.Rows[0]["Vendlindja"].ToString();
            trajneri.Shteti = dtbl.Rows[0]["Shteti"].ToString();
            trajneri.Vendbanimi = dtbl.Rows[0]["Vendbanimi"].ToString();
            trajneri.Telefoni = dtbl.Rows[0]["Telefoni"].ToString();
            trajneri.Mail = dtbl.Rows[0]["Email"].ToString();
        }
        public int Fshij(Trajneri trajneri)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_FshijTrajnerMeID", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TrajneriID", trajneri.TrajneriID);
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
