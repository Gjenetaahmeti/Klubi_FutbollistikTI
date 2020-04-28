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
        //public string _connectionstring = ConfigurationManager.ConnectionStrings["KlubiFutbollistikTI1"].ConnectionString;
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-LG439J7\MYSQLSERVERARNO;Initial Catalog=DB_KlubiIFutbollitTI1;Integrated Security=True");

        public int Fshij(Lojtari model)
        {
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Lojtar_FshijLojtar", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("LojtariID", model.LojtariID);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Lojtar_MerriTEgjithaLojtar", sqlcon);

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



        public void Shto(Personeli person,Lojtari lojtari)
        {

            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("ShtoLojtarTest", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Pesha", lojtari.Pesha);
                command.Parameters.AddWithValue("@Gjatesia", lojtari.Gjatesia);
                command.Parameters.AddWithValue("@klubiId", 6);
                command.Parameters.AddWithValue("@userdId", 2);
                command.Parameters.AddWithValue("@kategoriaId", 1);
                command.Parameters.AddWithValue("@kontrollaId", 1);
                command.Parameters.AddWithValue("@Emri", person.Emri);
                command.Parameters.AddWithValue("@Mbiemri", person.Mbiemri);
                command.Parameters.AddWithValue("@Gjinia", person.Gjinia);
                command.Parameters.AddWithValue("@Vendlindja", person.Vendlindja);
                command.Parameters.AddWithValue("@GrupiGjakut", person.GrupiIGjakut);
                command.Parameters.AddWithValue("@Shtetesia", person.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", person.Vendbanimi);
                command.Parameters.AddWithValue("@Telefonin", person.Telefoni);
                command.Parameters.AddWithValue("@Mail", person.Mail);
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

        public void Update(Personeli person, Lojtari lojtari)
        {
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("EditoLojtarTest", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Pesha", lojtari.Pesha);
                command.Parameters.AddWithValue("@Gjatesia", lojtari.Gjatesia);
                command.Parameters.AddWithValue("@klubiId", 6);
                command.Parameters.AddWithValue("@userdId", 2);
                command.Parameters.AddWithValue("@kategoriaId", 1);
                command.Parameters.AddWithValue("@kontrollaId", 1);
                command.Parameters.AddWithValue("@PersoneliID", 7);
                command.Parameters.AddWithValue("@Emri", person.Emri);
                command.Parameters.AddWithValue("@Mbiemri", person.Mbiemri);
                command.Parameters.AddWithValue("@Gjinia", person.Gjinia);
                command.Parameters.AddWithValue("@Vendlindja", person.Vendlindja);
                command.Parameters.AddWithValue("@GrupiGjakut", person.GrupiIGjakut);
                command.Parameters.AddWithValue("@Shtetesia", person.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", person.Vendbanimi);
                command.Parameters.AddWithValue("@Telefonin", person.Telefoni);
                command.Parameters.AddWithValue("@Mail", person.Mail);
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
    }
}
