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
using Klubi_Futbollistik;

namespace Klubi_
{
    public class LojtariDAL 
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=Gjeneta;Integrated Security=True");

        public int Fshij(Lojtari model)
        {
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_FshijLojtarMeID", sqlcon);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_ShfaqTeGjithLojtaret", sqlcon);

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



        public void Shto(Lojtari lojtari)
        {

            try
            {
                
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Lojtare_ShtoLojtare", sqlcon);
              
                command.CommandType = CommandType.StoredProcedure;
          
                command.Parameters.AddWithValue("@Emri", lojtari.Emri);
                command.Parameters.AddWithValue("@Mbiemri", lojtari.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", lojtari.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalkalimi", lojtari.Fjalkalimi);
                command.Parameters.AddWithValue("@NumriIFanelles", lojtari.NumriFanelles);
                command.Parameters.AddWithValue("@Gjinia", lojtari.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", lojtari.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", lojtari.Vendlindja);
                command.Parameters.AddWithValue("@GrupiIGjakut", lojtari.GrupiGjakut);
                command.Parameters.AddWithValue("@Shteti", lojtari.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", lojtari.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", lojtari.Telefoni);
                command.Parameters.AddWithValue("@Mail", lojtari.Mail);
                command.Parameters.AddWithValue("@Pesha", lojtari.Pesha);
                command.Parameters.AddWithValue("@Gjatesia", lojtari.Gjatesia);   
                command.Parameters.AddWithValue("@PersoneliID",0);
                command.Parameters.AddWithValue("@klubiID", 1);
                
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

        public void Update( Lojtari lojtari)
        {
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand("usp_Lojtare_ShtoLojtare", sqlcon);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Emri", lojtari.Emri);
                command.Parameters.AddWithValue("@Mbiemri", lojtari.Mbiemri);
                command.Parameters.AddWithValue("@EmriIPerdoruesit", lojtari.EmriIPerdoruesit);
                command.Parameters.AddWithValue("@Fjalkalimi", lojtari.Fjalkalimi);
                command.Parameters.AddWithValue("@NumriIFanelles", lojtari.NumriFanelles);
                command.Parameters.AddWithValue("@Gjinia", lojtari.Gjinia);
                command.Parameters.AddWithValue("@Ditelindja", lojtari.Ditelindja);
                command.Parameters.AddWithValue("@Vendlindja", lojtari.Vendlindja);
                command.Parameters.AddWithValue("@GrupiIGjakut", lojtari.GrupiGjakut);
                command.Parameters.AddWithValue("@Shteti", lojtari.Shteti);
                command.Parameters.AddWithValue("@Vendbanimi", lojtari.Vendbanimi);
                command.Parameters.AddWithValue("@Telefoni", lojtari.Telefoni);
                command.Parameters.AddWithValue("@Mail", lojtari.Mail);
                command.Parameters.AddWithValue("@Pesha", lojtari.Pesha);
                command.Parameters.AddWithValue("@Gjatesia", lojtari.Gjatesia);
                command.Parameters.AddWithValue("@PersoneliID", lojtari.LojtariID);
                command.Parameters.AddWithValue("@KlubiID", 1);
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

        public void GjejLojtarinMeID(Lojtari lojtari)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_GjejLojtarMeID", sqlcon);
            sqlDataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@LojtariID", lojtari.LojtariID);
            DataTable dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            sqlDataAdapter.Dispose();
            sqlcon.Close();
            lojtari.Emri = dtbl.Rows[0]["Emri"].ToString();
            lojtari.Mbiemri = dtbl.Rows[0]["Mbiemri"].ToString();
            lojtari.EmriIPerdoruesit = dtbl.Rows[0]["EmriIPerdoruesit"].ToString();
            lojtari.Fjalkalimi= dtbl.Rows[0]["Fjalekalimi"].ToString();
            lojtari.NumriFanelles = int.Parse(dtbl.Rows[0]["NumriFanelles"].ToString());
            lojtari.Gjinia = dtbl.Rows[0]["Gjinia"].ToString();
            lojtari.Ditelindja = DateTime.Parse(dtbl.Rows[0]["Ditelindja"].ToString());
            lojtari.Vendlindja= dtbl.Rows[0]["Vendlindja"].ToString();
            lojtari.GrupiGjakut = dtbl.Rows[0]["GrupiIGjakut"].ToString();
            lojtari.Shteti = dtbl.Rows[0]["Shteti"].ToString();
            lojtari.Vendbanimi = dtbl.Rows[0]["Vendbanimi"].ToString();
            lojtari.Telefoni = dtbl.Rows[0]["Telefoni"].ToString();
            lojtari.Mail = dtbl.Rows[0]["Email"].ToString();
            lojtari.Pesha = decimal.Parse(dtbl.Rows[0]["Pesha"].ToString());
            lojtari.Gjatesia= decimal.Parse(dtbl.Rows[0]["Gjatesia"].ToString());
            
        }
    }
}
