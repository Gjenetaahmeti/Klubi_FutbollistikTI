using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Klubi_Futbollistik;
using Klubi_I_Futbollit.BO;
namespace Klubi_
{
   public class DelegatDAL
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=Gjeneta;Integrated Security=True");

        public DataTable GetAll()
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_delegat_merrikejtDelegat]", sqlcon);
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

        public void Shto(Delegat delegat)
        {

            try
            {

                sqlcon.Open();
                SqlCommand command = new SqlCommand("Delegat", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Emri", delegat.Emri);
                command.Parameters.AddWithValue("@Mbiemri", delegat.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", delegat.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalekalimi", delegat.Fjalkalimi);
                command.Parameters.AddWithValue("@Specializimi", delegat.Specializimi);
                command.Parameters.AddWithValue("@Titulli", delegat.Titulli);
                command.Parameters.AddWithValue("@Gjinia", delegat.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", delegat.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", delegat.Vendlindja);
                command.Parameters.AddWithValue("@Shteti", delegat.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", delegat.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", delegat.Telefoni);
                command.Parameters.AddWithValue("@Email", delegat.Mail);

                command.Parameters.AddWithValue("@PersoneliID", 0);
                command.Parameters.AddWithValue("@KlubiID", 1);
                command.Parameters.AddWithValue("@RoliID", 5);
                command.Parameters.AddWithValue("@Roli", delegat.Roli);
                command.Parameters.AddWithValue("@RaportiPasNdeshjes", delegat.RaportiPasNdeshjes);
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
 
        public void Update(Delegat delegat)
        {
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Delegat_ShtooseEditoDelegat]", sqlcon);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Emri", delegat.Emri);
                command.Parameters.AddWithValue("@Mbiemri", delegat.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", delegat.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalekalimi", delegat.Fjalkalimi);
                command.Parameters.AddWithValue("@Specializimi", delegat.Specializimi);
                command.Parameters.AddWithValue("@Titulli", delegat.Titulli);
                command.Parameters.AddWithValue("@Gjinia", delegat.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", delegat.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", delegat.Vendlindja);
                command.Parameters.AddWithValue("@Shteti", delegat.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", delegat.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", delegat.Telefoni);
                command.Parameters.AddWithValue("@Email", delegat.Mail);
                command.Parameters.AddWithValue("@PersoneliID", delegat.DelegatID);
                command.Parameters.AddWithValue("@KlubiID", 1);
                command.Parameters.AddWithValue("@RoliID", 5);

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
        public void GjejDelegatMeID(Delegat delegat)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("[dbo].[usp_Delegat_GjejDelegatMeID]", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@DelegatID", delegat.DelegatID);
            DataTable dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            sqlDataAdapter.Dispose();
            sqlcon.Close();
            delegat.Emri = dtbl.Rows[0]["Emri"].ToString();
            delegat.Mbiemri = dtbl.Rows[0]["Mbiemri"].ToString();
            delegat.EmriIPerdoruesit = dtbl.Rows[0]["EmriIPerdoruesit"].ToString();
            delegat.Fjalkalimi = dtbl.Rows[0]["Fjalekalimi"].ToString();
            delegat.Specializimi = dtbl.Rows[0]["Specializimi"].ToString();
            delegat.Titulli = dtbl.Rows[0]["Titulli"].ToString();
            delegat.Gjinia = dtbl.Rows[0]["Gjinia"].ToString();
            delegat.Ditelindja = DateTime.Parse(dtbl.Rows[0]["Ditelindja"].ToString());
            delegat.Vendlindja = dtbl.Rows[0]["Vendlindja"].ToString();
            delegat.Shteti = dtbl.Rows[0]["Shteti"].ToString();
            delegat.Vendbanimi = dtbl.Rows[0]["Vendbanimi"].ToString();
            delegat.Telefoni = dtbl.Rows[0]["Telefoni"].ToString();
            delegat.Mail = dtbl.Rows[0]["Email"].ToString();
        }
        public int Fshij(Delegat delegat)
        {
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("[dbo].[usp_Delegat_FshijDelegatMeID]", sqlcon);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DelegatID", delegat.DelegatID);
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

