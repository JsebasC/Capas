using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocio
{
    public class NegocioUsers
    {

        DatoUsers metodos = new DatoUsers();
        public bool Guardar(EntidadUsers dat)
        {
            Users newUser = new Users();
            newUser.name = dat.name;
            newUser.last_name = dat.last_name;
            newUser.birthday = dat.birthday;
            newUser.eps_id = dat.eps_id;
            newUser.created_at = dat.created_at;

            return metodos.Guardar(newUser);

        }

        public List<Users> MostrarDatos()
        {

            return metodos.MostrarDatos();
        }

    }
}
