namespace ProgramaPrueba
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Button();
            this.Cambio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a su programa de confianza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(264, 187);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(184, 59);
            this.Estado.TabIndex = 1;
            this.Estado.Text = "Estado habitaciones";
            this.Estado.UseVisualStyleBackColor = true;
            this.Estado.Click += new System.EventHandler(this.Estado_Click);
            // 
            // Cambio
            // 
            this.Cambio.Location = new System.Drawing.Point(23, 189);
            this.Cambio.Name = "Cambio";
            this.Cambio.Size = new System.Drawing.Size(177, 57);
            this.Cambio.TabIndex = 2;
            this.Cambio.Text = "Cambiar estado habitaciones";
            this.Cambio.UseVisualStyleBackColor = true;
            this.Cambio.Click += new System.EventHandler(this.Cambio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cambio);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Estado;
        private System.Windows.Forms.Button Cambio;
        private System.Windows.Forms.Button button1;
    }
}

