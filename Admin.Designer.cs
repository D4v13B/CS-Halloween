namespace Parcial2
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pcbGestDisfraz = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtGestCod = new System.Windows.Forms.TextBox();
            this.txtGestContraseña = new System.Windows.Forms.TextBox();
            this.txtCodBuscar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSigGest = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGestDisfraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbGestDisfraz
            // 
            this.pcbGestDisfraz.BackColor = System.Drawing.Color.Black;
            this.pcbGestDisfraz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbGestDisfraz.Location = new System.Drawing.Point(448, 300);
            this.pcbGestDisfraz.Margin = new System.Windows.Forms.Padding(2);
            this.pcbGestDisfraz.Name = "pcbGestDisfraz";
            this.pcbGestDisfraz.Size = new System.Drawing.Size(225, 247);
            this.pcbGestDisfraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGestDisfraz.TabIndex = 0;
            this.pcbGestDisfraz.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(20, 379);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(320, 133);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(26, 173);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 13);
            this.txtNombre.TabIndex = 2;
            // 
            // txtGestCod
            // 
            this.txtGestCod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtGestCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGestCod.ForeColor = System.Drawing.Color.White;
            this.txtGestCod.Location = new System.Drawing.Point(176, 173);
            this.txtGestCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtGestCod.Name = "txtGestCod";
            this.txtGestCod.Size = new System.Drawing.Size(124, 13);
            this.txtGestCod.TabIndex = 3;
            // 
            // txtGestContraseña
            // 
            this.txtGestContraseña.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtGestContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGestContraseña.ForeColor = System.Drawing.Color.White;
            this.txtGestContraseña.Location = new System.Drawing.Point(26, 215);
            this.txtGestContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtGestContraseña.Name = "txtGestContraseña";
            this.txtGestContraseña.Size = new System.Drawing.Size(124, 13);
            this.txtGestContraseña.TabIndex = 5;
            // 
            // txtCodBuscar
            // 
            this.txtCodBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCodBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodBuscar.ForeColor = System.Drawing.Color.White;
            this.txtCodBuscar.Location = new System.Drawing.Point(26, 328);
            this.txtCodBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodBuscar.Name = "txtCodBuscar";
            this.txtCodBuscar.Size = new System.Drawing.Size(124, 13);
            this.txtCodBuscar.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.Location = new System.Drawing.Point(131, 245);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 32);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(244, 353);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 22);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "i";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnRegresar.Location = new System.Drawing.Point(70, 538);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(98, 38);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSigGest
            // 
            this.btnSigGest.BackColor = System.Drawing.Color.Transparent;
            this.btnSigGest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSigGest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigGest.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSigGest.Location = new System.Drawing.Point(194, 538);
            this.btnSigGest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSigGest.Name = "btnSigGest";
            this.btnSigGest.Size = new System.Drawing.Size(98, 38);
            this.btnSigGest.TabIndex = 11;
            this.btnSigGest.Text = "siguiente";
            this.btnSigGest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSigGest.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(146, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "i";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(55, 353);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 22);
            this.button2.TabIndex = 13;
            this.button2.Text = "i";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 24);
            this.button3.TabIndex = 14;
            this.button3.Text = "Cargar Disfraz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSigGest);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCodBuscar);
            this.Controls.Add(this.txtGestContraseña);
            this.Controls.Add(this.txtGestCod);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pcbGestDisfraz);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pcbGestDisfraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbGestDisfraz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtGestCod;
        private System.Windows.Forms.TextBox txtGestContraseña;
        private System.Windows.Forms.TextBox txtCodBuscar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSigGest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}