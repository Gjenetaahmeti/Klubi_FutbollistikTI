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
   public class NdeshjaBLL
    {
        public int Fshij(Ndeshja g)
        {
            try
            {
                NdeshjaDAL dal = new NdeshjaDAL();
                dal.Fshij(g);
                int rowsAffected = g.NdeshjaID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejNdeshjenMeID(Ndeshja g)
        {
            try
            {
                NdeshjaDAL dal = new NdeshjaDAL();
                dal.MerrNdeshjeMeID(g);
                int rowsAffected = g.NdeshjaID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqListenENdeshjeve()
        {
            try
            {
                NdeshjaDAL dal = new NdeshjaDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(Ndeshja g)
        {
            try
            {
                NdeshjaDAL dal = new NdeshjaDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Ndeshja g)
        {
            try
            {
                NdeshjaDAL dal = new NdeshjaDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
