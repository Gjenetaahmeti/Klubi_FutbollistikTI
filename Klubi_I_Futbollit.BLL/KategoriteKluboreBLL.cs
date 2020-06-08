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
   public class KategoriteKluboreBLL
    {
        public int Fshij(KategoriteKlubore g)
        {
            try
            {
                KategoriteKluboreDAL dal = new KategoriteKluboreDAL();
                dal.FshijMeID(g);
                int rowsAffected = g.KategoriaID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejKategorinMeID(KategoriteKlubore g)
        {
            try
            {
                KategoriteKluboreDAL dal = new KategoriteKluboreDAL();
                dal.GjejKlubMeID(g);
                int rowsAffected = g.KategoriaID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqListenEKategorivee()
        {
            try
            {
                KategoriteKluboreDAL dal = new KategoriteKluboreDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(KategoriteKlubore g)
        {
            try
            {
                KategoriteKluboreDAL dal = new KategoriteKluboreDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(KategoriteKlubore g)
        {
            try
            {
                KategoriteKluboreDAL dal = new KategoriteKluboreDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
