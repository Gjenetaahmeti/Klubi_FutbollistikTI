using Klubi_;
using Klubi_I_Futbollit.BO;
using System;
using System.Data;

namespace Klubi_I_Futbollit.BLL
{
    public class TrajneriBLL
    {
        public int Fshij(Trajneri g)
        {
            try
            {
                TrajneriDAL dal = new TrajneriDAL();
                dal.Fshij(g);
                int rowsAffected = g.TrajneriID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejTrajnerinMeID(Trajneri g)
        {
            try
            {
                TrajneriDAL dal = new TrajneriDAL();
                dal.GjejTrajnerinMeID(g);
                int rowsAffected = g.TrajneriID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqListenETrajnereve()
        {
            try
            {
                TrajneriDAL dal = new TrajneriDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(Trajneri g)
        {
            try
            {
                TrajneriDAL dal = new TrajneriDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Trajneri g)
        {
            try
            {
                TrajneriDAL dal = new TrajneriDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
