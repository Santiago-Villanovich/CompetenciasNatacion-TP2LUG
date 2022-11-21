using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BE;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class formParticipantes : Form
    {
        public Boolean VerificarTelefono(string tel)
        {
            Regex re = new Regex(@"^([1]{1})([1-5]{1})([0-9]{8})$");

            if (re.IsMatch(tel.Trim()))
            {
                
                return true;
            }
            else
            {
                telError = true;
                return false;
            }

        }

        public void Limpiar()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDNI1.LimpiarTxt();
            txtEdad.Text = null;
            txtTelefono.Text = null;
            rbIngresarEnEquipo.Checked = false;
            rbIngresarIndividual.Checked = false;
            oBENadador.ID = 0;

        }

        public void OcultarSelectorEquipo(bool booleano)
        {
            if (booleano == true )
            {
                label8.Visible = false;
                cboxEquipos.Visible = false;
                cboxEquipos.Enabled = false;

                label9.Visible = true;
                cboxCompetencias.Visible = true;
                cboxCompetencias.Enabled = true;
            }
            else
            {
                label8.Visible = true;
                cboxEquipos.Visible = true;
                cboxEquipos.Enabled = true;

                label9.Visible = false;
                cboxCompetencias.Visible = false;
                cboxCompetencias.Enabled = false;
            }
        }
        public void CargarDGrid(string categoria)
        {
            try
            {
                dgridNadadores.DataSource = null;
                dgridNadadores.DataSource = oBLLNadador.ListarXcategoria(categoria);
                if (dgridNadadores.DataSource != null)
                {
                    this.dgridNadadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    this.dgridNadadores.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    this.dgridNadadores.Columns["categoria"].Visible = false;
                    this.dgridNadadores.Columns["tiempo"].Visible = false;
                }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public void CargarCombo()
        {
            try
            {
                cboxEquipos.DataSource = null;
                cboxEquipos.DataSource = oBLLequipo.ListarObjs();
                cboxEquipos.DisplayMember = "Nombre";
                cboxEquipos.ValueMember = "ID";

                cboxCompetencias.DataSource = null;
                cboxCompetencias.DataSource = oBLLCompeAA.ListarObjs();
                cboxCompetencias.DisplayMember = "Nombre";
                cboxCompetencias.ValueMember = "ID";
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }

        }

        public formParticipantes()
        {
            InitializeComponent();

            oBENadador = new BEnadador();
            oBLLNadador = new BLLnadador();
            oBEEquipo = new BEequipo();
            oBLLequipo = new BLLequipo();

            oBECompeAA = new BEaguasAbiertas();
            oBLLCompeAA = new BLLaguasAbiertas();

            label8.Visible = false;
            cboxEquipos.Visible = false;
            cboxEquipos.Enabled = false;

            label9.Visible = false;
            cboxCompetencias.Visible = false;
            cboxCompetencias.Enabled = false;

            telError = false;
        }

        private void formParticipantes_Load(object sender, EventArgs e)
        {
            CargarCombo();
            cboxEquipos.SelectedItem = null;
            cboxCompetencias.SelectedItem = null;
        }

        BEnadador oBENadador;
        BLLnadador oBLLNadador;
        BEequipo oBEEquipo;
        BLLequipo oBLLequipo;
        BEaguasAbiertas oBECompeAA;
        BLLaguasAbiertas oBLLCompeAA;
        bool telError;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (Convert.ToInt32(txtEdad.Text) > 9)
                {
                    if (txtDNI1.VerificarDNI() && VerificarTelefono(txtTelefono.Text))
                    {
                        oBENadador.nombre = txtNombre.Text;
                        oBENadador.apellido = txtApellido.Text;
                        oBENadador.dni = txtDNI1.retornarDNI();
                        oBENadador.edad =Convert.ToInt32( txtEdad.Text);
                        oBENadador.telefono = Convert.ToInt32(txtTelefono.Text);
                        oBENadador.asignarCategoria(oBENadador.edad);

                        if (rbIngresarEnEquipo.Checked == true)
                        {
                            if (cboxEquipos.SelectedItem != null)
                            {
                                oBEEquipo = (BEequipo)cboxEquipos.SelectedItem;

                                oBLLNadador.GuardarEquip(oBENadador,oBEEquipo.ID);
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Para ingresar al Nadador debe \nseleccionar el equipo correspondiente.", "Error seleccion equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            
                        }
                        else if (rbIngresarIndividual.Checked == true)
                        {
                            if (cboxCompetencias.SelectedItem != null)
                            {
                                oBECompeAA = (BEaguasAbiertas)cboxCompetencias.SelectedItem;

                                oBLLNadador.GuardarComp(oBENadador, oBECompeAA.ID);
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("Para ingresar al Nadador debe \nseleccionar el equipo correspondiente.", "Error seleccion equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        if (telError == true)
                        {
                            MessageBox.Show("El telefono ingresado es incorrecto.\nDebe respetar el formato: 1100000000 o 1500000000");
                            telError = false;
                        }
                        else
                        {
                            MessageBox.Show("El dni ingresado es incorrecto.\nDebe respetar el formato: 11.111.111", "Error dni", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
   
                }
                else
                {
                    MessageBox.Show("La edad del participante debe ser mayor a 9");
                } 
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex;}
        }

        private void dgridNadadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            oBENadador = (BEnadador)dgridNadadores.CurrentRow.DataBoundItem;
            txtNombre.Text = oBENadador.nombre;
            txtApellido.Text = oBENadador.apellido;
            txtEdad.Text = oBENadador.edad.ToString();
            txtDNI1.Escribir(oBENadador.dni);
            txtTelefono.Text = Convert.ToString(oBENadador.telefono);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (oBENadador.ID != 0)
            {
                oBLLNadador.Eliminar(oBENadador);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nadador");
            }
            
        }

        #region(RadioButtons)
        private void rbInfantil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInfantil.Checked == true)
            {
                CargarDGrid(EnumCategoria.Infantiles.ToString());
            }
        }

        private void rbMenores_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMenores.Checked == true)
            {
                CargarDGrid(EnumCategoria.Menores.ToString());
            }
        }

        private void rbCadetes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCadetes.Checked == true)
            {
                CargarDGrid(EnumCategoria.Cadetes.ToString());
            }
        }

        private void rbJuveniles_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJuveniles.Checked == true)
            {
                CargarDGrid(EnumCategoria.Juveniles.ToString());
            }
        }

        private void rbMayores_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMayores.Checked == true)
            {
                CargarDGrid(EnumCategoria.Mayores.ToString());
            }
        }

        private void rbIngresarIndividual_CheckedChanged(object sender, EventArgs e)
        {
            OcultarSelectorEquipo(true);
        }

        private void rbIngresarEnEquipo_CheckedChanged(object sender, EventArgs e)
        {
            OcultarSelectorEquipo(false);
        }


        #endregion


    }
}
