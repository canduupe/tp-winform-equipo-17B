﻿namespace tp_winform_equipo_17B
{
    partial class BuscarArticulo
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
            this.lblNombreArti = new System.Windows.Forms.Label();
            this.txtNombreArti = new System.Windows.Forms.TextBox();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.btBuscarArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreArti
            // 
            this.lblNombreArti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreArti.AutoSize = true;
            this.lblNombreArti.Location = new System.Drawing.Point(85, 52);
            this.lblNombreArti.Name = "lblNombreArti";
            this.lblNombreArti.Size = new System.Drawing.Size(47, 13);
            this.lblNombreArti.TabIndex = 0;
            this.lblNombreArti.Text = "Nombre:";
            // 
            // txtNombreArti
            // 
            this.txtNombreArti.Location = new System.Drawing.Point(161, 52);
            this.txtNombreArti.Name = "txtNombreArti";
            this.txtNombreArti.Size = new System.Drawing.Size(159, 20);
            this.txtNombreArti.TabIndex = 1;
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(161, 107);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(159, 21);
            this.cmbMarcas.TabIndex = 2;
            // 
            // lblMarcas
            // 
            this.lblMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(85, 110);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(42, 13);
            this.lblMarcas.TabIndex = 3;
            this.lblMarcas.Text = "Marcas";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(85, 169);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(59, 13);
            this.lblCategorias.TabIndex = 4;
            this.lblCategorias.Text = "Categorías";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(161, 166);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(159, 21);
            this.cmbCategorias.TabIndex = 5;
            // 
            // btBuscarArticulo
            // 
            this.btBuscarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscarArticulo.Location = new System.Drawing.Point(198, 213);
            this.btBuscarArticulo.Name = "btBuscarArticulo";
            this.btBuscarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btBuscarArticulo.TabIndex = 6;
            this.btBuscarArticulo.Text = "Buscar";
            this.btBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(450, 293);
            this.Controls.Add(this.btBuscarArticulo);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.cmbMarcas);
            this.Controls.Add(this.txtNombreArti);
            this.Controls.Add(this.lblNombreArti);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(466, 332);
            this.MinimumSize = new System.Drawing.Size(466, 332);
            this.Name = "BuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Artículo";
            this.Load += new System.EventHandler(this.BuscarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreArti;
        private System.Windows.Forms.TextBox txtNombreArti;
        private System.Windows.Forms.ComboBox cmbMarcas;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Button btBuscarArticulo;
    }
}