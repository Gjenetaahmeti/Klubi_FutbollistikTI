using Klubi_;
using Klubi_I_Futbollit.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace Klubi_I_Futbollit.BLL
{
    public class LojtariBLL
    {
        public int Fshij(Lojtari l)
        {
            try
            {
                LojtariDAL dal = new LojtariDAL();
                dal.Fshij(l);
                int rowsAffected = l.LojtariID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejLojtarMeID(Lojtari l)
        {
            try
            {
                LojtariDAL gjejlojtarin = new LojtariDAL();
                gjejlojtarin.GjejLojtarinMeID(l);
                int rowsAffected = l.LojtariID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqLojtaret()
        {
            try
            {
                LojtariDAL obj = new LojtariDAL();
                var r= obj.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito( Lojtari l)
        {
            try
            {
                LojtariDAL dal = new LojtariDAL();
                dal.Update(l);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Lojtari l)
        {
            try
            {
                LojtariDAL lojtariDAL = new LojtariDAL();
                lojtariDAL.Shto(l);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
