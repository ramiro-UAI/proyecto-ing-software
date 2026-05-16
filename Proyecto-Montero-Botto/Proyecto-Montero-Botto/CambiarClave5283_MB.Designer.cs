namespace Proyecto_Montero_Botto
{
    partial class CambiarClave5283_MB
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
            this.lblActual = new System.Windows.Forms.Label();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.lblNueva = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.lblRepetida = new System.Windows.Forms.Label();
            this.txtContraseñaRepetida = new System.Windows.Forms.TextBox();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(12, 9);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(97, 13);
            this.lblActual.TabIndex = 0;
            this.lblActual.Text = "Contraseña Actual:";
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(117, 6);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(167, 20);
            this.txtContraseñaActual.TabIndex = 1;
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Location = new System.Drawing.Point(12, 35);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(99, 13);
            this.lblNueva.TabIndex = 0;
            this.lblNueva.Text = "Contraseña Nueva:";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Location = new System.Drawing.Point(117, 32);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(167, 20);
            this.txtContraseñaNueva.TabIndex = 1;
            // 
            // lblRepetida
            // 
            this.lblRepetida.AutoSize = true;
            this.lblRepetida.Location = new System.Drawing.Point(12, 61);
            this.lblRepetida.Name = "lblRepetida";
            this.lblRepetida.Size = new System.Drawing.Size(101, 13);
            this.lblRepetida.TabIndex = 0;
            this.lblRepetida.Text = "Repetir Contraseña:";
            // 
            // txtContraseñaRepetida
            // 
            this.txtContraseñaRepetida.Location = new System.Drawing.Point(117, 58);
            this.txtContraseñaRepetida.Name = "txtContraseñaRepetida";
            this.txtContraseñaRepetida.Size = new System.Drawing.Size(167, 20);
            this.txtContraseñaRepetida.TabIndex = 1;
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.Location = new System.Drawing.Point(209, 84);
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Size = new System.Drawing.Size(75, 36);
            this.btnCambiarClave.TabIndex = 2;
            this.btnCambiarClave.Text = "Cambiar Contraseña";
            this.btnCambiarClave.UseVisualStyleBackColor = true;
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // CambiarClave5283_MB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 131);
            this.Controls.Add(this.btnCambiarClave);
            this.Controls.Add(this.txtContraseñaRepetida);
            this.Controls.Add(this.lblRepetida);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.lblNueva);
            this.Controls.Add(this.txtContraseñaActual);
            this.Controls.Add(this.lblActual);
            this.Name = "CambiarClave5283_MB";
            this.Text = "CambiarClave5283_MB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.Label lblRepetida;
        private System.Windows.Forms.TextBox txtContraseñaRepetida;
        private System.Windows.Forms.Button btnCambiarClave;
    }
}