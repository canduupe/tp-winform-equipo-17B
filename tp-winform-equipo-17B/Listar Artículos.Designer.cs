namespace tp_winform_equipo_17B
{
    partial class Listar_Artículos
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
            ((System.ComponentModel.ISupportInitialize)(this.dgNegocio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNegocio
            // 
            this.dgNegocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNegocio.Location = new System.Drawing.Point(12, 12);
            this.dgNegocio.Name = "dgNegocio";
            this.dgNegocio.Size = new System.Drawing.Size(291, 300);
            this.dgNegocio.TabIndex = 0;
            // 
            // Listar_Artículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 500);
            this.Controls.Add(this.dgNegocio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(331, 539);
            this.MinimumSize = new System.Drawing.Size(331, 539);
            this.Name = "Listar_Artículos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar_Artículos";
            this.Load += new System.EventHandler(this.Listar_Artículos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNegocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNegocio;
    }
}