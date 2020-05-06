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
    public class ReferiBLL
    {
        //public int Fshij(Referi g)
        //{
        //    try
        //    {
        //        ReferiDAL dal = new ReferiDAL();
        //        dal.(g);
        //        int rowsAffected = g.;
        //        return rowsAffected;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public int GjejReferMeID(Referi g)
        {
            try
            {
                ReferiDAL dal = new ReferiDAL();
                dal.GjejReferMeID(g);
                int rowsAffected = g.ReferiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataTable ShfaqListenEGolaShenuesve()
        //{
        //    try
        //    {
        //        ReferiDAL dal = new ReferiDAL();
        //        var r = dal.();
        //        return r;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void Edito(Referi g)
        {
            try
            {
                ReferiDAL dal = new ReferiDAL();
                dal.Edito(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Referi g)
        {
            try
            {
                ReferiDAL dal = new ReferiDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
