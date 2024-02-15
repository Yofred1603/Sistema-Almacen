using SistemaAlmacen.Capa_Datos;
using SistemaAlmacen.Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlmacen.Capa_Presentacion
{
    public partial class Categoria_Producto : Form
    {
        public Categoria_Producto()
        {
            InitializeComponent();
        }

        private void nuevo()
        {

            txtCategoriProd.Clear();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Categoria_Producto_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Grabar la Categoria del Producto", "Avisas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Rpt == DialogResult.Yes)
            {
                Metodo_CategoriaProducto Cp = new Metodo_CategoriaProducto();
                Cp.Categ_Prod = txtCategoriProd.Text;
                ClsCategoria_Prod.Insertar_CategoriaProd (Cp);

                MessageBox.Show("Categoria Producto se Grabo Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Actualizar la Categoria del Producto", "Avisas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Rpt == DialogResult.Yes)
            {
                Metodo_CategoriaProducto Cp = new Metodo_CategoriaProducto();
                Cp.Categ_Prod = txtCategoriProd.Text;
                ClsCategoria_Prod.Actualizar_CategoriaProd(Cp);

                MessageBox.Show("Categoria Producto se Actualizo Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Grabar la Categoria del Producto", "Avisas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Rpt == DialogResult.Yes)
            {
                Metodo_CategoriaProducto Cp = new Metodo_CategoriaProducto();
                Cp.Categ_Prod = txtCategoriProd.Text;
                ClsCategoria_Prod.Insertar_CategoriaProd(Cp);

                MessageBox.Show("Categoria Producto se Grabo Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Actualizar la Categoria del Producto", "Avisas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Rpt == DialogResult.Yes)
            {
                Metodo_CategoriaProducto Cp = new Metodo_CategoriaProducto();
                Cp.Categ_Prod = txtCategoriProd.Text;
                ClsCategoria_Prod.Actualizar_CategoriaProd(Cp);

                MessageBox.Show("Categoria Producto se Actualizo Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
