using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using System.Data.SqlClient;

namespace UI
{
    public partial class formAdministradores : Form
    {
        public void Limpiar()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDNI1.LimpiarTxt();
            txtNombreUsuario.Text = null;
            txtTelefono.Text = null;
            txtPassword.Text = null;
        }

        public formAdministradores()
        {
            InitializeComponent();
            beUsuario = new BEusuario();
            bllUsuario = new BLLusuario();
            beAdmin = new BEadminstrador();
            bllAdmin = new BLLadministrador();
            txtPassword.UseSystemPasswordChar = true;
            PWvisible = true;
            
        }

        bool PWvisible;

        BEadminstrador beAdmin;
        BLLadministrador bllAdmin;
        BEusuario beUsuario;
        BLLusuario bllUsuario;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDNI1.VerificarDNI())
            {
                beAdmin.nombre = txtNombre.Text;
                beAdmin.apellido = txtApellido.Text;
                beAdmin.dni = txtDNI1.retornarDNI();
                beAdmin.telefono =Convert.ToInt32(txtTelefono.Text);
                beAdmin.password = Seguridad.GenerarMD5(txtPassword.Text);

                beUsuario.nombreUsuario = txtNombreUsuario.Text;
                beUsuario.password = Seguridad.GenerarMD5(txtPassword.Text);

                if (bllUsuario.VerificarNombre(beUsuario) == false)
                {
                    bllAdmin.Guardar(beAdmin);
                    bllUsuario.Guardar(beUsuario);
                    Limpiar();

                    MessageBox.Show("Administrador registrado con exito");
                }
                else
                {
                    MessageBox.Show("El Nombre de usuario ingresado ya se encuentra registrado.\nIntente nuevamente.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El dni ingresado es incorrecto.\nDebe respetar el formato: 11.111.111", "Error dni", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PWvisible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                PWvisible = false;
            }
            else if(PWvisible == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                PWvisible = true;
            }
        }
    }
}
