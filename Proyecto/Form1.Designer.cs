namespace Proyecto
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtFibonacci = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblfibonacci = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de Valores Deseados";
            // 
            // txtFibonacci
            // 
            this.txtFibonacci.Location = new System.Drawing.Point(95, 107);
            this.txtFibonacci.Name = "txtFibonacci";
            this.txtFibonacci.Size = new System.Drawing.Size(100, 20);
            this.txtFibonacci.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Inicio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblfibonacci
            // 
            this.lblfibonacci.AutoSize = true;
            this.lblfibonacci.Location = new System.Drawing.Point(92, 151);
            this.lblfibonacci.Name = "lblfibonacci";
            this.lblfibonacci.Size = new System.Drawing.Size(53, 13);
            this.lblfibonacci.TabIndex = 6;
            this.lblfibonacci.Text = "respuesta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "primos o no primos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(535, 389);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblfibonacci);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtFibonacci);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFibonacci;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblfibonacci;
        private System.Windows.Forms.Button button3;
    }
}

