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
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.statusStripFecha = new System.Windows.Forms.StatusStrip();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.Menu1.Size = new System.Drawing.Size(646, 24);
            this.Menu1.TabIndex = 0;
            this.Menu1.Text = "menuStrip1";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.artículosToolStripMenuItem.Text = "Artículos ";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(237, 40);
            this.lblMenuPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(192, 31);
            this.lblMenuPrincipal.TabIndex = 1;
            this.lblMenuPrincipal.Text = "Menu Principal";
            // 
            // statusStripFecha
            // 
            this.statusStripFecha.BackColor = System.Drawing.Color.LightCyan;
            this.statusStripFecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha});
            this.statusStripFecha.Location = new System.Drawing.Point(0, 419);
            this.statusStripFecha.Name = "statusStripFecha";
            this.statusStripFecha.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStripFecha.Size = new System.Drawing.Size(646, 22);
            this.statusStripFecha.TabIndex = 2;
            this.statusStripFecha.Text = "statusStrip1";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 17);
            this.lblFecha.Text = "toolStripStatusLabel1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Location = new System.Drawing.Point(263, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Artículo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // VentPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(646, 441);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.statusStripFecha);
            this.Controls.Add(this.lblMenuPrincipal);
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
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.StatusStrip statusStripFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.Button btnBuscar;
    }
}

