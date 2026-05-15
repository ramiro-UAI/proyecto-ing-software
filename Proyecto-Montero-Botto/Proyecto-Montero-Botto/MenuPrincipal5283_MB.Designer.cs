namespace Proyecto_Montero_Botto
{
    partial class MenuPrincipal5283_MB
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
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.mstUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mstInciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mstCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.mstCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mstGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.mstVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mstReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsNotificacion = new System.Windows.Forms.ToolStrip();
            this.txtUsuarioActivo = new System.Windows.Forms.ToolStripLabel();
            this.mstMenu.SuspendLayout();
            this.tlsNotificacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenu
            // 
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstUsuario,
            this.mstAdmin,
            this.mstMaster,
            this.mstAlquiler,
            this.mstVenta,
            this.mstReporte,
            this.mstAyuda});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(1239, 24);
            this.mstMenu.TabIndex = 0;
            this.mstMenu.Text = "menuStrip1";
            // 
            // mstUsuario
            // 
            this.mstUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstInciarSesion,
            this.mstCambiarContraseña,
            this.mstCerrarSesion});
            this.mstUsuario.Name = "mstUsuario";
            this.mstUsuario.Size = new System.Drawing.Size(59, 20);
            this.mstUsuario.Text = "Usuario";
            // 
            // mstInciarSesion
            // 
            this.mstInciarSesion.Name = "mstInciarSesion";
            this.mstInciarSesion.Size = new System.Drawing.Size(182, 22);
            this.mstInciarSesion.Text = "Iniciar Sesion";
            this.mstInciarSesion.Click += new System.EventHandler(this.mstInciarSesion_Click);
            // 
            // mstCambiarContraseña
            // 
            this.mstCambiarContraseña.Name = "mstCambiarContraseña";
            this.mstCambiarContraseña.Size = new System.Drawing.Size(182, 22);
            this.mstCambiarContraseña.Text = "Cambiar Contraseña";
            // 
            // mstCerrarSesion
            // 
            this.mstCerrarSesion.Name = "mstCerrarSesion";
            this.mstCerrarSesion.Size = new System.Drawing.Size(182, 22);
            this.mstCerrarSesion.Text = "Cerrar Sesion";
            this.mstCerrarSesion.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // mstAdmin
            // 
            this.mstAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstGestionUsuarios});
            this.mstAdmin.Enabled = false;
            this.mstAdmin.Name = "mstAdmin";
            this.mstAdmin.Size = new System.Drawing.Size(95, 20);
            this.mstAdmin.Text = "Administrador";
            // 
            // mstGestionUsuarios
            // 
            this.mstGestionUsuarios.Name = "mstGestionUsuarios";
            this.mstGestionUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mstGestionUsuarios.Text = "Gestion de Usuarios";
            // 
            // mstMaster
            // 
            this.mstMaster.Enabled = false;
            this.mstMaster.Name = "mstMaster";
            this.mstMaster.Size = new System.Drawing.Size(62, 20);
            this.mstMaster.Text = "Maestro";
            // 
            // mstAlquiler
            // 
            this.mstAlquiler.Enabled = false;
            this.mstAlquiler.Name = "mstAlquiler";
            this.mstAlquiler.Size = new System.Drawing.Size(60, 20);
            this.mstAlquiler.Text = "Alquiler";
            // 
            // mstVenta
            // 
            this.mstVenta.Enabled = false;
            this.mstVenta.Name = "mstVenta";
            this.mstVenta.Size = new System.Drawing.Size(48, 20);
            this.mstVenta.Text = "Venta";
            // 
            // mstReporte
            // 
            this.mstReporte.Enabled = false;
            this.mstReporte.Name = "mstReporte";
            this.mstReporte.Size = new System.Drawing.Size(60, 20);
            this.mstReporte.Text = "Reporte";
            // 
            // mstAyuda
            // 
            this.mstAyuda.Enabled = false;
            this.mstAyuda.Name = "mstAyuda";
            this.mstAyuda.Size = new System.Drawing.Size(53, 20);
            this.mstAyuda.Text = "Ayuda";
            // 
            // tlsNotificacion
            // 
            this.tlsNotificacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsNotificacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtUsuarioActivo});
            this.tlsNotificacion.Location = new System.Drawing.Point(0, 553);
            this.tlsNotificacion.Name = "tlsNotificacion";
            this.tlsNotificacion.Size = new System.Drawing.Size(1239, 25);
            this.tlsNotificacion.TabIndex = 1;
            this.tlsNotificacion.Text = "toolStrip1";
            // 
            // txtUsuarioActivo
            // 
            this.txtUsuarioActivo.Name = "txtUsuarioActivo";
            this.txtUsuarioActivo.Size = new System.Drawing.Size(86, 22);
            this.txtUsuarioActivo.Text = "toolStripLabel1";
            // 
            // MenuPrincipal5283_MB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 578);
            this.Controls.Add(this.tlsNotificacion);
            this.Controls.Add(this.mstMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstMenu;
            this.Name = "MenuPrincipal5283_MB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal5283_MB_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.tlsNotificacion.ResumeLayout(false);
            this.tlsNotificacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem mstUsuario;
        private System.Windows.Forms.ToolStripMenuItem mstInciarSesion;
        private System.Windows.Forms.ToolStripMenuItem mstCambiarContraseña;
        private System.Windows.Forms.ToolStripMenuItem mstCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem mstAdmin;
        private System.Windows.Forms.ToolStripMenuItem mstGestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mstMaster;
        private System.Windows.Forms.ToolStripMenuItem mstAlquiler;
        private System.Windows.Forms.ToolStripMenuItem mstVenta;
        private System.Windows.Forms.ToolStripMenuItem mstReporte;
        private System.Windows.Forms.ToolStripMenuItem mstAyuda;
        private System.Windows.Forms.ToolStrip tlsNotificacion;
        private System.Windows.Forms.ToolStripLabel txtUsuarioActivo;
    }
}

