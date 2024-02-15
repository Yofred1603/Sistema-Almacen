using SistemaAlmacen.Capa_Datos;
using SistemaAlmacen.Capa_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlmacen.Capa_Presentacion
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            LlenarcbCategoria();
            LlenarProveedor();
        }
        private void LlenarcbCategoria()
        {
            ClsCategoria_Prod.LLenarcomboxCategoria();
            cbCategoria.DataSource = ClsCategoria_Prod.dt;
            cbCategoria.DisplayMember = "Categ_Prod";
            cbCategoria.ValueMember = "idCategoria_Prod";
            cbCategoria.Text = "Seleccionar";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LlenarProveedor()
        {
            ClsProveeodr.LLenarcomboxProveedor();
            CbProveedor.DataSource = ClsProveeodr.dt;
            CbProveedor.DisplayMember = "Nombre_Prov";
            CbProveedor.ValueMember = "Ruc";
            CbProveedor.Text = "Seleccionar";
        }

       
        private void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea Grabar el Producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_Producto Mo = new Metodo_Producto();
                Mo.Nom_Prod = txtNombre.Text;
                Mo.Descripcion = txtDescripcion.Text;
                Mo.Stock = int.Parse(txtStock.Text);
                Mo.Precio = SqlMoney.Parse(txtPrecio.Text);
                Mo.idCategoria_Prod= int.Parse(cbCategoria.SelectedValue.ToString()); 
                Mo.Ruc = CbProveedor.SelectedValue.ToString(); 
                ClsProducto.Insertar_Producto(Mo);

                MessageBox.Show("Se Grabo el producto correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text == "")
            {
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Visible = true;
                Metodo_Producto Gl = new Metodo_Producto();
                Gl.Nom_Prod = txtBuscarProducto.Text;
                ClsProducto.ConsultarProductos(Gl);
                dataGridView1.DataSource = ClsProducto.ds;
                dataGridView1.DataMember = "Cargar Productos";
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescripcion.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStock.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbCategoria.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            CbProveedor.Text = this.dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPrecio.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Metodo_Producto Mo = new Metodo_Producto();
        }
        void nuevo()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            cbCategoria.Text = "Seleccionar";
            CbProveedor.Text = "Seleccionar";
            txtPrecio.Clear();
            txtNombre.Focus();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea editar el producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_Producto Mo = new Metodo_Producto();
                Mo.idProd = int.Parse(txtID.Text);
                Mo.Nom_Prod = txtNombre.Text;
                Mo.Descripcion = txtDescripcion.Text;
                Mo.Stock = int.Parse(txtStock.Text);
                Mo.Precio = SqlMoney.Parse(txtPrecio.Text);
                Mo.idCategoria_Prod = int.Parse(cbCategoria.SelectedValue.ToString());
                Mo.Ruc = CbProveedor.SelectedValue.ToString();
                ClsProducto.Actualizar_Producto(Mo);

                MessageBox.Show("Se actualizó el producto correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea eliminar el producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_Producto Mo = new Metodo_Producto();
                Mo.idProd = int.Parse(txtID.Text);
                Mo.Nom_Prod = txtNombre.Text;
                Mo.Descripcion = txtDescripcion.Text;
                Mo.Stock = int.Parse(txtStock.Text);
                Mo.Precio = SqlMoney.Parse(txtPrecio.Text);
                Mo.idCategoria_Prod = int.Parse(cbCategoria.SelectedValue.ToString());
                Mo.Ruc = CbProveedor.SelectedValue.ToString();
                ClsProducto.EliminarProductos(Mo);

                MessageBox.Show("Se eliminó el producto correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescripcion.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStock.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbCategoria.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            CbProveedor.Text = this.dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPrecio.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
