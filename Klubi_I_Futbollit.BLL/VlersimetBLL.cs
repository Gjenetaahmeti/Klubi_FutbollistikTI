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
    public class VlersimetBLL
    {
        public void Regjistro(Vlersimet g)
        {
            try
            {
                VlersimetDAL dal = new VlersimetDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edito(Vlersimet g)
        {
            try
            {
                VlersimetDAL dal = new VlersimetDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int Fshij(Vlersimet g)
        {
            try
            {
                VlersimetDAL dal = new VlersimetDAL();
                dal.Fshij(g);
                int rowsAffected = g.StatusiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ShfaqListenEVlersimeve()
        {
            try
            {
                VlersimetDAL dal = new VlersimetDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GjejVlersiminMeID(Vlersimet g)
        {
            try
            {
                VlersimetDAL dal = new VlersimetDAL();
                dal.MerrVlersimeMeID(g);
                int rowsAffected = g.StatusiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
