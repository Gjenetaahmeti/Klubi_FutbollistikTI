using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Klubi_Futbollistik.BO;
using Klubi_Futbollistik.BO.Interface;

namespace Klubi_Futbollistik.DAL
{
    class PersoneliDAL:CRUD<PersoneliBO>
    {
        public string _connectionstring = ConfigurationManager.ConnectionStrings["KlubiFutbollistikTI1"].ConnectionString; 
        public int Shto(PersoneliBO model)
        {
            throw new NotImplementedException();
        }
        public int Fshij(PersoneliBO model)
        {
            throw new NotImplementedException();
        }

        public List<PersoneliBO> GetAll()
        {
            throw new NotImplementedException();
        }

        

        public int Update(PersoneliBO model)
        {
            throw new NotImplementedException();
        }
    }
}
