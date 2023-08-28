namespace PryEliasSp1
{
    partial class FrmPrincipal
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
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnGrabarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Location = new System.Drawing.Point(24, 267);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(117, 48);
            this.btnCrearArchivo.TabIndex = 0;
            this.btnCrearArchivo.Text = "Crear archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Location = new System.Drawing.Point(160, 267);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(109, 48);
            this.btnLeerArchivo.TabIndex = 1;
            this.btnLeerArchivo.Text = "Leer archivo";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(12, 12);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(237, 126);
            this.txtDatos.TabIndex = 2;
            // 
            // btnGrabarDatos
            // 
            this.btnGrabarDatos.Location = new System.Drawing.Point(140, 144);
            this.btnGrabarDatos.Name = "btnGrabarDatos";
            this.btnGrabarDatos.Size = new System.Drawing.Size(109, 48);
            this.btnGrabarDatos.TabIndex = 3;
            this.btnGrabarDatos.Text = "Grabar datos";
            this.btnGrabarDatos.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 327);
            this.Controls.Add(this.btnGrabarDatos);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnLeerArchivo);
            this.Controls.Add(this.btnCrearArchivo);
            this.Name = "FrmPrincipal";
            this.Text = "Primer archivo";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnGrabarDatos;
    }
}

