using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        /*
        public List<Users> MostrarDatos()
        {
        
            // var query = (from e in db.Users select e );

          
         return query.ToList();

        }
        */

        //COMO PODE EJECUTAR PROCEDIMIENTOS ALMACENADOS
        /*
        public IEnumerable<SearchAllUser_Result> MostrarDatos()
        {

           var query = db.SearchAllUser();

            // var query = (from e in db.Users select e );

            

         return query.ToList();

            
        }

        */
        
        public BindingList<Users> MostrarDatos()
        {

            List<Users> query = (from e in db.Users select e).ToList();
            BindingList<Users> result = new BindingList<Users>(query);

            return result;

        }
      

    }
}
