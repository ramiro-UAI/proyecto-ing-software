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
    public partial class LogIn5283_MB : Form
    {
        BLLUsuario5283_MB user = new BLLUsuario5283_MB();

        public LogIn5283_MB()
        {
            InitializeComponent();
        }

        private void btnInciar_Click(object sender, EventArgs e)
        {
            try
            {
                user.LogIn(txtNombreUsuario.Text, txtContraseña.Text);   
                MenuPrincipal5283_MB frm = (MenuPrincipal5283_MB)this.MdiParent;
                frm.Validar();
                if (user.VerificarClaveBlanqueada())
                {
                    frm.ShowCambioClave();
                }
                this.Close();
            }catch(Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }

        //Faltaria verificar que es la primera vez que se loguea con blanqueo de clave
        //mandarlo al cambio de clave
    }
}
