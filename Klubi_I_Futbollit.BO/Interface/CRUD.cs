using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klubi_Futbollistik.BO.Interface
{
   public interface CRUD<T>
    {
        int Shto(T model);
        int Fshij(T model);
        int Update(T model);
        List<T> GetAll();
    }
}
