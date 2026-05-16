namespace Proyecto_Montero_Botto
{
    partial class GestionDeUsuario
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
            this.dgvListUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnBloqueoUsuario = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListUsuarios
            // 
            this.dgvListUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvListUsuarios.Name = "dgvListUsuarios";
            this.dgvListUsuarios.Size = new System.Drawing.Size(844, 331);
            this.dgvListUsuarios.TabIndex = 0;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(862, 12);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(102, 34);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(862, 52);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(102, 34);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(862, 92);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(102, 36);
            this.btnEliminarUsuario.TabIndex = 1;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnBloqueoUsuario
            // 
            this.btnBloqueoUsuario.Location = new System.Drawing.Point(862, 134);
            this.btnBloqueoUsuario.Name = "btnBloqueoUsuario";
            this.btnBloqueoUsuario.Size = new System.Drawing.Size(102, 48);
            this.btnBloqueoUsuario.TabIndex = 1;
            this.btnBloqueoUsuario.Text = "Bloqueo / Desbloquear Usuario";
            this.btnBloqueoUsuario.UseVisualStyleBackColor = true;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(13, 350);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 376);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(13, 402);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 399);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 3;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(13, 428);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(33, 13);
            this.lblPerfil.TabIndex = 2;
            this.lblPerfil.Text = "Perfil:";
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Items.AddRange(new object[] {
            "Basico",
            "Administrador"});
            this.cbxPerfil.Location = new System.Drawing.Point(66, 425);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(121, 21);
            this.cbxPerfil.TabIndex = 4;
            // 
            // GestionDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 458);
            this.Controls.Add(this.cbxPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnBloqueoUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.dgvListUsuarios);
            this.Name = "GestionDeUsuario";
            this.Text = "GestionDeUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnBloqueoUsuario;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cbxPerfil;
    }
}