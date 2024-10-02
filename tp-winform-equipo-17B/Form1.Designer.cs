namespace tp_winform_equipo_17B
{
    partial class VentPrincipal
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
            this.Menu1 = new System.Windows.Forms.MenuStrip();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripFecha = new System.Windows.Forms.StatusStrip();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnListarArticulos = new System.Windows.Forms.Button();
            this.lbBienvenidos = new System.Windows.Forms.Label();
            this.tsCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1.SuspendLayout();
            this.statusStripFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu1
            // 
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem});
            this.Menu1.Location = new System.Drawing.Point(0, 0);
            this.Menu1.Name = "Menu1";
            this.Menu1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menu1.Size = new System.Drawing.Size(649, 24);
            this.Menu1.TabIndex = 0;
            this.Menu1.Text = "menuStrip1";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.tsCategorias,
            this.tsMarcas});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.artículosToolStripMenuItem.Text = "Archivo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Nuevo&Artículo";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // statusStripFecha
            // 
            this.statusStripFecha.BackColor = System.Drawing.Color.LightCyan;
            this.statusStripFecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha});
            this.statusStripFecha.Location = new System.Drawing.Point(0, 419);
            this.statusStripFecha.Name = "statusStripFecha";
            this.statusStripFecha.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStripFecha.Size = new System.Drawing.Size(649, 22);
            this.statusStripFecha.TabIndex = 2;
            this.statusStripFecha.Text = "statusStrip1";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(131, 17);
            this.lblFecha.Text = "toolStripStatusLabel1";
            // 
            // btnListarArticulos
            // 
            this.btnListarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListarArticulos.Location = new System.Drawing.Point(245, 220);
            this.btnListarArticulos.Name = "btnListarArticulos";
            this.btnListarArticulos.Size = new System.Drawing.Size(153, 45);
            this.btnListarArticulos.TabIndex = 4;
            this.btnListarArticulos.Text = "ARTÍCULOS";
            this.btnListarArticulos.UseVisualStyleBackColor = true;
            this.btnListarArticulos.Click += new System.EventHandler(this.btnListarArticulos_Click);
            // 
            // lbBienvenidos
            // 
            this.lbBienvenidos.AutoSize = true;
            this.lbBienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenidos.Location = new System.Drawing.Point(172, 137);
            this.lbBienvenidos.Name = "lbBienvenidos";
            this.lbBienvenidos.Size = new System.Drawing.Size(314, 31);
            this.lbBienvenidos.TabIndex = 5;
            this.lbBienvenidos.Text = "ROUGH MAGNAMENT";
            // 
            // tsCategorias
            // 
            this.tsCategorias.Name = "tsCategorias";
            this.tsCategorias.Size = new System.Drawing.Size(180, 22);
            this.tsCategorias.Text = "Categorias";
            this.tsCategorias.Click += new System.EventHandler(this.tsCategorias_Click);
            // 
            // tsMarcas
            // 
            this.tsMarcas.Name = "tsMarcas";
            this.tsMarcas.Size = new System.Drawing.Size(180, 22);
            this.tsMarcas.Text = "Marcas";
            this.tsMarcas.Click += new System.EventHandler(this.tsMarcas_Click);
            // 
            // VentPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(649, 441);
            this.Controls.Add(this.lbBienvenidos);
            this.Controls.Add(this.btnListarArticulos);
            this.Controls.Add(this.statusStripFecha);
            this.Controls.Add(this.Menu1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(831, 686);
            this.MinimumSize = new System.Drawing.Size(662, 480);
            this.Name = "VentPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rough Magnament";
            this.Load += new System.EventHandler(this.VentPrincipal_Load);
            this.Menu1.ResumeLayout(false);
            this.Menu1.PerformLayout();
            this.statusStripFecha.ResumeLayout(false);
            this.statusStripFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.Button btnListarArticulos;
        private System.Windows.Forms.Label lbBienvenidos;
        private System.Windows.Forms.ToolStripMenuItem tsCategorias;
        private System.Windows.Forms.ToolStripMenuItem tsMarcas;
    }
}

