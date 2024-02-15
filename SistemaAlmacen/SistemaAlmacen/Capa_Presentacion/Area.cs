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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }
        void nuevo()
        {
          
            txtNombre.Clear();
    
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Area_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea Grabar el Area?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_Area Ma = new Metodo_Area();
                Ma.Nombre_Area = txtNombre.Text;
                ClsArea.Insertar_Area(Ma);

                MessageBox.Show("El Area Ingreso Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea Grabar el Area?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_Area Ma = new Metodo_Area();
                Ma.Nombre_Area = txtNombre.Text;
                ClsArea.Actualizar_Area(Ma);

                MessageBox.Show("El Area Ingreso Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
