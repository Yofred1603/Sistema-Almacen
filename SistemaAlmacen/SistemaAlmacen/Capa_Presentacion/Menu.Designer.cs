namespace SistemaAlmacen.Capa_Presentacion
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.imPersonal = new FontAwesome.Sharp.IconMenuItem();
            this.imProducto = new FontAwesome.Sharp.IconMenuItem();
            this.imProveedor = new FontAwesome.Sharp.IconMenuItem();
            this.imArea = new FontAwesome.Sharp.IconMenuItem();
            this.imCategoria_Prod = new FontAwesome.Sharp.IconMenuItem();
            this.imEntrada_Prod = new FontAwesome.Sharp.IconMenuItem();
            this.imSalida_Prod = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imUsuario,
            this.imPersonal,
            this.imProducto,
            this.imProveedor,
            this.imArea,
            this.imCategoria_Prod,
            this.imEntrada_Prod,
            this.imSalida_Prod});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.TabStop = true;
            // 
            // imUsuario
            // 
            resources.ApplyResources(this.imUsuario, "imUsuario");
            this.imUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.imUsuario.IconColor = System.Drawing.Color.Black;
            this.imUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imUsuario.IconSize = 60;
            this.imUsuario.Name = "imUsuario";
            this.imUsuario.Click += new System.EventHandler(this.imUsuario_Click);
            // 
            // imPersonal
            // 
            resources.ApplyResources(this.imPersonal, "imPersonal");
            this.imPersonal.IconChar = FontAwesome.Sharp.IconChar.User;
            this.imPersonal.IconColor = System.Drawing.Color.Black;
            this.imPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imPersonal.IconSize = 60;
            this.imPersonal.Name = "imPersonal";
            this.imPersonal.Click += new System.EventHandler(this.imPersonal_Click);
            // 
            // imProducto
            // 
            resources.ApplyResources(this.imProducto, "imProducto");
            this.imProducto.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.imProducto.IconColor = System.Drawing.Color.Black;
            this.imProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imProducto.IconSize = 60;
            this.imProducto.Name = "imProducto";
            this.imProducto.Click += new System.EventHandler(this.imProducto_Click);
            // 
            // imProveedor
            // 
            resources.ApplyResources(this.imProveedor, "imProveedor");
            this.imProveedor.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.imProveedor.IconColor = System.Drawing.Color.Black;
            this.imProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imProveedor.IconSize = 60;
            this.imProveedor.Name = "imProveedor";
            this.imProveedor.Click += new System.EventHandler(this.imProveedor_Click);
            // 
            // imArea
            // 
            resources.ApplyResources(this.imArea, "imArea");
            this.imArea.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.imArea.IconColor = System.Drawing.Color.Black;
            this.imArea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imArea.IconSize = 60;
            this.imArea.Name = "imArea";
            this.imArea.Click += new System.EventHandler(this.imArea_Click);
            // 
            // imCategoria_Prod
            // 
            resources.ApplyResources(this.imCategoria_Prod, "imCategoria_Prod");
            this.imCategoria_Prod.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.imCategoria_Prod.IconColor = System.Drawing.Color.Black;
            this.imCategoria_Prod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imCategoria_Prod.IconSize = 60;
            this.imCategoria_Prod.Name = "imCategoria_Prod";
            this.imCategoria_Prod.Click += new System.EventHandler(this.imCategoria_Prod_Click);
            // 
            // imEntrada_Prod
            // 
            resources.ApplyResources(this.imEntrada_Prod, "imEntrada_Prod");
            this.imEntrada_Prod.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
            this.imEntrada_Prod.IconColor = System.Drawing.Color.Black;
            this.imEntrada_Prod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imEntrada_Prod.IconSize = 60;
            this.imEntrada_Prod.Name = "imEntrada_Prod";
            this.imEntrada_Prod.Click += new System.EventHandler(this.imEntrada_Prod_Click);
            // 
            // imSalida_Prod
            // 
            resources.ApplyResources(this.imSalida_Prod, "imSalida_Prod");
            this.imSalida_Prod.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingDashedLineArrowRight;
            this.imSalida_Prod.IconColor = System.Drawing.Color.Black;
            this.imSalida_Prod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.imSalida_Prod.IconSize = 60;
            this.imSalida_Prod.Name = "imSalida_Prod";
            this.imSalida_Prod.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // menuTitulo
            // 
            resources.ApplyResources(this.menuTitulo, "menuTitulo");
            this.menuTitulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuTitulo.Name = "menuTitulo";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuTitulo);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem imUsuario;
        private FontAwesome.Sharp.IconMenuItem imPersonal;
        private FontAwesome.Sharp.IconMenuItem imProducto;
        private FontAwesome.Sharp.IconMenuItem imProveedor;
        private FontAwesome.Sharp.IconMenuItem imArea;
        private FontAwesome.Sharp.IconMenuItem imCategoria_Prod;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem imEntrada_Prod;
        private FontAwesome.Sharp.IconMenuItem imSalida_Prod;
        private System.Windows.Forms.Panel panel1;
    }
}