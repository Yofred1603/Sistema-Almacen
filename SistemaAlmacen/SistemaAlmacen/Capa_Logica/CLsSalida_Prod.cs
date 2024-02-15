using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlmacen.Capa_Datos;

namespace SistemaAlmacen.Capa_Logica
{
    public class CLsSalida_Prod
    {

        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;


        public static void Insertar_SalidaProducto(Metodo_SalidaProducto Ms)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_SalidaProducto";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.Date));
            Cm.Parameters["@Fecha"].Value = Ms.Fecha;
            Cm.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar));
            Cm.Parameters["@Estado"].Value = Ms.Estado;
            Cm.Parameters.Add(new SqlParameter("@Observacion", SqlDbType.VarChar));
            Cm.Parameters["@Observacion"].Value = Ms.Observacion;
            Cm.Parameters.Add(new SqlParameter("@idPersonal", SqlDbType.Int));
            Cm.Parameters["@idPersonal"].Value = Ms.idPersonal;
            Cm.Parameters.Add(new SqlParameter("@idProd", SqlDbType.Int));
            Cm.Parameters["@idProd"].Value = Ms.idProd;
            

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void Actualizar_SalidaProducto(Metodo_SalidaProducto Ms)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_SalidaProducto";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idSalida", SqlDbType.Int));
            Cm.Parameters["@idSalida"].Value = Ms.idSalida;
            Cm.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.Date));
            Cm.Parameters["@Fecha"].Value = Ms.Fecha;
            Cm.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar));
            Cm.Parameters["@Estado"].Value = Ms.Estado;
            Cm.Parameters.Add(new SqlParameter("@Observacion", SqlDbType.VarChar));
            Cm.Parameters["@Observacion"].Value = Ms.Observacion;
            Cm.Parameters.Add(new SqlParameter("@idArea", SqlDbType.Int));
            Cm.Parameters["@idArea"].Value = Ms.idArea;
            Cm.Parameters.Add(new SqlParameter("@idPersonal", SqlDbType.Int));
            Cm.Parameters["@idPersonal"].Value = Ms.idPersonal;
            Cm.Parameters.Add(new SqlParameter("@idProd", SqlDbType.Int));
            Cm.Parameters["@idProd"].Value = Ms.idProd;


            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void Eliminar_SalidaProducto(Metodo_SalidaProducto Mo)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Eliminar_SalidaProducto";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idSalida", SqlDbType.Int));
            Cm.Parameters["@idSalida"].Value = Mo.idSalida;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void BuscarPorFecha(Metodo_SalidaProducto c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VBuscar_SalidaProducto";
            da.SelectCommand.Parameters.AddWithValue("@FechaInicio", c.FechaInicio);
            da.SelectCommand.Parameters.AddWithValue("@FechaFin", c.FechaFin);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar FechaS");

            Cn.Close();
        }
    }
}
