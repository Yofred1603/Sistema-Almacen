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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Personal_Load(object sender, EventArgs e)
        {
            LlenarCbArea();
        }

        private void LlenarCbArea()
        {
            ClsArea.LLenarcomboxArea();
            cbArea.DataSource = ClsArea.dt;
            cbArea.DisplayMember = "Nombre_Area";
            cbArea.ValueMember = "idArea";
            cbArea.Text = "Seleccionar";
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea Registrar al Personal?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_Personal Mo = new Metodo_Personal();
                Mo.Nombre = txtNombre.Text;
                Mo.Apellido = txtApellido.Text;
                Mo.DNI = txtDNI.Text;
                Mo.Direccion = txtDireccion.Text;
                Mo.Telefono = txtTelefono.Text;
                Mo.Celular = txtCelular.Text;
                Mo.Correo = txtCorreo.Text;
                Mo.Sexo = txtSexo.Text;
                Mo.idArea = int.Parse(cbArea.SelectedValue.ToString());
                ClsPersonal.Insertar_Personal(Mo);

                MessageBox.Show("Se registro el personal correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
