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
            this.lblCodigoF = new System.Windows.Forms.Label();
            this.txtFiltrar2 = new System.Windows.Forms.TextBox();
            this.lblFiltroCat = new System.Windows.Forms.Label();
            this.txtFiltrarCate = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNegocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNegocio
            // 
            this.dgNegocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNegocio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgNegocio.Location = new System.Drawing.Point(28, 79);
            this.dgNegocio.MultiSelect = false;
            this.dgNegocio.Name = "dgNegocio";
            this.dgNegocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(174, 349);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(545, 54);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(95, 13);
            this.lblFiltro.TabIndex = 6;
            this.lblFiltro.Text = "Filtrar por NOMBE:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(646, 50);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(104, 20);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblCodigoF
            // 
            this.lblCodigoF.AutoSize = true;
            this.lblCodigoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoF.Location = new System.Drawing.Point(35, 54);
            this.lblCodigoF.Name = "lblCodigoF";
            this.lblCodigoF.Size = new System.Drawing.Size(95, 13);
            this.lblCodigoF.TabIndex = 9;
            this.lblCodigoF.Text = "FIltrar por MARCA:";
            // 
            // txtFiltrar2
            // 
            this.txtFiltrar2.Location = new System.Drawing.Point(136, 51);
            this.txtFiltrar2.Name = "txtFiltrar2";
            this.txtFiltrar2.Size = new System.Drawing.Size(104, 20);
            this.txtFiltrar2.TabIndex = 0;
            this.txtFiltrar2.TextChanged += new System.EventHandler(this.txtFiltrar2_TextChanged);
            // 
            // lblFiltroCat
            // 
            this.lblFiltroCat.AutoSize = true;
            this.lblFiltroCat.Location = new System.Drawing.Point(282, 54);
            this.lblFiltroCat.Name = "lblFiltroCat";
            this.lblFiltroCat.Size = new System.Drawing.Size(118, 13);
            this.lblFiltroCat.TabIndex = 11;
            this.lblFiltroCat.Text = "Filtrar por CATEGORIA:";
            // 
            // txtFiltrarCate
            // 
            this.txtFiltrarCate.Location = new System.Drawing.Point(403, 50);
            this.txtFiltrarCate.Name = "txtFiltrarCate";
            this.txtFiltrarCate.Size = new System.Drawing.Size(104, 20);
            this.txtFiltrarCate.TabIndex = 1;
            this.txtFiltrarCate.TextChanged += new System.EventHandler(this.txtFiltrarCate_TextChanged);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(815, 318);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 12;
            this.btnAnterior.Text = "ANTERIOR";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(946, 317);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // ListarArtículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1049, 452);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.txtFiltrarCate);
            this.Controls.Add(this.lblFiltroCat);
            this.Controls.Add(this.txtFiltrar2);
            this.Controls.Add(this.lblCodigoF);
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
        private System.Windows.Forms.Label lblCodigoF;
        private System.Windows.Forms.TextBox txtFiltrar2;
        private System.Windows.Forms.Label lblFiltroCat;
        private System.Windows.Forms.TextBox txtFiltrarCate;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}