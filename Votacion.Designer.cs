namespace Parcial2
{
    partial class Votacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Votacion));
            this.pbDisfraz = new System.Windows.Forms.PictureBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtPuntuacion = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPuntos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisfraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDisfraz
            // 
            this.pbDisfraz.BackColor = System.Drawing.Color.Transparent;
            this.pbDisfraz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDisfraz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDisfraz.Location = new System.Drawing.Point(284, 176);
            this.pbDisfraz.Margin = new System.Windows.Forms.Padding(2);
            this.pbDisfraz.Name = "pbDisfraz";
            this.pbDisfraz.Size = new System.Drawing.Size(186, 232);
            this.pbDisfraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisfraz.TabIndex = 0;
            this.pbDisfraz.TabStop = false;
            this.pbDisfraz.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.Transparent;
            this.btnVotar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotar.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnVotar.Location = new System.Drawing.Point(330, 429);
            this.btnVotar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(94, 34);
            this.btnVotar.TabIndex = 1;
            this.btnVotar.Text = "i";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnRegresar.Location = new System.Drawing.Point(266, 535);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(94, 34);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "i";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnSiguiente.Location = new System.Drawing.Point(400, 535);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(94, 34);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "i";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntuacion.Location = new System.Drawing.Point(506, 296);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(136, 30);
            this.txtPuntuacion.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("PT Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(506, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "PUNTUACION";
            // 
            // lblPuntos
            // 
            this.lblPuntos.Font = new System.Drawing.Font("PT Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(12, 176);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(259, 29);
            this.lblPuntos.TabIndex = 6;
            this.lblPuntos.Text = "PUNTUACION";
            // 
            // Votacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.pbDisfraz);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Votacion";
            this.Text = "Votacion";
            ((System.ComponentModel.ISupportInitialize)(this.pbDisfraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuntuacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDisfraz;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.NumericUpDown txtPuntuacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox lblPuntos;
    }
}