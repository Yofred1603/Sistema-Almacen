using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlmacen.Capa_Logica;
using SistemaAlmacen.Capa_Presentacion;

namespace SistemaAlmacen.Capa_Datos
{
    public class Metodo_EntradaProd
    {
        public int idEntrada { get; set; }
        public DateTime Fecha { get; set; }
        public String Estado { get; set; }
        public String Observacion { get; set; }
        public int idProd { get; set; }
        public int idPersonal { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
