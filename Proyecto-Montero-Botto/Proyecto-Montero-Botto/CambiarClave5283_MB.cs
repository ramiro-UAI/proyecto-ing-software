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
    public partial class CambiarClave5283_MB : Form
    {
        BLLUsuario5283_MB BLL = new BLLUsuario5283_MB();

        public CambiarClave5283_MB()
        {
            InitializeComponent();
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtContraseñaNueva.Text) || string.IsNullOrWhiteSpace(txtContraseñaRepetida.Text)) throw new Exception("Campos vacios en la contraseña nueva o la repetida");
                if (txtContraseñaActual.Text == txtContraseñaNueva.Text) throw new Exception("La contraseña Nueva no puede ser igual que la Actual");
                if (txtContraseñaNueva.Text != txtContraseñaRepetida.Text) throw new Exception("Las contraseñas no coinciden");
                BLL.CambiarClave(txtContraseñaActual.Text, txtContraseñaNueva.Text, txtContraseñaRepetida.Text);
                MessageBox.Show("Contraseña Modificada", "", MessageBoxButtons.OK);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
