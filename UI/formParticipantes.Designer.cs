
namespace UI
{
    partial class formParticipantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dgridNadadores = new System.Windows.Forms.DataGridView();
            this.rbInfantil = new System.Windows.Forms.RadioButton();
            this.rbMenores = new System.Windows.Forms.RadioButton();
            this.rbCadetes = new System.Windows.Forms.RadioButton();
            this.rbJuveniles = new System.Windows.Forms.RadioButton();
            this.rbMayores = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbIngresarEnEquipo = new System.Windows.Forms.RadioButton();
            this.rbIngresarIndividual = new System.Windows.Forms.RadioButton();
            this.cboxEquipos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDNI1 = new UI.txtDNI();
            this.cboxCompetencias = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridNadadores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(19, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(237, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(19, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(22, 140);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(240, 141);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(176, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(22, 190);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // dgridNadadores
            // 
            this.dgridNadadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridNadadores.Location = new System.Drawing.Point(494, 131);
            this.dgridNadadores.Name = "dgridNadadores";
            this.dgridNadadores.Size = new System.Drawing.Size(284, 260);
            this.dgridNadadores.TabIndex = 8;
            this.dgridNadadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridNadadores_CellContentClick);
            // 
            // rbInfantil
            // 
            this.rbInfantil.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbInfantil.AutoSize = true;
            this.rbInfantil.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rbInfantil.Location = new System.Drawing.Point(494, 73);
            this.rbInfantil.Name = "rbInfantil";
            this.rbInfantil.Size = new System.Drawing.Size(59, 23);
            this.rbInfantil.TabIndex = 9;
            this.rbInfantil.TabStop = true;
            this.rbInfantil.Text = "Infantiles";
            this.rbInfantil.UseVisualStyleBackColor = false;
            this.rbInfantil.CheckedChanged += new System.EventHandler(this.rbInfantil_CheckedChanged);
            // 
            // rbMenores
            // 
            this.rbMenores.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMenores.AutoSize = true;
            this.rbMenores.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rbMenores.Location = new System.Drawing.Point(559, 73);
            this.rbMenores.Name = "rbMenores";
            this.rbMenores.Size = new System.Drawing.Size(58, 23);
            this.rbMenores.TabIndex = 10;
            this.rbMenores.TabStop = true;
            this.rbMenores.Text = "Menores";
            this.rbMenores.UseVisualStyleBackColor = false;
            this.rbMenores.CheckedChanged += new System.EventHandler(this.rbMenores_CheckedChanged);
            // 
            // rbCadetes
            // 
            this.rbCadetes.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCadetes.AutoSize = true;
            this.rbCadetes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rbCadetes.Location = new System.Drawing.Point(623, 73);
            this.rbCadetes.Name = "rbCadetes";
            this.rbCadetes.Size = new System.Drawing.Size(56, 23);
            this.rbCadetes.TabIndex = 11;
            this.rbCadetes.TabStop = true;
            this.rbCadetes.Text = "Cadetes";
            this.rbCadetes.UseVisualStyleBackColor = false;
            this.rbCadetes.CheckedChanged += new System.EventHandler(this.rbCadetes_CheckedChanged);
            // 
            // rbJuveniles
            // 
            this.rbJuveniles.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJuveniles.AutoSize = true;
            this.rbJuveniles.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rbJuveniles.Location = new System.Drawing.Point(494, 102);
            this.rbJuveniles.Name = "rbJuveniles";
            this.rbJuveniles.Size = new System.Drawing.Size(61, 23);
            this.rbJuveniles.TabIndex = 12;
            this.rbJuveniles.TabStop = true;
            this.rbJuveniles.Text = "Juveniles";
            this.rbJuveniles.UseVisualStyleBackColor = false;
            this.rbJuveniles.CheckedChanged += new System.EventHandler(this.rbJuveniles_CheckedChanged);
            // 
            // rbMayores
            // 
            this.rbMayores.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMayores.AutoSize = true;
            this.rbMayores.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rbMayores.Location = new System.Drawing.Point(561, 102);
            this.rbMayores.Name = "rbMayores";
            this.rbMayores.Size = new System.Drawing.Size(57, 23);
            this.rbMayores.TabIndex = 13;
            this.rbMayores.TabStop = true;
            this.rbMayores.Text = "Mayores";
            this.rbMayores.UseVisualStyleBackColor = false;
            this.rbMayores.CheckedChanged += new System.EventHandler(this.rbMayores_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HP Simplified Jpan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Filtros";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Font = new System.Drawing.Font("HP Simplified Hans", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(50, 253);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 43);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminar.Font = new System.Drawing.Font("HP Simplified Hans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(50, 302);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 24);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified Jpan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(19, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gestion de nadadores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(237, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dni";
            // 
            // rbIngresarEnEquipo
            // 
            this.rbIngresarEnEquipo.AutoSize = true;
            this.rbIngresarEnEquipo.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.rbIngresarEnEquipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbIngresarEnEquipo.Location = new System.Drawing.Point(335, 184);
            this.rbIngresarEnEquipo.Name = "rbIngresarEnEquipo";
            this.rbIngresarEnEquipo.Size = new System.Drawing.Size(90, 36);
            this.rbIngresarEnEquipo.TabIndex = 20;
            this.rbIngresarEnEquipo.TabStop = true;
            this.rbIngresarEnEquipo.Text = "Ingresar en \r\nEquipo";
            this.rbIngresarEnEquipo.UseVisualStyleBackColor = true;
            this.rbIngresarEnEquipo.CheckedChanged += new System.EventHandler(this.rbIngresarEnEquipo_CheckedChanged);
            // 
            // rbIngresarIndividual
            // 
            this.rbIngresarIndividual.AutoSize = true;
            this.rbIngresarIndividual.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.rbIngresarIndividual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbIngresarIndividual.Location = new System.Drawing.Point(240, 184);
            this.rbIngresarIndividual.Name = "rbIngresarIndividual";
            this.rbIngresarIndividual.Size = new System.Drawing.Size(78, 36);
            this.rbIngresarIndividual.TabIndex = 21;
            this.rbIngresarIndividual.TabStop = true;
            this.rbIngresarIndividual.Text = "Ingresar \r\nIndividual";
            this.rbIngresarIndividual.UseVisualStyleBackColor = true;
            this.rbIngresarIndividual.CheckedChanged += new System.EventHandler(this.rbIngresarIndividual_CheckedChanged);
            // 
            // cboxEquipos
            // 
            this.cboxEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEquipos.FormattingEnabled = true;
            this.cboxEquipos.Location = new System.Drawing.Point(240, 253);
            this.cboxEquipos.Name = "cboxEquipos";
            this.cboxEquipos.Size = new System.Drawing.Size(176, 21);
            this.cboxEquipos.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.txtDNI1);
            this.groupBox1.Controls.Add(this.cboxCompetencias);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboxEquipos);
            this.groupBox1.Controls.Add(this.rbIngresarIndividual);
            this.groupBox1.Controls.Add(this.rbIngresarEnEquipo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 415);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // txtDNI1
            // 
            this.txtDNI1.Location = new System.Drawing.Point(236, 82);
            this.txtDNI1.Name = "txtDNI1";
            this.txtDNI1.Size = new System.Drawing.Size(138, 27);
            this.txtDNI1.TabIndex = 26;
            // 
            // cboxCompetencias
            // 
            this.cboxCompetencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCompetencias.FormattingEnabled = true;
            this.cboxCompetencias.Location = new System.Drawing.Point(240, 308);
            this.cboxCompetencias.Name = "cboxCompetencias";
            this.cboxCompetencias.Size = new System.Drawing.Size(176, 21);
            this.cboxCompetencias.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(237, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Seleccione Competencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(237, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Seleccione al Equipo";
            // 
            // formParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(832, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbMayores);
            this.Controls.Add(this.rbJuveniles);
            this.Controls.Add(this.rbCadetes);
            this.Controls.Add(this.rbMenores);
            this.Controls.Add(this.rbInfantil);
            this.Controls.Add(this.dgridNadadores);
            this.Name = "formParticipantes";
            this.Text = "formParticipantes";
            this.Load += new System.EventHandler(this.formParticipantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridNadadores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DataGridView dgridNadadores;
        private System.Windows.Forms.RadioButton rbInfantil;
        private System.Windows.Forms.RadioButton rbMenores;
        private System.Windows.Forms.RadioButton rbCadetes;
        private System.Windows.Forms.RadioButton rbJuveniles;
        private System.Windows.Forms.RadioButton rbMayores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbIngresarEnEquipo;
        private System.Windows.Forms.RadioButton rbIngresarIndividual;
        private System.Windows.Forms.ComboBox cboxEquipos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxCompetencias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private txtDNI txtDNI1;
    }
}