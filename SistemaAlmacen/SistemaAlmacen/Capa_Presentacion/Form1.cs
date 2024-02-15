using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAlmacen.Capa_Datos;
using SistemaAlmacen.Capa_Logica;

namespace SistemaAlmacen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Metodo_usuario Mll = new Metodo_usuario();
            Mll.usuario = txtUsuario.Text;
            Mll.contraseña = txtContrasena.Text;
            try
            {
                ClsLogin.Val_Usuario(Mll);
                this.Hide();
            }
            catch (Exception) { MessageBox.Show("Datos Incorrectos", "Acceso Denegado", MessageBoxButtons.OKCancel); }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Metodo_usuario mu = new Metodo_usuario();
                mu.usuario = txtUsuario.Text;
                mu.contraseña = txtContrasena.Text;
                try
                {
                    ClsLogin.Val_Usuario(mu);
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
