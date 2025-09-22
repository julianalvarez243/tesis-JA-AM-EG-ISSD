using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaEF;

namespace capaDatos
{
    public class usuarioDatos
    {
        public List<Usuario> listarUsuarios()
        {
            using (var db = new GescomDBContext())
            {
                return db.Usuario.ToList();
            }
        }
    }
}
