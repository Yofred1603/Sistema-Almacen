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
    public partial class Salida_Producto : Form
    {
        public Salida_Producto()
        {
            InitializeComponent();
        }
        void nuevo()
        {
            txtEstado.Clear();
            txtObservacion.Clear();
            txtIDSalida.Clear();           
            cbProducto.Text = "";
            cbPersonal.Text = "";
            dtpFecha.ResetText();
        }
            private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Salida_Producto_Load(object sender, EventArgs e)
        {
            
            LlenarCbProducto();
            LlenarCbPersonal();
            
        }
        private void LlenarCbProducto()
        {
            ClsProducto.LLenarcomboxProducto();
            cbProducto.DataSource = ClsProducto.dt;
            cbProducto.DisplayMember = "Nom_Prod";
            cbProducto.ValueMember = "idProd";
            cbProducto.Text = "Seleccionar";
        }

        private void LlenarCbPersonal()
        {
            ClsPersonal.LLenarcomboxPersonal();
            cbPersonal.DataSource = ClsPersonal.dt;
            cbPersonal.DisplayMember = "Nombre";
            cbPersonal.ValueMember = "idPersonal";
            cbPersonal.Text = "Seleccionar";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea Grabar la Salida de Productos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_SalidaProducto Ms = new Metodo_SalidaProducto();
                Ms.Fecha = DateTime.Parse(dtpFecha.Value.Date.ToString("dd/MM/yyyy"));
                Ms.Estado = txtEstado.Text;
                Ms.Observacion = txtObservacion.Text;
                Ms.idProd = int.Parse(cbProducto.SelectedValue.ToString()); 
                Ms.idPersonal = int.Parse(cbPersonal.SelectedValue.ToString()); 
                CLsSalida_Prod.Insertar_SalidaProducto(Ms);

                MessageBox.Show("Se Grabo la Entrada de Productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea Actualizar la Salida de Productos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_SalidaProducto Me = new Metodo_SalidaProducto();
                Me.idSalida = int.Parse(txtIDSalida.Text);
                Me.Fecha = DateTime.Parse(dtpFecha.Value.Date.ToString("dd/MM/yyyy"));
                Me.Estado = txtEstado.Text;
                Me.Observacion = txtObservacion.Text;
                Me.idProd = int.Parse(cbProducto.SelectedValue.ToString()); ;
                Me.idPersonal = int.Parse(cbPersonal.SelectedValue.ToString()); 
                CLsSalida_Prod.Actualizar_SalidaProducto(Me);

                MessageBox.Show("Se Actualizó la Salida de Productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDSalida.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEstado.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpFecha.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtObservacion.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbProducto.Text = this.dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbPersonal.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void fInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Metodo_SalidaProducto Me = new Metodo_SalidaProducto();
            Me.FechaInicio = fInicio.Value;
            Me.FechaFin = fFin.Value;
            CLsSalida_Prod.BuscarPorFecha(Me);
            dataGridView1.DataSource = CLsSalida_Prod.ds;
            dataGridView1.DataMember = "Cargar FechaS";
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea eliminar el producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_SalidaProducto Mo = new Metodo_SalidaProducto();
                Mo.idSalida = int.Parse(txtIDSalida.Text);
                Mo.Fecha = dtpFecha.Value;
                Mo.Estado = txtEstado.Text;
                Mo.Observacion = txtObservacion.Text;
                Mo.idProd = int.Parse(cbProducto.SelectedValue.ToString());
                Mo.idPersonal = int.Parse(cbPersonal.SelectedValue.ToString());
                CLsSalida_Prod.Eliminar_SalidaProducto(Mo);

                MessageBox.Show("Se eliminó el producto correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDSalida.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEstado.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpFecha.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtObservacion.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbProducto.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbPersonal.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
