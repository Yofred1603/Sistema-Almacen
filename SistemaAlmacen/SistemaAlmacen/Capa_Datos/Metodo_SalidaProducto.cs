using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmacen.Capa_Datos
{
    public class Metodo_SalidaProducto
    {
        public int idSalida { get; set; }
        public DateTime Fecha { get; set; }
        public String Estado { get; set; }
        public String Observacion { get; set; }
        public int idArea { get; set; }
        public int idPersonal { get; set; }
        public int idProd { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
