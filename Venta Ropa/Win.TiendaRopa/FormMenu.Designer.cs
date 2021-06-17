namespace Win.TiendaRopa
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caballeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niñoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.niñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaventaToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.departamentoToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaventaToolStripMenuItem
            // 
            this.nuevaventaToolStripMenuItem.Name = "nuevaventaToolStripMenuItem";
            this.nuevaventaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaventaToolStripMenuItem.Text = "Nueva venta";
            this.nuevaventaToolStripMenuItem.Click += new System.EventHandler(this.nuevaventaToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caballeroToolStripMenuItem,
            this.damaToolStripMenuItem,
            this.niñoToolStripMenuItem1,
            this.niñaToolStripMenuItem,
            this.deporteToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // caballeroToolStripMenuItem
            // 
            this.caballeroToolStripMenuItem.Name = "caballeroToolStripMenuItem";
            this.caballeroToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.caballeroToolStripMenuItem.Text = "Caballero";
            // 
            // damaToolStripMenuItem
            // 
            this.damaToolStripMenuItem.Name = "damaToolStripMenuItem";
            this.damaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.damaToolStripMenuItem.Text = "Dama";
            // 
            // niñoToolStripMenuItem1
            // 
            this.niñoToolStripMenuItem1.Name = "niñoToolStripMenuItem1";
            this.niñoToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.niñoToolStripMenuItem1.Text = "Niño";
            // 
            // niñaToolStripMenuItem
            // 
            this.niñaToolStripMenuItem.Name = "niñaToolStripMenuItem";
            this.niñaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.niñaToolStripMenuItem.Text = "Niña";
            // 
            // deporteToolStripMenuItem
            // 
            this.deporteToolStripMenuItem.Name = "deporteToolStripMenuItem";
            this.deporteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deporteToolStripMenuItem.Text = "Deporte";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 333);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caballeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niñoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem niñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
    }
}

