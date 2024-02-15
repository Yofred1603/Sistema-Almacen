using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAlmacen.Capa_Datos;
using SistemaAlmacen.Capa_Presentacion;

namespace SistemaAlmacen.Capa_Logica
{
    public class ClsCategoria_Prod
    {

        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void Insertar_CategoriaProd(Metodo_CategoriaProducto Cp)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_CategoriaProd";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@Categ_Prod", SqlDbType.VarChar));
            Cm.Parameters["@Categ_Prod"].Value = Cp.Categ_Prod;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void Actualizar_CategoriaProd(Metodo_CategoriaProducto Cp)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_CategoriaProd";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idCategoria_Prod", SqlDbType.Int));
            Cm.Parameters["@idCategoria_Prod"].Value = Cp.idCategoria_Prod;
            Cm.Parameters.Add(new SqlParameter("@Categ_Prod", SqlDbType.VarChar));
            Cm.Parameters["@Categ_Prod"].Value = Cp.Categ_Prod;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void LLenarcomboxCategoria()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Llenar_Categoria";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            Cn.Close();
        }
    }
}
