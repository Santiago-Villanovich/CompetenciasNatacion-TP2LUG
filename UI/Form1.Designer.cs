
namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patrocinadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompetenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoOrganizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.competenciaToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipoToolStripMenuItem,
            this.participantesToolStripMenuItem,
            this.patrocinadoresToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.administracionToolStripMenuItem.Text = "Gestion";
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.participantesToolStripMenuItem.Text = "Participantes";
            this.participantesToolStripMenuItem.Click += new System.EventHandler(this.participantesToolStripMenuItem_Click);
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equipoToolStripMenuItem.Text = "Equipo";
            this.equipoToolStripMenuItem.Click += new System.EventHandler(this.equipoToolStripMenuItem_Click);
            // 
            // patrocinadoresToolStripMenuItem
            // 
            this.patrocinadoresToolStripMenuItem.Name = "patrocinadoresToolStripMenuItem";
            this.patrocinadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.patrocinadoresToolStripMenuItem.Text = "Patrocinadores";
            this.patrocinadoresToolStripMenuItem.Click += new System.EventHandler(this.patrocinadoresToolStripMenuItem_Click);
            // 
            // competenciaToolStripMenuItem
            // 
            this.competenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompetenciaToolStripMenuItem,
            this.informeToolStripMenuItem});
            this.competenciaToolStripMenuItem.Name = "competenciaToolStripMenuItem";
            this.competenciaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.competenciaToolStripMenuItem.Text = "Competencia";
            // 
            // nuevaCompetenciaToolStripMenuItem
            // 
            this.nuevaCompetenciaToolStripMenuItem.Name = "nuevaCompetenciaToolStripMenuItem";
            this.nuevaCompetenciaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nuevaCompetenciaToolStripMenuItem.Text = "Nueva Competencia";
            this.nuevaCompetenciaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCompetenciaToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoOrganizadorToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem1});
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Ajustes";
            // 
            // nuevoOrganizadorToolStripMenuItem
            // 
            this.nuevoOrganizadorToolStripMenuItem.Name = "nuevoOrganizadorToolStripMenuItem";
            this.nuevoOrganizadorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.nuevoOrganizadorToolStripMenuItem.Text = "Nuevo Administrador";
            this.nuevoOrganizadorToolStripMenuItem.Click += new System.EventHandler(this.nuevoOrganizadorToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            this.cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.informeToolStripMenuItem.Text = "Informe";
            this.informeToolStripMenuItem.Click += new System.EventHandler(this.informeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompetenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoOrganizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patrocinadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
    }
}

