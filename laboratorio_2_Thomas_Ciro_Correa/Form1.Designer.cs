namespace laboratorio_2_Thomas_Ciro_Correa
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxRecta2 = new System.Windows.Forms.TextBox();
            this.labelRecta1 = new System.Windows.Forms.Label();
            this.textBoxRecta1 = new System.Windows.Forms.TextBox();
            this.labelRecta2 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(507, 25);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(82, 20);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "RECTAS";
            // 
            // textBoxRecta2
            // 
            this.textBoxRecta2.Location = new System.Drawing.Point(204, 64);
            this.textBoxRecta2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecta2.Name = "textBoxRecta2";
            this.textBoxRecta2.Size = new System.Drawing.Size(159, 22);
            this.textBoxRecta2.TabIndex = 1;
            // 
            // labelRecta1
            // 
            this.labelRecta1.AutoSize = true;
            this.labelRecta1.Location = new System.Drawing.Point(71, 30);
            this.labelRecta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecta1.Name = "labelRecta1";
            this.labelRecta1.Size = new System.Drawing.Size(53, 16);
            this.labelRecta1.TabIndex = 2;
            this.labelRecta1.Text = "Recta 1";
            // 
            // textBoxRecta1
            // 
            this.textBoxRecta1.Location = new System.Drawing.Point(13, 64);
            this.textBoxRecta1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecta1.Name = "textBoxRecta1";
            this.textBoxRecta1.Size = new System.Drawing.Size(159, 22);
            this.textBoxRecta1.TabIndex = 3;
            // 
            // labelRecta2
            // 
            this.labelRecta2.AutoSize = true;
            this.labelRecta2.Location = new System.Drawing.Point(248, 30);
            this.labelRecta2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecta2.Name = "labelRecta2";
            this.labelRecta2.Size = new System.Drawing.Size(53, 16);
            this.labelRecta2.TabIndex = 4;
            this.labelRecta2.Text = "Recta 2";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(566, 110);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.MaximumSize = new System.Drawing.Size(387, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(311, 176);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "INGRESE DOS RECTAS DE LA FORMA \r\n\r\n              y – y1 = m (x – x1)   Ó\r\n       " +
    "            y = mx + b \r\n\r\nPARA CALCULAR SU INTERSECCIÓN,\r\nSI ES NECESARIO REEMP" +
    "LACE LOS \r\n\"-\" POR \"+\" Y VICEVERSA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.botonLimpiar);
            this.groupBox1.Controls.Add(this.botonCalcular);
            this.groupBox1.Controls.Add(this.textBoxRecta1);
            this.groupBox1.Controls.Add(this.labelRecta2);
            this.groupBox1.Controls.Add(this.labelRecta1);
            this.groupBox1.Controls.Add(this.textBoxRecta2);
            this.groupBox1.Location = new System.Drawing.Point(45, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(391, 185);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botonLimpiar.Location = new System.Drawing.Point(229, 114);
            this.botonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(101, 37);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = false;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonCalcular
            // 
            this.botonCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botonCalcular.Location = new System.Drawing.Point(47, 114);
            this.botonCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(97, 37);
            this.botonCalcular.TabIndex = 5;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = false;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxRecta2;
        private System.Windows.Forms.Label labelRecta1;
        private System.Windows.Forms.TextBox textBoxRecta1;
        private System.Windows.Forms.Label labelRecta2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonCalcular;
    }
}

