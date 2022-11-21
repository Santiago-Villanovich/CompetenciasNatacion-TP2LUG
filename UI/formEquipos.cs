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
using BLL;
using BE;

namespace UI
{
    public partial class formEquipos : Form
    {
        public void CargarDGrid(BEequipo obj)
        {
            try
            {
                dgNadadores.DataSource = null;
                dgNadadores.DataSource = obllEquipo.ListarNadadores(obj);
                //dgNadadores.Columns["Categoria"].Visible = false;
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }

        }

        public void CargarCombos()
        {
            try
            {
                cboxEntrenador.DataSource = null;
                cboxEntrenador.DataSource = obllEntrenador.ListarObjs();
                cboxEntrenador.DisplayMember = "Apellido";
                cboxEntrenador.ValueMember = "ID";

                cboxCategoria.DataSource = null;
                cboxCategoria.DataSource = Enum.GetValues(typeof(EnumCategoria));

                cboxEquipos.DataSource = null;
                cboxEquipos.DataSource = obllEquipo.ListarObjs();
                cboxEquipos.DisplayMember = "nombre";
                cboxEquipos.ValueMember = "ID";
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        public formEquipos()
        {
            InitializeComponent();

            obeEntrenador = new BEentrenador();
            obllEntrenador = new BLLentrenador();
            obeEquipo = new BEequipo();
            obllEquipo = new BLLequipo();

            cboxEntrenador.Enabled = false;
        }

        private void formEquipos_Load(object sender, EventArgs e)
        {
            CargarCombos();
            cboxEntrenador.SelectedItem = null;
            cboxEquipos.SelectedItem = null;
            cboxCategoria.SelectedItem = null;
            //BEequipo equip = (BEequipo)cboxEquipos.SelectedItem;
            //CargarDGrid(equip);
        }

        BEentrenador obeEntrenador;
        BLLentrenador obllEntrenador;
        BEequipo obeEquipo;
        BLLequipo obllEquipo;

        
        private void button2_Click(object sender, EventArgs e)
        {
            formEntrenador formu = new formEntrenador();
            formu.MdiParent = Form1.ActiveForm;
            formu.Show();
        }

        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                obeEquipo.nombre = txtNombre.Text;
                obeEquipo.categoria = cboxCategoria.SelectedItem.ToString();
                obeEquipo.entrenador = (BEentrenador)cboxEntrenador.SelectedItem;

                obllEquipo.Guardar(obeEquipo);
                this.OnLoad(e);
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
        }

        private void checkEntrenador_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkEntrenador.Checked == true)
            {
                cboxEntrenador.Enabled = true;
            }
            else if (checkEntrenador.Checked == false)
            {
                cboxEntrenador.Enabled = false;
                cboxEntrenador.SelectedItem = null;
            }
        }

        private void cboxEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxEquipos.SelectedItem != null)
            {
                BEequipo equip = (BEequipo)cboxEquipos.SelectedItem;
                CargarDGrid(equip);
            }

        }
    }
}
