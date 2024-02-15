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
    public class ClsArea
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void Insertar_Area(Metodo_Area Ma)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_Area";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@Nombre_Area", SqlDbType.VarChar));
            Cm.Parameters["@Nombre_Area"].Value = Ma.Nombre_Area;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void Actualizar_Area(Metodo_Area Ma)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_Area";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idArea", SqlDbType.Int));
            Cm.Parameters["@idArea"].Value = Ma.idArea;
            Cm.Parameters.Add(new SqlParameter("@Nombre_Area", SqlDbType.VarChar));
            Cm.Parameters["@Nombre_Area"].Value = Ma.Nombre_Area;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }


        public static void LLenarcomboxArea()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Llenar_Area";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            Cn.Close();
        }

    }
}
