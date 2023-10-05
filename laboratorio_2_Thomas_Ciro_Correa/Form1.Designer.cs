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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pruebas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(380, 20);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(68, 16);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "RECTAS";
            // 
            // textBoxRecta2
            // 
            this.textBoxRecta2.Location = new System.Drawing.Point(153, 52);
            this.textBoxRecta2.Name = "textBoxRecta2";
            this.textBoxRecta2.Size = new System.Drawing.Size(120, 20);
            this.textBoxRecta2.TabIndex = 1;
            // 
            // labelRecta1
            // 
            this.labelRecta1.AutoSize = true;
            this.labelRecta1.Location = new System.Drawing.Point(53, 24);
            this.labelRecta1.Name = "labelRecta1";
            this.labelRecta1.Size = new System.Drawing.Size(45, 13);
            this.labelRecta1.TabIndex = 2;
            this.labelRecta1.Text = "Recta 1";
            // 
            // textBoxRecta1
            // 
            this.textBoxRecta1.Location = new System.Drawing.Point(10, 52);
            this.textBoxRecta1.Name = "textBoxRecta1";
            this.textBoxRecta1.Size = new System.Drawing.Size(120, 20);
            this.textBoxRecta1.TabIndex = 3;
            // 
            // labelRecta2
            // 
            this.labelRecta2.AutoSize = true;
            this.labelRecta2.Location = new System.Drawing.Point(186, 24);
            this.labelRecta2.Name = "labelRecta2";
            this.labelRecta2.Size = new System.Drawing.Size(45, 13);
            this.labelRecta2.TabIndex = 4;
            this.labelRecta2.Text = "Recta 2";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(37, 243);
            this.labelError.MaximumSize = new System.Drawing.Size(290, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(243, 136);
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
            this.groupBox1.Location = new System.Drawing.Point(34, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botonLimpiar.Location = new System.Drawing.Point(172, 93);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(76, 30);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = false;
            // 
            // botonCalcular
            // 
            this.botonCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botonCalcular.Location = new System.Drawing.Point(35, 93);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(73, 30);
            this.botonCalcular.TabIndex = 5;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(444, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 280);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pruebas
            // 
            this.pruebas.AutoSize = true;
            this.pruebas.Location = new System.Drawing.Point(532, 43);
            this.pruebas.Name = "pruebas";
            this.pruebas.Size = new System.Drawing.Size(35, 13);
            this.pruebas.TabIndex = 8;
            this.pruebas.Text = "label1";
            this.pruebas.Click += new System.EventHandler(this.pruebas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 403);
            this.Controls.Add(this.pruebas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pruebas;
    }
}

