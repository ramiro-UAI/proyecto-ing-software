using SRV_5283_MB;
using SRV5283_MB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Montero_Botto
{
    public partial class MenuPrincipal5283_MB : Form
    {
        public MenuPrincipal5283_MB()
        {
            InitializeComponent();
        }
        private void MenuPrincipal5283_MB_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void mstInciarSesion_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        public void ShowLogin()
        {
            LogIn5283_MB frm = new LogIn5283_MB();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var con = MessageBox.Show("¿Esta seguro que desea Cerrar Sesión?", "Cerrar Sesion", MessageBoxButtons.YesNo);
            if(con == DialogResult.Yes)
            {
                SessionManager5283_MB.Instance.LogOut();
            }
        }

        public void Validar()
        {
            if (SessionManager5283_MB.Instance.IsLoggedIn())
            {
                txtUsuarioActivo.Text = SessionManager5283_MB.Instance.usuario.NombreUsuario;

                switch (SessionManager5283_MB.Instance.usuario.Perfil)
                {
                    case "Administrador":
                        
                        break;
                }
            }
        }

        public void ShowCambioClave()
        {
            CambiarClave5283_MB frm = new CambiarClave5283_MB();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
