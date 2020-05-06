using Klubi_;
using Klubi_I_Futbollit.BO;
using System;
using System.Data;

namespace Klubi_I_Futbollit.BLL
{
    public class KlubiBLL
    {
        public int Fshij(Klubi g)
        {
            try
            {
                KlubiDAL dal = new KlubiDAL();
                dal.FshijMeID(g);
                int rowsAffected = g.KlubiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejKlubinMeID(Klubi g)
        {
            try
            {
                KlubiDAL dal = new KlubiDAL();
                dal.GjejKlubMeID(g);
                int rowsAffected = g.KlubiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqListenEKlubeve()
        {
            try
            {
                KlubiDAL dal = new KlubiDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(Klubi g)
        {
            try
            {
                KlubiDAL dal = new KlubiDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Klubi g)
        {
            try
            {
                KlubiDAL dal = new KlubiDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
