namespace tp_winform_equipo_17B
{
    partial class ListarArtículos
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
            this.dgNegocio = new System.Windows.Forms.DataGridView();
            this.pictureBoxArti = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNegocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNegocio
            // 
            this.dgNegocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNegocio.Location = new System.Drawing.Point(28, 79);
            this.dgNegocio.Name = "dgNegocio";
            this.dgNegocio.Size = new System.Drawing.Size(749, 242);
            this.dgNegocio.TabIndex = 0;
            this.dgNegocio.SelectionChanged += new System.EventHandler(this.dgNegocio_SelectionChanged);
            // 
            // pictureBoxArti
            // 
            this.pictureBoxArti.Location = new System.Drawing.Point(815, 108);
            this.pictureBoxArti.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxArti.Name = "pictureBoxArti";
            this.pictureBoxArti.Size = new System.Drawing.Size(206, 204);
            this.pictureBoxArti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArti.TabIndex = 2;
            this.pictureBoxArti.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(72, 349);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(275, 349);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(174, 349);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 5;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(431, 50);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(116, 16);
            this.lblFiltro.TabIndex = 6;
            this.lblFiltro.Text = "Filtrar por nombre:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(547, 49);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(138, 20);
            this.txtFiltro.TabIndex = 7;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(702, 47);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // ListarArtículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1049, 452);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pictureBoxArti);
            this.Controls.Add(this.dgNegocio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1065, 491);
            this.MinimumSize = new System.Drawing.Size(1065, 491);
            this.Name = "ListarArtículos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Artículos";
            this.Load += new System.EventHandler(this.Listar_Artículos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNegocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNegocio;
        private System.Windows.Forms.PictureBox pictureBoxArti;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btBuscar;
    }
}