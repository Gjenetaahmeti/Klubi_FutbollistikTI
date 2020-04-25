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
    public class LojtariDAL //: CRUD<Lojtari>
    {
        public string _connectionstring = ConfigurationManager.ConnectionStrings["KlubiFutbollistikTI1"].ConnectionString;
        public int Fshij(Lojtari model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Lojtar_FshijLojtar", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("LojtariID", model.LojtariID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Lojtar_MerriTEgjithaLojtar",_connectionstring);

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



        public int Shto(Lojtari model,Personeli personeli)
        {

            try
            {
                SqlConnection conn = new SqlConnection(_connectionstring);
                conn.Open();
                SqlCommand comm = new SqlCommand("usp_Personel_ShtoPersonel", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("Emri", personeli.Emri);
                comm.Parameters.AddWithValue("Mbiemri", personeli.Mbiemri);
                comm.Parameters.AddWithValue("Specializimi", personeli.Specializimi);
                comm.Parameters.AddWithValue("Titulli", personeli.Titulli);
                comm.Parameters.AddWithValue("VendiIPunes", personeli.VendiIPunes);
                comm.Parameters.AddWithValue("Gjinia", personeli.Gjinia);
                comm.Parameters.AddWithValue("Ditelindja", personeli.Ditelindja);
                comm.Parameters.AddWithValue("GrupiIGjakut", personeli.GrupiIGjakut);
                comm.Parameters.AddWithValue("Shteti", personeli.Shteti);
                comm.Parameters.AddWithValue("Vendbanimi", personeli.Vendbanimi);
                comm.Parameters.AddWithValue("Telefoni", personeli.Telefoni);
                comm.Parameters.AddWithValue("Mail", personeli.Mail);
                comm.Parameters.AddWithValue("AnetareteGrupit", personeli.AnetaretEGrupit);
                comm.Parameters.AddWithValue("NderrimiIPunes", personeli.NderrimiIPunes);
                comm.Parameters.AddWithValue("InsertBy", personeli.InsertBy);
                comm.Parameters.AddWithValue("InsertDate", personeli.InsertDate);
                comm.Parameters.AddWithValue("LUB", personeli.LUB);
                comm.Parameters.AddWithValue("LUN", personeli.LUN);
                comm.Parameters.AddWithValue("LUD", personeli.LUD);
                try
                {
                    SqlConnection connection = new SqlConnection(_connectionstring);
                    connection.Open();
                    SqlCommand command = new SqlCommand("usp_Lojtari_ShtoLojtar", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Pesha", model.Pesha);
                    command.Parameters.AddWithValue("Gjatesia", model.Gjatesia);
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
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int Update(Lojtari model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Personel_UpdatePersonel]", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Pesha", model.Pesha);
                command.Parameters.AddWithValue("Gjatesia", model.Gjatesia);             
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
