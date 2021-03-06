﻿using System;
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
    public class KlubiDAL
    {
        public string _connectionString = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
        //  public string _connectionString = ConfigurationManager.ConnectionStrings["Gjeneta"].ConnectionString;

        public DataTable GetAll()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_Klubet_MerriKrejtKlubet]", sqlcon);

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



        public int Shto(Klubi model)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Klub_ShtoOseEditoKlub]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Emertimi", model.Emertimi);
                command.Parameters.AddWithValue("@Vendi", model.Vendi);
                command.Parameters.AddWithValue("@Kryetari", model.Kryetari);
                command.Parameters.AddWithValue("@Ithemeluar", model.IThemeluar);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@KlubiID", 0);
                command.Parameters.AddWithValue("@StadiumiID", 1);
                command.Parameters.AddWithValue("@LigaID", 1);
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

        public int Update(Klubi model)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Klub_ShtoOseEditoKlub]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Emertimi", model.Emertimi);
                command.Parameters.AddWithValue("@Vendi", model.Vendi);
                command.Parameters.AddWithValue("@Kryetari", model.Kryetari);
                command.Parameters.AddWithValue("@Ithemeluar", model.IThemeluar);
                command.Parameters.AddWithValue("@InsertBy", 1);
                command.Parameters.AddWithValue("@InsertDate", "06/05/2020");
                command.Parameters.AddWithValue("@LUB", 1);
                command.Parameters.AddWithValue("@LUD", "06/05/2020");
                command.Parameters.AddWithValue("@LUN", 1);
                command.Parameters.AddWithValue("@KlubiID", model.KlubiID);
                command.Parameters.AddWithValue("@StadiumiID", 1);
                command.Parameters.AddWithValue("@LigaID", 1);

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

        public void GjejKlubMeID(Klubi klubi)
        {

            SqlConnection sqlcon = new SqlConnection(_connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Klub_GjejKlubMeID",sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@KlubiID", klubi.KlubiID);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            sqlDataAdapter.Dispose();
            sqlcon.Close();

            klubi.Emertimi = dt.Rows[0]["Emertimi"].ToString();
            klubi.Vendi = dt.Rows[0]["Vendi"].ToString();
            klubi.Kryetari = dt.Rows[0]["Kryetari"].ToString();
            klubi.IThemeluar =DateTime.Parse(dt.Rows[0]["IThemeluar"].ToString());
        }

        public int FshijMeID(Klubi klubi)
        {
            try
            {

                SqlConnection sqlcon = new SqlConnection(_connectionString);
                sqlcon.Open();
                SqlCommand sqc = new SqlCommand("[dbo].[usp_Klub_FshijKlubMeID]", sqlcon);
                sqc.CommandType = CommandType.StoredProcedure;
                sqc.Parameters.AddWithValue("@KlubiID", klubi.KlubiID);
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
