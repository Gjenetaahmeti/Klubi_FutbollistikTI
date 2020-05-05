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
    public class GolashenuesiBLL
    {
        public int Fshij(Golashenuesit g)
        {
            try
            {
                GolashenuesiDAL dal = new GolashenuesiDAL();
                dal.Fshij(g);
                int rowsAffected = g.GolashenuesiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejGolashenuesinmeID(Golashenuesit g)
        {
            try
            {
                GolashenuesiDAL dal = new GolashenuesiDAL();
                dal.MerrGolashenuesinMeID(g);
                int rowsAffected = g.lojtariID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqListenEGolaShenuesve()
        {
            try
            {
                GolashenuesiDAL dal = new GolashenuesiDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(Golashenuesit g)
        {
            try
            {
                GolashenuesiDAL dal = new GolashenuesiDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Golashenuesit g)
        {
            try
            {
                GolashenuesiDAL dal = new GolashenuesiDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
