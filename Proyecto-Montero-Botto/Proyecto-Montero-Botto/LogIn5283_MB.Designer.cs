namespace Proyecto_Montero_Botto
{
    partial class LogIn5283_MB
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
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnInciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(101, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de Usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(120, 10);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(170, 20);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(13, 39);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(64, 13);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(120, 36);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(170, 20);
            this.txtContraseña.TabIndex = 1;
            // 
            // btnInciar
            // 
            this.btnInciar.Location = new System.Drawing.Point(120, 62);
            this.btnInciar.Name = "btnInciar";
            this.btnInciar.Size = new System.Drawing.Size(60, 37);
            this.btnInciar.TabIndex = 2;
            this.btnInciar.Text = "Iniciar Sesion";
            this.btnInciar.UseVisualStyleBackColor = true;
            this.btnInciar.Click += new System.EventHandler(this.btnInciar_Click);
            // 
            // LogIn5283_MB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 104);
            this.Controls.Add(this.btnInciar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombre);
            this.Name = "LogIn5283_MB";
            this.Text = "LogIn5283_MB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnInciar;
    }
}