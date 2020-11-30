using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class DatoUsers
    {

        TLJ001Entities db = new TLJ001Entities();

        public bool Guardar(Users data)
        {


            db.Users.Add(data);
            db.SaveChanges();
            return true;
        }

        public List<Users> MostrarDatos()
        {

            //var query = ModelDB.SearchAllUser();
            var query = (from e in db.Users select e);
         

            return query.ToList();
        }


    }
}
