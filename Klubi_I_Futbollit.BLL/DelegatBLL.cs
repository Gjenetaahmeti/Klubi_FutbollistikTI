using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klubi_;
using Klubi_I_Futbollit.BO;

namespace Klubi_I_Futbollit.BLL
{
    public class DelegatBLL
    {
        public int Fshij(Delegat g)
        {
            try
            {
                DelegatDAL dal = new DelegatDAL();
                dal.Fshij(g);
                int rowsAffected = g.DelegatID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejDelegatinMeID(Delegat g)
        {
            try
            {
                DelegatDAL dal = new DelegatDAL();
                dal.GjejDelegatMeID(g);
                int rowsAffected = g.DelegatID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqListenEDelegateve()
        {
            try
            {
                DelegatDAL dal = new DelegatDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(Delegat g)
        {
            try
            {
                DelegatDAL dal = new DelegatDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Delegat g)
        {
            try
            {
                DelegatDAL dal = new DelegatDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
