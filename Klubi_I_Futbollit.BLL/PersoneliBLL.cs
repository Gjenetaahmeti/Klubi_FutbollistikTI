using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klubi_;
using Klubi_Futbollistik.DAL;
using Klubi_I_Futbollit.BO;

namespace Klubi_Futbollistik.BLL
{
    public class PersoneliBLL
    {
        private PersoneliDAL personeliDAL;
        public int ShtoPersonel(Personeli personel)
        {
            return personeliDAL.Shto(personel);
        }
    }
}
