using SistemaAlmacen.Capa_Presentacion;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmacen.Capa_Datos
{
    public class Metodo_Producto
    {
        public int idProd { get; set; }  

        public String Nom_Prod { get; set; }    
        public String Descripcion { get; set; }
        public int Stock { get; set; }
        public SqlMoney Precio { get; set; }

        public int idCategoria_Prod { get; set; }

        public int idArea { get; set; }
        public string Ruc { get; set; }
        public string Buscar { get; set; }
    }
}
