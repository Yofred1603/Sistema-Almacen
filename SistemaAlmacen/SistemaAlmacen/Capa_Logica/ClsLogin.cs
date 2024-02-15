using SistemaAlmacen.Capa_Datos;
using SistemaAlmacen.Capa_Presentacion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = SistemaAlmacen.Capa_Presentacion.Menu;

namespace SistemaAlmacen.Capa_Logica
{
     class ClsLogin
    {

        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;


        public static void Val_Usuario(Metodo_usuario Mu)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = CLSConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "Validacion";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@usuario", Mu.usuario);
            Cm.Parameters.AddWithValue("@contraseña", Mu.contraseña);
            dr = Cm.ExecuteReader();

            if (dr.HasRows == false)
            {
                throw new Exception("Usuario No Valido");
            }
            else dr.Read();
            {
                MessageBox.Show("Bienvenido Al Sistema", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();
                menu.Show();
            }
            Cn.Close();
        }


    }
}
