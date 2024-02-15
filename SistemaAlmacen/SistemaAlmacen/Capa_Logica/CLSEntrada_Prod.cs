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
    public class CLSEntrada_Prod
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void Insertar_EntradaProducto(Metodo_EntradaProd Me)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_EntradaProducto";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.Date));
            Cm.Parameters["@Fecha"].Value = Me.Fecha;
            Cm.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar));
            Cm.Parameters["@Estado"].Value = Me.Estado;
            Cm.Parameters.Add(new SqlParameter("@Observacion", SqlDbType.VarChar));
            Cm.Parameters["@Observacion"].Value = Me.Observacion;
            Cm.Parameters.Add(new SqlParameter("@idProd", SqlDbType.Int));
            Cm.Parameters["@idProd"].Value = Me.idProd;
            Cm.Parameters.Add(new SqlParameter("@idPersonal", SqlDbType.Int));
            Cm.Parameters["@idPersonal"].Value = Me.idPersonal;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void Actualizar_EntradaProducto(Metodo_EntradaProd Me)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_EntradaProducto";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idEntrada", SqlDbType.Int));
            Cm.Parameters["@idEntrada"].Value = Me.idEntrada;
            Cm.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.Date));
            Cm.Parameters["@Fecha"].Value = Me.Fecha;
            Cm.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar));
            Cm.Parameters["@Estado"].Value = Me.Estado;
            Cm.Parameters.Add(new SqlParameter("@Observacion", SqlDbType.VarChar));
            Cm.Parameters["@Observacion"].Value = Me.Observacion;
            Cm.Parameters.Add(new SqlParameter("@idProd", SqlDbType.Int));
            Cm.Parameters["@idProd"].Value = Me.idProd;
            Cm.Parameters.Add(new SqlParameter("@idPersonal", SqlDbType.Int));
            Cm.Parameters["@idPersonal"].Value = Me.idPersonal;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }
        public static void Eliminar_EntradaProducto(Metodo_EntradaProd Mo)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Eliminar_EntradaProducto";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idEntrada", SqlDbType.Int));
            Cm.Parameters["@idEntrada"].Value = Mo.idEntrada;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }
        public static void BuscarPorFecha(Metodo_EntradaProd c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "VBuscar_EntradaProducto";
            da.SelectCommand.Parameters.AddWithValue("@FechaInicio", c.FechaInicio);
            da.SelectCommand.Parameters.AddWithValue("@FechaFin", c.FechaFin);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Fecha");

            Cn.Close();
        }
    }
}
