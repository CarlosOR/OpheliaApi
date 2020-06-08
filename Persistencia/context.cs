using Persistencia.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class context
    {


        private readonly static OpheliaEntities db = new OpheliaEntities();

        public static OpheliaEntities Instance
        {
            get
            {
                return db;
            }
        }






        public void GuardarCambios()
        {
            db.SaveChanges();
        }
       





    }
}
