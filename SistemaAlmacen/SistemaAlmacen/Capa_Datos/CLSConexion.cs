using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmacen.Capa_Datos
{
    public class CLSConexion
    {

        public static String cnCadena()
        {
            String str = "SERVER=14ET202-PC02;DataBase=SistemaAlmacen;UID=sa;PWD=12345";
            return str;
        }
    }
}
