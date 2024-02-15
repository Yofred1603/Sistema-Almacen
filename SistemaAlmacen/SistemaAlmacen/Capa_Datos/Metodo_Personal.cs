using SistemaAlmacen.Capa_Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmacen.Capa_Datos
{
    public class Metodo_Personal
    {

        public int idPersonal { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String DNI { get; set; }
        public String Direccion { get; set; }

        public String Telefono { get; set; }   
        public String Celular { get; set; }
        public String Correo { get; set; }  
        public String Sexo { get; set; }
        public int idArea { get; set; }
        public int idUsuario { get; set; } 
    }
}
