namespace Parcial2
{
    partial class QuitarDulces
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLlevarDulces = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDulcesDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(233, 37);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE CASA";
            // 
            // btnLlevarDulces
            // 
            this.btnLlevarDulces.Location = new System.Drawing.Point(19, 134);
            this.btnLlevarDulces.Name = "btnLlevarDulces";
            this.btnLlevarDulces.Size = new System.Drawing.Size(241, 30);
            this.btnLlevarDulces.TabIndex = 1;
            this.btnLlevarDulces.Text = "LLEVATE LOS DULCES";
            this.btnLlevarDulces.UseVisualStyleBackColor = true;
            this.btnLlevarDulces.Click += new System.EventHandler(this.btnLlevarDulces_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(21, 92);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(238, 20);
            this.txtQuantity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de dulces que quieres llevarte?";
            // 
            // lblDulcesDisponibles
            // 
            this.lblDulcesDisponibles.AutoSize = true;
            this.lblDulcesDisponibles.Location = new System.Drawing.Point(26, 46);
            this.lblDulcesDisponibles.Name = "lblDulcesDisponibles";
            this.lblDulcesDisponibles.Size = new System.Drawing.Size(199, 13);
            this.lblDulcesDisponibles.TabIndex = 4;
            this.lblDulcesDisponibles.Text = "Cantidad de dulces que quieres llevarte?";
            // 
            // QuitarDulces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 178);
            this.Controls.Add(this.lblDulcesDisponibles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnLlevarDulces);
            this.Controls.Add(this.lblNombre);
            this.Name = "QuitarDulces";
            this.Text = "QuitarDulces";
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLlevarDulces;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDulcesDisponibles;
    }
}