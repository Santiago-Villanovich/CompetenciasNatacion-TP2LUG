using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using BE;

namespace UI
{
    public partial class formEntrenador : Form
    {
        public void LimpiarCampos()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDNI1.LimpiarTxt();
            txtTelefono.Text = null;
            txtClub.Text = null;

            obeEntrenador.nombre = "";
            obeEntrenador.apellido = "";
            obeEntrenador.dni = "";
            obeEntrenador.ID = 0;
            obeEntrenador.telefono = 0;
            obeEntrenador.club = "";
        }

        public void CargarDgrid()
        {
            try
            {
                dgridEntrenador.DataSource = null;
                dgridEntrenador.DataSource = obllEntrenador.ListarObjs();
                this.dgridEntrenador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                this.dgridEntrenador.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }

        }
        public formEntrenador()
        {
            InitializeComponent();

            obllEntrenador = new BLLentrenador();
            obeEntrenador = new BEentrenador();
            
        }

        BLLentrenador obllEntrenador;
        BEentrenador obeEntrenador;
        private void formEntrenador_Load(object sender, EventArgs e)
        {
            CargarDgrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDNI1.VerificarDNI())
                {
                    obeEntrenador.nombre = txtNombre.Text;
                    obeEntrenador.apellido = txtApellido.Text;
                    obeEntrenador.telefono = Convert.ToInt32(txtTelefono.Text);
                    obeEntrenador.club = txtClub.Text;
                    obeEntrenador.dni = txtDNI1.retornarDNI();

                    obllEntrenador.Guardar(obeEntrenador);
                    CargarDgrid();
                }
                else
                {
                    MessageBox.Show("El dni ingresado es incorrecto.\nDebe respetar el formato: 11.111.111", "Error dni", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (obeEntrenador.ID != 0)
                {
                    obllEntrenador.Eliminar(obeEntrenador);
                    CargarDgrid();
                }
                
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        private void dgridEntrenador_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                obeEntrenador = (BEentrenador)dgridEntrenador.CurrentRow.DataBoundItem;

                txtNombre.Text = obeEntrenador.nombre;
                txtApellido.Text = obeEntrenador.apellido;
                txtDNI1.Escribir(obeEntrenador.dni);
                txtTelefono.Text = obeEntrenador.telefono.ToString();
                txtClub.Text = obeEntrenador.club;

            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
