namespace Parcial2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogRegresar = new System.Windows.Forms.Button();
            this.btnLogSig = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblCódigo = new System.Windows.Forms.Label();
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogRegresar
            // 
            this.btnLogRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnLogRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogRegresar.ForeColor = System.Drawing.Color.Olive;
            this.btnLogRegresar.Location = new System.Drawing.Point(174, 518);
            this.btnLogRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogRegresar.Name = "btnLogRegresar";
            this.btnLogRegresar.Size = new System.Drawing.Size(106, 41);
            this.btnLogRegresar.TabIndex = 0;
            this.btnLogRegresar.Text = "Regresar";
            this.btnLogRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogRegresar.UseVisualStyleBackColor = false;
            // 
            // btnLogSig
            // 
            this.btnLogSig.BackColor = System.Drawing.Color.Transparent;
            this.btnLogSig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogSig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogSig.ForeColor = System.Drawing.Color.Olive;
            this.btnLogSig.Location = new System.Drawing.Point(327, 518);
            this.btnLogSig.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogSig.Name = "btnLogSig";
            this.btnLogSig.Size = new System.Drawing.Size(106, 41);
            this.btnLogSig.TabIndex = 1;
            this.btnLogSig.Text = "Siguiente";
            this.btnLogSig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogSig.UseVisualStyleBackColor = false;
            this.btnLogSig.Click += new System.EventHandler(this.btnLogSig_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(204, 255);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(182, 19);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "nombre";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(204, 347);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(182, 19);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.Text = "contraseña";
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCódigo.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblCódigo.Location = new System.Drawing.Point(184, 390);
            this.lblCódigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(247, 31);
            this.lblCódigo.TabIndex = 7;
            this.lblCódigo.Text = "CÓDIGO DE INVITACIÓN";
            this.lblCódigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCódigo
            // 
            this.txtCódigo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCódigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCódigo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCódigo.Location = new System.Drawing.Point(204, 422);
            this.txtCódigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(182, 19);
            this.txtCódigo.TabIndex = 8;
            this.txtCódigo.Text = "código";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(243, 466);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(114, 13);
            this.lblLink.TabIndex = 9;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Registrarse en la fiesta";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 609);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtCódigo);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogSig);
            this.Controls.Add(this.btnLogRegresar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogRegresar;
        private System.Windows.Forms.Button btnLogSig;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}