﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klubi_;

using Klubi_I_Futbollit.BO;


namespace Klubi_Futbollistik.BLL
{
    public class PersoneliBLL
    {
        public int Fshij(Personeli l)
        {
            try
            {
                PersoneliDAL dal = new PersoneliDAL();
                dal.Fshij(l);
                int rowsAffected = l.PersonelID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GjejPersonelMeID(Personeli l)
        {
            try
            {
                PersoneliDAL gjejpersonel = new PersoneliDAL();
                gjejpersonel.GjejPersonelMeID(l);
                int rowsAffected = l.PersonelID;
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ShfaqPersonel()
        {
            try
            {
                PersoneliDAL obj = new PersoneliDAL();
                var r = obj.GetAll();
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edito(Personeli l)
        {
            try
            {
                PersoneliDAL dal = new PersoneliDAL();
                dal.Update(l);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Regjistro(Personeli l)
        {
            try
            {
                PersoneliDAL personeli = new PersoneliDAL();
                personeli.Shto(l);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
