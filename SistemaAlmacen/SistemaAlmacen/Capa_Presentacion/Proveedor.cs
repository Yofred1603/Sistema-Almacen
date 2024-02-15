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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }


        private void Clear()
        {
            txtRuc.Clear();
            txtNomProv.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtRuc.Focus();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Grabar al Proveedor?", "Avisas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (Rpt == DialogResult.Yes)
            {
                Metodo_Proveedor Mp = new Metodo_Proveedor();
                Mp.Ruc = txtRuc.Text;
                Mp.Nombre_Prov = txtNomProv.Text;
                Mp.Celular = txtCelular.Text;
                Mp.Email = txtEmail.Text;
                Mp.Direccion = txtDireccion.Text;
                ClsProveeodr.Actualizar_Proveedor(Mp);

                MessageBox.Show("Proveedor Ingreso correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Grabar al Proveedor?", "Avisas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (Rpt == DialogResult.Yes)
            {
                Metodo_Proveedor Mp = new Metodo_Proveedor();
                Mp.Ruc = txtRuc.Text;
                Mp.Nombre_Prov = txtNomProv.Text;
                Mp.Celular = txtCelular.Text;
                Mp.Email = txtEmail.Text;
                Mp.Direccion = txtDireccion.Text;
                ClsProveeodr.Insertar_Proveedor(Mp);

                MessageBox.Show("Proveedor Ingreso correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;

            Rpt = MessageBox.Show("¿Desea Grabar al Proveedor?", "Avisas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (Rpt == DialogResult.Yes)
            {
                Metodo_Proveedor Mp = new Metodo_Proveedor();
                Mp.Ruc = txtRuc.Text;
                Mp.Nombre_Prov = txtNomProv.Text;
                Mp.Celular = txtCelular.Text;
                Mp.Email = txtEmail.Text;
                Mp.Direccion = txtDireccion.Text;
                ClsProveeodr.Insertar_Proveedor(Mp);

                MessageBox.Show("Proveedor Ingreso correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
