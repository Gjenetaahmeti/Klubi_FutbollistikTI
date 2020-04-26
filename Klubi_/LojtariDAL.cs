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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");

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



        public int Shto(Lojtari lojtari,Personeli model)
        {

            try
            {
                SqlConnection conn = new SqlConnection(_connectionstring);
                conn.Open();
         
                SqlCommand command = new SqlCommand("[dbo].[usp_Personeli_ShtokrejtPersonel]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Emri", model.Emri);
                command.Parameters.AddWithValue("@Mbiemri", model.Mbiemri);
                command.Parameters.AddWithValue("@Specializimi", model.Specializimi);
                command.Parameters.AddWithValue("@Titulli", model.Titulli);
                command.Parameters.AddWithValue("@VendiIPunes", model.VendiIPunes);
                command.Parameters.AddWithValue("@Gjinia", model.Gjinia);
                // command.Parameters.AddWithValue("@Ditelindja", model.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", model.Vendlindja);
                command.Parameters.AddWithValue("@GrupiIGjakut", model.GrupiIGjakut);
                command.Parameters.AddWithValue("@Shteti", model.Shteti);
                command.Parameters.AddWithValue("@VendBanimi", model.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", model.Telefoni);
                command.Parameters.AddWithValue("@Mail", model.Mail);
                try
                {
                    SqlConnection connection = new SqlConnection(_connectionstring);
                    connection.Open();
                    SqlCommand command1 = new SqlCommand("[dbo].[usp_Lojtar_ShtokrejtLojtar]", sqlcon);
                    command1.CommandType = CommandType.StoredProcedure;
                    command1.Parameters.AddWithValue("Pesha", lojtari.Pesha);
                    command1.Parameters.AddWithValue("Gjatesia", lojtari.Gjatesia);
                    //command.Parameters.AddWithValue("InsertBy", model.InsertBy);
                    //command.Parameters.AddWithValue("InsertDate", model.InsertDate);
                    //command.Parameters.AddWithValue("LUB", model.LUB);
                    //command.Parameters.AddWithValue("LUN", model.LUN);
                    //command.Parameters.AddWithValue("LUD", model.LUD);
                    int rowAffected = command1.ExecuteNonQuery();
                    command1.Dispose();
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
