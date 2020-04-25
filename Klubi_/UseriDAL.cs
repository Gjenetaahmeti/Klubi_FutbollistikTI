using System;
using System.Collections.Generic;
using System.Windows;
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
   public class UseriDAL
    {
        public string _connectionstring = ConfigurationManager.ConnectionStrings["KlubiFutbollistikTI1"].ConnectionString;


        public bool CheckLogIn(Useri useri)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionstring);
                connection.Open();
                SqlCommand command = new SqlCommand("usp_Useri_CheckInUser", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Emri", useri.EmriIPerdoruesit);
                command.Parameters.AddWithValue("Mbiemri", useri.PasswordiPerdoruesit);
                //cmd.ExecuteNonQuery();
                SqlDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
