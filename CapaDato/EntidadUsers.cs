using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
   public class EntidadUsers
   {

        public int id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public int? eps_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }

        public virtual Eps Eps { get; set; }

   }
}
