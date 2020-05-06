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
   public class UshtrimeBLL
    {
        public int Fshij(Ushtrimet g)
        {
            try
            {
                UshtrimetDAL dal = new UshtrimetDAL();
                dal.FshijMeID(g);
                int rowsAffected = g.UshtrimetID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejUshtrimetMeID(Ushtrimet g)
        {
            try
            {
                UshtrimetDAL dal = new UshtrimetDAL();
                dal.GjejUshtrimMeID(g);
                int rowsAffected = g.UshtrimetID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqTeGjithaUshtrimet()
        {
            try
            {
                UshtrimetDAL dal = new UshtrimetDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(Ushtrimet g)
        {
            try
            {
                UshtrimetDAL dal = new UshtrimetDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Ushtrimet g)
        {
            try
            {
                UshtrimetDAL dal = new UshtrimetDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
