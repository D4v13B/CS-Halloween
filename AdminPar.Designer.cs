namespace Parcial2
{
    partial class AdminPar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPar));
            this.txtNombreCasa = new System.Windows.Forms.TextBox();
            this.txtTipoDulces = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegistrarCasa = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCasa
            // 
            this.txtNombreCasa.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtNombreCasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCasa.Location = new System.Drawing.Point(606, 145);
            this.txtNombreCasa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCasa.Name = "txtNombreCasa";
            this.txtNombreCasa.Size = new System.Drawing.Size(122, 13);
            this.txtNombreCasa.TabIndex = 0;
            // 
            // txtTipoDulces
            // 
            this.txtTipoDulces.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtTipoDulces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoDulces.Location = new System.Drawing.Point(606, 178);
            this.txtTipoDulces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTipoDulces.Name = "txtTipoDulces";
            this.txtTipoDulces.Size = new System.Drawing.Size(122, 13);
            this.txtTipoDulces.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(606, 335);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 13);
            this.textBox4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 394);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(365, 122);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnRegistrarCasa
            // 
            this.btnRegistrarCasa.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCasa.ForeColor = System.Drawing.Color.Gray;
            this.btnRegistrarCasa.Location = new System.Drawing.Point(519, 242);
            this.btnRegistrarCasa.Name = "btnRegistrarCasa";
            this.btnRegistrarCasa.Size = new System.Drawing.Size(111, 29);
            this.btnRegistrarCasa.TabIndex = 5;
            this.btnRegistrarCasa.Text = "REGISTRAR";
            this.btnRegistrarCasa.UseVisualStyleBackColor = false;
            this.btnRegistrarCasa.Click += new System.EventHandler(this.btnRegistrarCasa_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(607, 210);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtQuantity.TabIndex = 6;
            // 
            // AdminPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnRegistrarCasa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtTipoDulces);
            this.Controls.Add(this.txtNombreCasa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminPar";
            this.Text = "AdminPar";
            this.Load += new System.EventHandler(this.AdminPar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCasa;
        private System.Windows.Forms.TextBox txtTipoDulces;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegistrarCasa;
        private System.Windows.Forms.NumericUpDown txtQuantity;
    }
}