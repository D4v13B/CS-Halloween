namespace Parcial2
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInicio.Location = new System.Drawing.Point(695, 504);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(227, 62);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "btn";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.btnInicio);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
    }
}

