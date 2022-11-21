using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formParticipantes formu = new formParticipantes();
            formu.MdiParent = this;
            formu.Show();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEquipos formu = new formEquipos();
            formu.MdiParent = this;
            formu.Show();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void nuevoOrganizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdministradores formu = new formAdministradores();
            formu.MdiParent = this;
            formu.Show();
        }

        private void patrocinadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPatrocinadores formu = new formPatrocinadores();
            formu.MdiParent = this;
            formu.Show();
        }

        private void nuevaCompetenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCompetencias formu = new formCompetencias();
            formu.MdiParent = this;
            formu.Show();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInforme formu = new formInforme();
            formu.MdiParent = this;
            formu.Show();
        }
    }
}
