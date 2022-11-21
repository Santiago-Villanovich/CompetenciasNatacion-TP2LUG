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

namespace UI
{
    public partial class formIngresoUsuario : Form
    {
        public formIngresoUsuario()
        {
            InitializeComponent();
            beUsuario = new BEusuario();
            bllUsuario = new BLLusuario();
            txtPassword.UseSystemPasswordChar = true;
            PWvisible = true;
        }

        bool PWvisible;
        public static BEusuario beUsuario;
        BLLusuario bllUsuario;

        private void button1_Click(object sender, EventArgs e)
        {
            beUsuario.nombreUsuario = txtNombre.Text;
            beUsuario.password =Seguridad.GenerarMD5(txtPassword.Text);

            if (bllUsuario.Verificar(beUsuario))
            {

                Form1 frm = new Form1();
                txtNombre.Clear();
                txtPassword.Clear();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("El Nombre de usuario/Contraseña\nno se han encontrado.\nA completado correctamente ambos campos?", "Failed log", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (PWvisible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                PWvisible = false;
            }
            else if (PWvisible == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                PWvisible = true;
            }
        }

        
    }
}
