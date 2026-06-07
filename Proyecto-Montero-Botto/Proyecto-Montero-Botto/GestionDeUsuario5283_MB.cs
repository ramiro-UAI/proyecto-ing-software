using SRV_5283_MB;
using SRV5283_MB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Montero_Botto
{
    public partial class GestionDeUsuario5283_MB : Form
    {
        public BLLUsuario5283_MB BLLuser = new BLLUsuario5283_MB();
        public Usuario5283_MB User = new Usuario5283_MB();
        public Usuario5283_MB UserMod = new Usuario5283_MB();

        public GestionDeUsuario5283_MB()
        {
            InitializeComponent();
        }

        public void createUser()
        {
            User.DNI = int.Parse(txtDni.Text);
            User.Nombre = txtNombre.Text;
            User.Apellido = txtApellido.Text;
            User.Perfil = cbxPerfil.Text;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                createUser();
                BLLuser.AgregarUsuario(User);
                MessageBox.Show("Usuario Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            ActualizarLista();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                createUser();
                //BLLuser.AgregarUsuario(User); Falta Modificar Usuario
                MessageBox.Show("Usuario Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            ActualizarLista();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if(UserMod != null)
            {
                var con = MessageBox.Show("Confirmar Eliminar Usuario", "", MessageBoxButtons.YesNo);
                if(con == DialogResult.Yes)
                {
                    BLLuser.EliminarUsuario(UserMod);
                }
                ActualizarLista();
            }
        }

        public void ActualizarLista()
        {
            dgvListUsuarios.DataSource = null;
            dgvListUsuarios.DataSource = BLLuser.GetUsuarios();
        }

        private void btnBloqueoUsuario_Click(object sender, EventArgs e)
        {
            if(UserMod.Bloqueo == 0)
            {
                var con = MessageBox.Show("Confirmar Bloqueo de Usuario", "", MessageBoxButtons.YesNo);
                if(con == DialogResult.Yes)
                {
                    BLLuser.BloqueoDesbloqueoUsuario(UserMod);
                }
            }
            else
            {
                var con = MessageBox.Show("Confirmar Desloqueo de Usuario", "", MessageBoxButtons.YesNo);
                if (con == DialogResult.Yes)
                {
                    BLLuser.BloqueoDesbloqueoUsuario(UserMod);
                }
            }

            ActualizarLista();
        }
    }
}
