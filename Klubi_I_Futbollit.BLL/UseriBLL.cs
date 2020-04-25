using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klubi_;
using Klubi_Futbollistik.BO;

namespace Klubi_I_Futbollit.BLL
{
    public class UseriBLL
    {

        private readonly UseriDAL useriDAL;

        public UseriBLL()
        {
            useriDAL = new UseriDAL();
        }

        public bool CheckLogIn1(BO.Useri useri)
        {
            return this.useriDAL.CheckLogIn(useri);
        }
         

    }
}
