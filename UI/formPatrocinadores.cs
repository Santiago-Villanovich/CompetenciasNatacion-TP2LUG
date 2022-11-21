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
    public partial class formPatrocinadores : Form
    {
        public void CargarDgrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bllPatro.ListarObjs();

        }

        public formPatrocinadores()
        {
            InitializeComponent();
            
            bllPatro = new BLLpatrocinador();
        }

        BLLpatrocinador bllPatro;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BEpatrocinador bePatro = new BEpatrocinador(Convert.ToInt32(txtId.Text),txtNombre.Text,Convert.ToInt32(txtImporte.Text));
            bllPatro.Guardar(bePatro);
            CargarDgrid();
            txtId.Text = null;
            txtNombre.Text = null;
            txtImporte.Text = null;
        }

        private void formPatrocinadores_Load(object sender, EventArgs e)
        {
            CargarDgrid();
        }
    }
}
