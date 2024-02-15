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
    public class ClsPersonal
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public static void Insertar_Personal(Metodo_Personal Mp)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Insertar_Personal";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            Cm.Parameters["@Nombre"].Value = Mp.Nombre;
            Cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            Cm.Parameters["@Apellido"].Value = Mp.Apellido;
            Cm.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar));
            Cm.Parameters["@DNI"].Value = Mp.DNI;
            Cm.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
            Cm.Parameters["@Direccion"].Value = Mp.Direccion;
            Cm.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
            Cm.Parameters["@Telefono"].Value = Mp.Telefono;
            Cm.Parameters.Add(new SqlParameter("@Celular", SqlDbType.VarChar));
            Cm.Parameters["@Celular"].Value = Mp.Celular;
            Cm.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar));
            Cm.Parameters["@Correo"].Value = Mp.Correo;
            Cm.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.VarChar));
            Cm.Parameters["@Sexo"].Value = Mp.Sexo;
            Cm.Parameters.Add(new SqlParameter("@idArea", SqlDbType.VarChar));
            Cm.Parameters["@idArea"].Value = Mp.idArea;
           
           

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void Actualizar_Personal(Metodo_Personal Mp)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "Actualizar_Personal";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@idPersonal", SqlDbType.Int));
            Cm.Parameters["@idPersonal"].Value = Mp.idPersonal;
            Cm.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            Cm.Parameters["@Nombre"].Value = Mp.Nombre;
            Cm.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.VarChar));
            Cm.Parameters["@Apellido"].Value = Mp.Apellido;
            Cm.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar));
            Cm.Parameters["@DNI"].Value = Mp.DNI;
            Cm.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
            Cm.Parameters["@Direccion"].Value = Mp.Direccion;
            Cm.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
            Cm.Parameters["@Telefono"].Value = Mp.Telefono;
            Cm.Parameters.Add(new SqlParameter("@Celular", SqlDbType.VarChar));
            Cm.Parameters["@Celular"].Value = Mp.Celular;
            Cm.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar));
            Cm.Parameters["@Correo"].Value = Mp.Correo;
            Cm.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.VarChar));
            Cm.Parameters["@Sexo"].Value = Mp.Sexo;
            Cm.Parameters.Add(new SqlParameter("@idArea", SqlDbType.VarChar));
            Cm.Parameters["@idArea"].Value = Mp.idArea;
            Cm.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int));
            Cm.Parameters["@idUsuario"].Value = Mp.idUsuario;


            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        public static void LLenarcomboxPersonal()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Llenar_Personal";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            Cn.Close();
        }
    }
}
