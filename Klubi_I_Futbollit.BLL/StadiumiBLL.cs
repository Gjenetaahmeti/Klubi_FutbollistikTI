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
    public class StadiumiBLL
    {
        public int Fshij(Stadiumi g)
        {
            try
            {
                StadiumiDAL dal = new StadiumiDAL();
                dal.FshijMeID(g);
                int rowsAffected = g.StadiumiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejStadiuminMeID(Stadiumi g)
        {
            try
            {
                StadiumiDAL dal = new StadiumiDAL();
                dal.GjejStadiumMeID(g);
                int rowsAffected = g.StadiumiID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqListenEStadiumeve()
        {
            try
            {
                StadiumiDAL dal = new StadiumiDAL();
                var r = dal.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(Stadiumi g)
        {
            try
            {
                StadiumiDAL dal = new StadiumiDAL();
                dal.Update(g);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Stadiumi g)
        {
            try
            {
                StadiumiDAL dal = new StadiumiDAL();
                dal.Shto(g);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
