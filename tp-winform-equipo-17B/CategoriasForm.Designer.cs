namespace tp_winform_equipo_17B
{
    partial class CategoriasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatAdd = new System.Windows.Forms.TextBox();
            this.btnAgregarCa = new System.Windows.Forms.Button();
            this.btnCancelarCa = new System.Windows.Forms.Button();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModCat = new System.Windows.Forms.TextBox();
            this.btnModificarMar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Categoria:";
            // 
            // txtCatAdd
            // 
            this.txtCatAdd.Location = new System.Drawing.Point(109, 75);
            this.txtCatAdd.Name = "txtCatAdd";
            this.txtCatAdd.Size = new System.Drawing.Size(138, 20);
            this.txtCatAdd.TabIndex = 1;
            // 
            // btnAgregarCa
            // 
            this.btnAgregarCa.Location = new System.Drawing.Point(266, 75);
            this.btnAgregarCa.Name = "btnAgregarCa";
            this.btnAgregarCa.Size = new System.Drawing.Size(77, 22);
            this.btnAgregarCa.TabIndex = 2;
            this.btnAgregarCa.Text = "Agregar";
            this.btnAgregarCa.UseVisualStyleBackColor = true;
            this.btnAgregarCa.Click += new System.EventHandler(this.btnAgregarCa_Click);
            // 
            // btnCancelarCa
            // 
            this.btnCancelarCa.Location = new System.Drawing.Point(150, 231);
            this.btnCancelarCa.Name = "btnCancelarCa";
            this.btnCancelarCa.Size = new System.Drawing.Size(88, 22);
            this.btnCancelarCa.TabIndex = 3;
            this.btnCancelarCa.Text = "Volver";
            this.btnCancelarCa.UseVisualStyleBackColor = true;
            this.btnCancelarCa.Click += new System.EventHandler(this.btnCancelarCa_Click);
            // 
            // cboCate
            // 
            this.cboCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(109, 124);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(138, 21);
            this.cboCate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categorias:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cambiar Categoria:";
            // 
            // txtModCat
            // 
            this.txtModCat.Location = new System.Drawing.Point(110, 168);
            this.txtModCat.Name = "txtModCat";
            this.txtModCat.Size = new System.Drawing.Size(137, 20);
            this.txtModCat.TabIndex = 8;
            // 
            // btnModificarMar
            // 
            this.btnModificarMar.Location = new System.Drawing.Point(266, 164);
            this.btnModificarMar.Name = "btnModificarMar";
            this.btnModificarMar.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMar.TabIndex = 9;
            this.btnModificarMar.Text = "Modificar";
            this.btnModificarMar.UseVisualStyleBackColor = true;
            this.btnModificarMar.Click += new System.EventHandler(this.btnModificarMar_Click);
            // 
            // CategoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(417, 298);
            this.Controls.Add(this.btnModificarMar);
            this.Controls.Add(this.txtModCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCate);
            this.Controls.Add(this.btnCancelarCa);
            this.Controls.Add(this.btnAgregarCa);
            this.Controls.Add(this.txtCatAdd);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(433, 337);
            this.MinimumSize = new System.Drawing.Size(433, 337);
            this.Name = "CategoriasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriasForm";
            this.Load += new System.EventHandler(this.CategoriasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatAdd;
        private System.Windows.Forms.Button btnAgregarCa;
        private System.Windows.Forms.Button btnCancelarCa;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModCat;
        private System.Windows.Forms.Button btnModificarMar;
    }
}