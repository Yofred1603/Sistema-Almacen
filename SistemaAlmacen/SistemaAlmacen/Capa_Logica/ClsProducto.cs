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
    public class ClsProducto
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void Insertar_Producto(Metodo_Producto Mo)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_Productos";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@Nom_Prod", SqlDbType.VarChar));
            Cm.Parameters["@Nom_Prod"].Value = Mo.Nom_Prod;
            Cm.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar));
            Cm.Parameters["@Descripcion"].Value = Mo.Descripcion;
            Cm.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int));
            Cm.Parameters["@Stock"].Value = Mo.Stock;
            Cm.Parameters.Add(new SqlParameter("@idCategoria_Prod", SqlDbType.Int));
            Cm.Parameters["@idCategoria_Prod"].Value = Mo.idCategoria_Prod;
            Cm.Parameters.Add(new SqlParameter("@Ruc", SqlDbType.VarChar));
            Cm.Parameters["@Ruc"].Value = Mo.Ruc;
            Cm.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            Cm.Parameters["@Precio"].Value = Mo.Precio;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void Actualizar_Producto(Metodo_Producto Mo)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_Productos";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idProd", SqlDbType.Int));
            Cm.Parameters["@idProd"].Value = Mo.idProd;
            Cm.Parameters.Add(new SqlParameter("@Nom_Prod", SqlDbType.VarChar));
            Cm.Parameters["@Nom_Prod"].Value = Mo.Nom_Prod;
            Cm.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar));
            Cm.Parameters["@Descripcion"].Value = Mo.Descripcion;
            Cm.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int));
            Cm.Parameters["@Stock"].Value = Mo.Stock;
            Cm.Parameters.Add(new SqlParameter("@idCategoria_Prod", SqlDbType.Int));
            Cm.Parameters["@idCategoria_Prod"].Value = Mo.idCategoria_Prod;
            Cm.Parameters.Add(new SqlParameter("@Ruc", SqlDbType.VarChar));
            Cm.Parameters["@Ruc"].Value = Mo.Ruc;
            Cm.Parameters.Add(new SqlParameter("@Precio", SqlDbType.Money));
            Cm.Parameters["@Precio"].Value = Mo.Precio;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close(); 
        }
        public static void LLenarcomboxProducto()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Llenar_Producto";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            Cn.Close();
        }

        public static void ConsultarProductos(Metodo_Producto c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Buscar_Producto";
            da.SelectCommand.Parameters.AddWithValue("@Nom_Prod", c.Nom_Prod);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar Productos");
            Cn.Close();
        }

        public static void EliminarProductos(Metodo_Producto Mo)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Eliminar_Productos";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idProd", SqlDbType.Int));
            Cm.Parameters["@idProd"].Value = Mo.idProd;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }
    }
}
