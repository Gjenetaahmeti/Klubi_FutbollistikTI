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
    public  class ReferiDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        public void Shto(Referi referi)
        {

            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Referat_ShtooseEdito", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Emri", referi.Emri);
                command.Parameters.AddWithValue("@Mbiemri", referi.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", referi.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalekalimi", referi.Fjalkalimi);
                command.Parameters.AddWithValue("@Specializimi", referi.Specializimi);
                command.Parameters.AddWithValue("@Titulli", referi.Titulli);
                command.Parameters.AddWithValue("@Gjinia", referi.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", referi.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", referi.Vendlindja);
                command.Parameters.AddWithValue("@Shteti", referi.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", referi.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", referi.Telefoni);
                command.Parameters.AddWithValue("@Email", referi.Mail);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@RoliID", 4);
                command.Parameters.AddWithValue("@PersoneliID", 0);
                command.Parameters.AddWithValue("@Pozita", referi.Pozita);
                command.Parameters.AddWithValue("@NdeshjaID", 1);
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

        public void Edito(Referi referi)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Referat_ShtooseEdito", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Emri", referi.Emri);
                command.Parameters.AddWithValue("@Mbiemri", referi.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", referi.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalekalimi", referi.Fjalkalimi);
                command.Parameters.AddWithValue("@Specializimi", referi.Specializimi);
                command.Parameters.AddWithValue("@Titulli", referi.Titulli);
                command.Parameters.AddWithValue("@Gjinia", referi.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", referi.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", referi.Vendlindja);
                command.Parameters.AddWithValue("@Shteti", referi.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", referi.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", referi.Telefoni);
                command.Parameters.AddWithValue("@Email", referi.Mail);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@RoliID", 4);
                command.Parameters.AddWithValue("@PersoneliID", referi.ReferiID);
                command.Parameters.AddWithValue("@Pozita", referi.Pozita);
                command.Parameters.AddWithValue("@NdeshjaID", 1);
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
        public void GjejReferMeID(Referi referi)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Referat_GjejMeID", sqlcon);
                sqlDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ReferatID", referi.ReferiID);
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                sqlDataAdapter.Dispose();
                sqlcon.Close();
                referi.Emri = dtbl.Rows[0]["Emri"].ToString();
                referi.Mbiemri = dtbl.Rows[0]["Mbiemri"].ToString();
                referi.EmriIPerdoruesit = dtbl.Rows[0]["EmriIPerdoruesit"].ToString();
                referi.Fjalkalimi = dtbl.Rows[0]["Fjalekalimi"].ToString();
                referi.Specializimi = dtbl.Rows[0]["Specializimi"].ToString();
                referi.Titulli = dtbl.Rows[0]["Titulli"].ToString();
                referi.Gjinia = dtbl.Rows[0]["Gjinia"].ToString();
                referi.Ditelindja = DateTime.Parse(dtbl.Rows[0]["Ditelindja"].ToString());
                referi.Vendlindja = dtbl.Rows[0]["Vendlindja"].ToString();
                referi.Shteti = dtbl.Rows[0]["Shteti"].ToString();
                referi.Vendbanimi = dtbl.Rows[0]["Vendbanimi"].ToString();
                referi.Telefoni = dtbl.Rows[0]["Telefoni"].ToString();
                referi.Mail = dtbl.Rows[0]["Email"].ToString();
                referi.Pozita = dtbl.Rows[0]["Pozita"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
