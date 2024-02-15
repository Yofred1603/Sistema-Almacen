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
    public partial class Entrada_Producto : Form
    {
        public Entrada_Producto()
        {
            InitializeComponent();
        }
        void nuevo()
        {
            txtEstado.Clear();
            txtObservacion.Clear();
            txtIDEntradaP.Clear();
            cbProducto.Text = "Seleccionar";
            cbPersonal.Text = "Seleccionar";
            dtpFecha.ResetText();



            txtEstado.Focus();
        }
        private void Entrada_Producto_Load(object sender, EventArgs e)
        {
            LlenarCbProducto();
            LlenarCbPersonal();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea grabar la entrada del producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_EntradaProd Me = new Metodo_EntradaProd();
                Me.Fecha = DateTime.Parse(dtpFecha.Value.Date.ToString("dd/MM/yyyy"));
                Me.Estado = txtEstado.Text;
                Me.Observacion = txtObservacion.Text;
                Me.idProd = int.Parse(cbProducto.SelectedValue.ToString());
                Me.idPersonal = int.Parse(cbProducto.SelectedValue.ToString());
                CLSEntrada_Prod.Insertar_EntradaProducto(Me);

                MessageBox.Show("Se grabó la entrada del productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea Actualizar la Entrada de Productos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_EntradaProd Me = new Metodo_EntradaProd();
                Me.idEntrada = int.Parse(txtIDEntradaP.Text);
                Me.Fecha = DateTime.Parse(dtpFecha.Value.Date.ToString("dd/MM/yyyy"));
                Me.Estado = txtEstado.Text;
                Me.Observacion = txtObservacion.Text;
                Me.idProd = int.Parse(cbProducto.SelectedValue.ToString());
                Me.idPersonal = int.Parse(cbProducto.SelectedValue.ToString());
                CLSEntrada_Prod.Actualizar_EntradaProducto(Me);

                MessageBox.Show("Se Actualizó la Entrada de Productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscarEP_TextChanged(object sender, EventArgs e)
        {
         
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
        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Metodo_EntradaProd Me = new Metodo_EntradaProd();
                Me.FechaInicio = fInicio.Value;
                Me.FechaFin = fFin.Value;
                CLSEntrada_Prod.BuscarPorFecha(Me);
                dataGridView1.DataSource = CLSEntrada_Prod.ds;
                dataGridView1.DataMember = "Cargar Fecha";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDEntradaP.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEstado.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpFecha.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtObservacion.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbProducto.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbPersonal.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult Rpt;


            Rpt = MessageBox.Show("¿Desea eliminar el producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Rpt == DialogResult.Yes)
            {
                Metodo_EntradaProd Mo = new Metodo_EntradaProd();
                Mo.idEntrada = int.Parse(txtIDEntradaP.Text);
                Mo.Fecha = dtpFecha.Value;
                Mo.Estado = txtEstado.Text;
                Mo.Observacion = txtObservacion.Text;
                Mo.idProd = int.Parse(cbProducto.SelectedValue.ToString());
                Mo.idPersonal = int.Parse(cbPersonal.SelectedValue.ToString());
                CLSEntrada_Prod.Eliminar_EntradaProducto(Mo);

                MessageBox.Show("Se eliminó el producto correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
