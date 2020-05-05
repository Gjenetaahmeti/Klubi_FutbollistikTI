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
    public class FormacioniDAL
    {
        //SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-HDHN4DB\SQLEXPRESS;Initial Catalog=Gjeneta;Integrated Security=True");
        //public string _connectionstring = ConfigurationManager.ConnectionStrings["Arno"].ConnectionString;
    //    public int Shto(Formacioni model)
    //    {
       
    //            SqlConnection connection = new SqlConnection(_connectionstring);
    //            connection.Open();
    //            SqlCommand command = new SqlCommand("usp_Formacion_ShtoFormacion", connection);
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.AddWithValue("Roli", model.Roli);
    //            command.Parameters.AddWithValue("NummriFanelles", model.NrFanelles);
    //            command.Parameters.AddWithValue("InsertBy", model.InsertBy);
    //            command.Parameters.AddWithValue("InsertDate", model.InsertDate);
    //            command.Parameters.AddWithValue("LUB", model.LUB);
    //            command.Parameters.AddWithValue("LUN", model.LUN);
    //            command.Parameters.AddWithValue("LUD", model.LUD);
    //            int rowAffected = command.ExecuteNonQuery();
    //            command.Dispose();
    //            connection.Close();
    //            connection.Dispose();
    //            return rowAffected;
          
    //    }
    //    public int Fshij(Formacioni model)
    //    {
     
    //            SqlConnection connection = new SqlConnection(_connectionstring);
    //            connection.Open();
    //            SqlCommand command = new SqlCommand("usp_Formacion_FshijFormacion", connection);
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.AddWithValue("Id", model.FormacioniID);
    //            int result = command.ExecuteNonQuery();
    //            command.Dispose();
    //            connection.Close();
    //            connection.Dispose();
    //            return result;
        
    //    }

    //    public DataTable GetAll()
    //    {
          
    //            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Lojtar_MerriTEgjithaLojtar", _connectionstring);

    //            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
    //            DataTable dataTable = new DataTable();
    //            sqlDataAdapter.Fill(dataTable);
    //            return dataTable;
        
    //    }




    //    public int Update(Formacioni model)
    //    {
        
    //            SqlConnection connection = new SqlConnection(_connectionstring);
    //            connection.Open();
    //            SqlCommand command = new SqlCommand("[dbo].[usp_Personel_UpdatePersonel]", connection);
    //            command.CommandType = CommandType.StoredProcedure;
    //            command.Parameters.AddWithValue("Roli", model.Roli);
    //            command.Parameters.AddWithValue("NumriFanelles", model.NrFanelles);   
    //            command.Parameters.AddWithValue("InsertBy", model.InsertBy);
    //            command.Parameters.AddWithValue("InsertDate", model.InsertDate);
    //            command.Parameters.AddWithValue("LUB", model.LUB);
    //            command.Parameters.AddWithValue("LUN", model.LUN);
    //            command.Parameters.AddWithValue("LUD", model.LUD);
    //            int rowAffected = command.ExecuteNonQuery();
    //            command.Dispose();
    //            connection.Close();
    //            connection.Dispose();
    //            return rowAffected;
       
    //    }

    }
}
