using Klubi_;
using Klubi_I_Futbollit.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_I_Futbollit.BLL
{
   public class RaportiBLL
    {
        public int Fshij(Raporti g)
        {
            try
            {
                RaportiDAL dal = new RaportiDAL();
                dal.Fshij(g);
                int rowsAffected = g.NdeshjaID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejRaportMeID(Raporti g)
        {
            try
            {
                RaportiDAL dal = new RaportiDAL();
                dal.MerrNdeshjeMeID(g);
                int rowsAffected = g.NdeshjaID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqListenERaporteve()
        {
            try
            {
                RaportiDAL dal = new RaportiDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(Raporti g)
        {
            try
            {
                RaportiDAL dal = new RaportiDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Raporti g)
        {
            try
            {
                RaportiDAL dal = new RaportiDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
