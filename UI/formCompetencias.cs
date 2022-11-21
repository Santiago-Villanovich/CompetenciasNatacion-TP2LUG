using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class formCompetencias : Form
    {
        public void Limpiar()
        {
            txtNombre.Text = null;
            txtDescripcion.Text = null;
            txtUbicacion.Text = null;
            txtDistancia.Text = null;
            numupPrecioEntrada.Value = 0;
            numupPremio.Value = 0;

            beCompeAA.LimpiarPropiedades();
            beCompeP.LimpiarPropiedades();
            

        }

        public void OcultarAguasAbiertas(bool b)
        {
            if (b == true)
            {
                txtDistancia.Visible = false;
                txtDistancia.Enabled = false;
                lblDistancia.Visible = false;

                cboxTipo.Visible = true;
                cboxTipo.Enabled = true;
                lblModalidad.Visible = true;
            }
            else
            {
                txtDistancia.Visible = true;
                txtDistancia.Enabled = true;
                lblDistancia.Visible = true;

                cboxTipo.Visible = false;
                cboxTipo.Enabled = false;
                lblModalidad.Visible = false;
            }
        }

        public formCompetencias()
        {
            InitializeComponent();
            bllCompeAA = new BLLaguasAbiertas();
            beCompeAA = new BEaguasAbiertas();
            beCompeP = new BEpileta();
            bllCompeP = new BLLpileta();
            
        }

        BLLaguasAbiertas bllCompeAA;
        BEaguasAbiertas beCompeAA;
        BEpileta beCompeP;
        BLLpileta bllCompeP;

        private void formCompetencias_Load(object sender, EventArgs e)
        {
            cboxTipo.DataSource = null;
            cboxTipo.DataSource = Enum.GetValues(typeof(EnumModalidadesPileta));
            cboxTipo.SelectedItem = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAguasAbiertas.Checked == true)
                {
                    beCompeAA.Nombre = txtNombre.Text;
                    beCompeAA.descripcion = txtDescripcion.Text;
                    beCompeAA.Fecha = dateTimePicker1.Value;
                    beCompeAA.Ubicacion = txtUbicacion.Text;
                    beCompeAA.PrecioEntrada = Convert.ToInt32(numupPrecioEntrada.Value);
                    beCompeAA.Premio = Convert.ToInt32(numupPremio.Value);
                    beCompeAA.Distancia = txtDistancia.Text;

                    bllCompeAA.Guardar(beCompeAA);
                    Limpiar();
                }
                else if (rbPileta.Checked == true)
                {
                    beCompeP.Nombre = txtNombre.Text;
                    beCompeP.descripcion = txtDescripcion.Text;
                    beCompeP.Fecha = dateTimePicker1.Value;
                    beCompeP.Ubicacion = txtUbicacion.Text;
                    beCompeP.PrecioEntrada = Convert.ToInt32(numupPrecioEntrada.Value);
                    beCompeP.Premio = Convert.ToInt32(numupPremio.Value);
                    beCompeP.Tipo = cboxTipo.SelectedItem.ToString();

                    bllCompeP.Guardar(beCompeP);
                    Limpiar();
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
                if (rbAguasAbiertas.Checked == true)
                {
                    if (beCompeAA.ID != 0)
                    {
                        bllCompeAA.Eliminar(beCompeAA);
                    }
                }
                else if (rbPileta.Checked == true)
                {
                    if (beCompeP.ID != 0)
                    {
                        bllCompeP.Eliminar(beCompeP);
                    }
                }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        #region(RadioButtons)
        private void rbAguasAbiertas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAguasAbiertas.Checked == true)
            {
                OcultarAguasAbiertas(false);
            }
            
        }

        private void rbPileta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPileta.Checked == true)
            {
                OcultarAguasAbiertas(true);
            }
            
        }

        private void rbMostrarAA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbMostrarAA.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bllCompeAA.ListarObjs();
                    dataGridView1.Columns["PrimerPuesto"].Visible = false;
                }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        private void rbMostrarP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbMostrarP.Checked == true)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bllCompeP.ListarObjs();
                    dataGridView1.Columns["EquipoGanador"].Visible = false;
                }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbMostrarAA.Checked == true)
            {
                beCompeAA = (BEaguasAbiertas)dataGridView1.CurrentRow.DataBoundItem;
                OcultarAguasAbiertas(false);

                txtNombre.Text = beCompeAA.Nombre;
                txtDescripcion.Text = beCompeAA.descripcion;
                txtUbicacion.Text = beCompeAA.Ubicacion;
                dateTimePicker1.Value = beCompeAA.Fecha;
                numupPrecioEntrada.Value = beCompeAA.PrecioEntrada;
                numupPremio.Value = beCompeAA.Premio;
                txtDistancia.Text = beCompeAA.Distancia;
                
            }
            else if (rbMostrarP.Checked == true)
            {
                beCompeP = (BEpileta)dataGridView1.CurrentRow.DataBoundItem;
                OcultarAguasAbiertas(true);

                txtNombre.Text = beCompeP.Nombre;
                txtDescripcion.Text = beCompeP.descripcion;
                txtUbicacion.Text = beCompeP.Ubicacion;
                dateTimePicker1.Value = beCompeP.Fecha;
                numupPrecioEntrada.Value = beCompeP.PrecioEntrada;
                numupPremio.Value = beCompeP.Premio;
                cboxTipo.Text = beCompeP.Tipo;
                

            }
        }
    }
}
