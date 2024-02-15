using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SistemaAlmacen.Capa_Presentacion
{
    public partial class Menu : Form
    {
        private static Form formularioActivo = null;
        
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Salida_Producto());
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if(formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panel1.Controls.Add(formulario);
            formulario.Show();
        }

        private void imUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void imPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Personal());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void imProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Producto());
        }

        private void imProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Proveedor());
        }

        private void imArea_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Area());
        }

        private void imCategoria_Prod_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Categoria_Producto());
        }

        private void imEntrada_Prod_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Entrada_Producto());
        }
    }
}
