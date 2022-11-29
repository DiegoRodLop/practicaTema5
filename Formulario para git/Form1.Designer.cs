namespace Formulario_para_git
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.COrdinario = new System.Windows.Forms.RadioButton();
            this.Curgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(75, 345);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(25, 29);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(365, 226);
            this.txtTelegrama.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto";
            // 
            // COrdinario
            // 
            this.COrdinario.AutoSize = true;
            this.COrdinario.Location = new System.Drawing.Point(28, 292);
            this.COrdinario.Name = "COrdinario";
            this.COrdinario.Size = new System.Drawing.Size(67, 17);
            this.COrdinario.TabIndex = 6;
            this.COrdinario.TabStop = true;
            this.COrdinario.Text = "Ordinario";
            this.COrdinario.UseVisualStyleBackColor = true;
            // 
            // Curgente
            // 
            this.Curgente.AutoSize = true;
            this.Curgente.Location = new System.Drawing.Point(112, 292);
            this.Curgente.Name = "Curgente";
            this.Curgente.Size = new System.Drawing.Size(63, 17);
            this.Curgente.TabIndex = 7;
            this.Curgente.TabStop = true;
            this.Curgente.Text = "Urgente";
            this.Curgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 381);
            this.Controls.Add(this.Curgente);
            this.Controls.Add(this.COrdinario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton COrdinario;
        private System.Windows.Forms.RadioButton Curgente;
    }
}

