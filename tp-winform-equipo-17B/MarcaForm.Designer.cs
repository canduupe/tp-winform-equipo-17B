namespace tp_winform_equipo_17B
{
    partial class MarcaForm
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
            this.btnAgregarMa = new System.Windows.Forms.Button();
            this.btnCancearMa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarcaADd = new System.Windows.Forms.TextBox();
            this.cboMarcass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarMa = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtModMAr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarMa
            // 
            this.btnAgregarMa.Location = new System.Drawing.Point(289, 69);
            this.btnAgregarMa.Name = "btnAgregarMa";
            this.btnAgregarMa.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMa.TabIndex = 0;
            this.btnAgregarMa.Text = "Agregrar";
            this.btnAgregarMa.UseVisualStyleBackColor = true;
            this.btnAgregarMa.Click += new System.EventHandler(this.btnAgregarMa_Click);
            // 
            // btnCancearMa
            // 
            this.btnCancearMa.Location = new System.Drawing.Point(170, 238);
            this.btnCancearMa.Name = "btnCancearMa";
            this.btnCancearMa.Size = new System.Drawing.Size(75, 23);
            this.btnCancearMa.TabIndex = 1;
            this.btnCancearMa.Text = "Volver";
            this.btnCancearMa.UseVisualStyleBackColor = true;
            this.btnCancearMa.Click += new System.EventHandler(this.btnCancearMa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva Marca:";
            // 
            // txtMarcaADd
            // 
            this.txtMarcaADd.Location = new System.Drawing.Point(117, 71);
            this.txtMarcaADd.Name = "txtMarcaADd";
            this.txtMarcaADd.Size = new System.Drawing.Size(149, 20);
            this.txtMarcaADd.TabIndex = 3;
            // 
            // cboMarcass
            // 
            this.cboMarcass.FormattingEnabled = true;
            this.cboMarcass.Location = new System.Drawing.Point(117, 117);
            this.cboMarcass.Name = "cboMarcass";
            this.cboMarcass.Size = new System.Drawing.Size(149, 21);
            this.cboMarcass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccion de Marcas:";
            // 
            // btnEliminarMa
            // 
            this.btnEliminarMa.Location = new System.Drawing.Point(289, 115);
            this.btnEliminarMa.Name = "btnEliminarMa";
            this.btnEliminarMa.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMa.TabIndex = 6;
            this.btnEliminarMa.Text = "Eliminar";
            this.btnEliminarMa.UseVisualStyleBackColor = true;
            this.btnEliminarMa.Click += new System.EventHandler(this.btnEliminarMa_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(289, 162);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtModMAr
            // 
            this.txtModMAr.Location = new System.Drawing.Point(117, 162);
            this.txtModMAr.Name = "txtModMAr";
            this.txtModMAr.Size = new System.Drawing.Size(149, 20);
            this.txtModMAr.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cambiar Marca:";
            // 
            // MarcaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(417, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModMAr);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMarcass);
            this.Controls.Add(this.txtMarcaADd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancearMa);
            this.Controls.Add(this.btnAgregarMa);
            this.MaximumSize = new System.Drawing.Size(433, 337);
            this.MinimumSize = new System.Drawing.Size(433, 337);
            this.Name = "MarcaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarcaForm";
            this.Load += new System.EventHandler(this.MarcaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMa;
        private System.Windows.Forms.Button btnCancearMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarcaADd;
        private System.Windows.Forms.ComboBox cboMarcass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarMa;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtModMAr;
        private System.Windows.Forms.Label label3;
    }
}