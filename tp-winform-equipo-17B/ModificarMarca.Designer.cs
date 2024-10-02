namespace tp_winform_equipo_17B
{
    partial class ModificarMarca
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
            this.txtMod = new System.Windows.Forms.TextBox();
            this.btnAcotMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Nombre";
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(25, 56);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(187, 20);
            this.txtMod.TabIndex = 1;
            // 
            // btnAcotMod
            // 
            this.btnAcotMod.Location = new System.Drawing.Point(80, 123);
            this.btnAcotMod.Name = "btnAcotMod";
            this.btnAcotMod.Size = new System.Drawing.Size(75, 23);
            this.btnAcotMod.TabIndex = 2;
            this.btnAcotMod.Text = "Aceptar";
            this.btnAcotMod.UseVisualStyleBackColor = true;
            // 
            // ModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(239, 169);
            this.Controls.Add(this.btnAcotMod);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(255, 208);
            this.MinimumSize = new System.Drawing.Size(255, 208);
            this.Name = "ModificarMarca";
            this.Text = "ModificarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.Button btnAcotMod;
    }
}