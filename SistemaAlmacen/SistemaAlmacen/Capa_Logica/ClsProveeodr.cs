using SistemaAlmacen.Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmacen.Capa_Logica
{
    public class ClsProveeodr
    {

        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void Insertar_Proveedor(Metodo_Proveedor o)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_Proveedor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@Ruc", SqlDbType.VarChar));
            Cm.Parameters["@Ruc"].Value = o.Ruc;
            Cm.Parameters.Add(new SqlParameter("@Nombre_Prov", SqlDbType.VarChar));
            Cm.Parameters["@Nombre_Prov"].Value = o.Nombre_Prov;
            Cm.Parameters.Add(new SqlParameter("@Celular", SqlDbType.VarChar));
            Cm.Parameters["@Celular"].Value = o.Celular;
            Cm.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar));
            Cm.Parameters["@Email"].Value = o.Email;
            Cm.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
            Cm.Parameters["@Direccion"].Value = o.Direccion;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void Actualizar_Proveedor(Metodo_Proveedor o)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_Proveedor";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@Ruc", SqlDbType.VarChar));
            Cm.Parameters["@Ruc"].Value = o.Ruc;
            Cm.Parameters.Add(new SqlParameter("@Nombre_Prov", SqlDbType.VarChar));
            Cm.Parameters["@Nombre_Prov"].Value = o.Nombre_Prov;
            Cm.Parameters.Add(new SqlParameter("@Celular", SqlDbType.VarChar));
            Cm.Parameters["@Celular"].Value = o.Celular;
            Cm.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar));
            Cm.Parameters["@Email"].Value = o.Email;
            Cm.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
            Cm.Parameters["@Direccion"].Value = o.Direccion;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void LLenarcomboxProveedor()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Llenar_Proveedor";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            Cn.Close();
        }

    }
}
