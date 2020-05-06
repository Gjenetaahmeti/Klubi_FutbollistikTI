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
    public class StatusiLojtaritBLL
    {
        public int Fshij(StatusiLojtarit g)
        {
            try
            {
                StatusiLojtaritDAL dal = new StatusiLojtaritDAL();
                dal.Fshij(g);
                int rowsAffected = g.StatusiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejStatusinELojtaritMeID(StatusiLojtarit g)
        {
            try
            {
                StatusiLojtaritDAL dal = new StatusiLojtaritDAL();
                dal.MerriMeIdFormacion(g);
                int rowsAffected = g.StatusiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqListenEStatuseveTeLojtarit()
        {
            try
            {
                StatusiLojtaritDAL dal = new StatusiLojtaritDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(StatusiLojtarit g)
        {
            try
            {
                StatusiLojtaritDAL dal = new StatusiLojtaritDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(StatusiLojtarit g)
        {
            try
            {
                StatusiLojtaritDAL dal = new StatusiLojtaritDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
