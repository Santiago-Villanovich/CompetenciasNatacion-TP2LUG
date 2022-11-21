
namespace UI
{
    partial class formCompetencias
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
            this.rbAguasAbiertas = new System.Windows.Forms.RadioButton();
            this.rbPileta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.numupPrecioEntrada = new System.Windows.Forms.NumericUpDown();
            this.numupPremio = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbMostrarP = new System.Windows.Forms.RadioButton();
            this.rbMostrarAA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.gbGrid = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numupPrecioEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupPremio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbIngreso.SuspendLayout();
            this.gbGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAguasAbiertas
            // 
            this.rbAguasAbiertas.AutoSize = true;
            this.rbAguasAbiertas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAguasAbiertas.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.rbAguasAbiertas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbAguasAbiertas.Location = new System.Drawing.Point(21, 19);
            this.rbAguasAbiertas.Name = "rbAguasAbiertas";
            this.rbAguasAbiertas.Size = new System.Drawing.Size(107, 20);
            this.rbAguasAbiertas.TabIndex = 0;
            this.rbAguasAbiertas.TabStop = true;
            this.rbAguasAbiertas.Text = "Aguas Abiertas";
            this.rbAguasAbiertas.UseVisualStyleBackColor = true;
            this.rbAguasAbiertas.CheckedChanged += new System.EventHandler(this.rbAguasAbiertas_CheckedChanged);
            // 
            // rbPileta
            // 
            this.rbPileta.AutoSize = true;
            this.rbPileta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPileta.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.rbPileta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbPileta.Location = new System.Drawing.Point(128, 19);
            this.rbPileta.Name = "rbPileta";
            this.rbPileta.Size = new System.Drawing.Size(73, 20);
            this.rbPileta.TabIndex = 1;
            this.rbPileta.TabStop = true;
            this.rbPileta.Text = "En Pileta";
            this.rbPileta.UseVisualStyleBackColor = true;
            this.rbPileta.CheckedChanged += new System.EventHandler(this.rbPileta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Jpan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Competencia : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(19, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(18, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha del evento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(18, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ubicacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(197, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Precio de entrada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(304, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Premio";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.lblDistancia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDistancia.Location = new System.Drawing.Point(197, 108);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(87, 16);
            this.lblDistancia.TabIndex = 11;
            this.lblDistancia.Text = "Distancia total";
            this.lblDistancia.Visible = false;
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.lblModalidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblModalidad.Location = new System.Drawing.Point(304, 108);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(63, 16);
            this.lblModalidad.TabIndex = 12;
            this.lblModalidad.Text = "Modalidad";
            this.lblModalidad.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(22, 124);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(22, 216);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(165, 20);
            this.txtUbicacion.TabIndex = 15;
            // 
            // numupPrecioEntrada
            // 
            this.numupPrecioEntrada.Location = new System.Drawing.Point(200, 76);
            this.numupPrecioEntrada.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numupPrecioEntrada.Name = "numupPrecioEntrada";
            this.numupPrecioEntrada.Size = new System.Drawing.Size(101, 20);
            this.numupPrecioEntrada.TabIndex = 16;
            // 
            // numupPremio
            // 
            this.numupPremio.Location = new System.Drawing.Point(307, 76);
            this.numupPremio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numupPremio.Name = "numupPremio";
            this.numupPremio.Size = new System.Drawing.Size(100, 20);
            this.numupPremio.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(200, 124);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(101, 20);
            this.txtDistancia.TabIndex = 19;
            this.txtDistancia.Visible = false;
            // 
            // cboxTipo
            // 
            this.cboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Location = new System.Drawing.Point(307, 123);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(100, 21);
            this.cboxTipo.TabIndex = 20;
            this.cboxTipo.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(227, 168);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 40);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminar.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(227, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 22);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Cancelar competencia";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 127);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rbMostrarP
            // 
            this.rbMostrarP.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMostrarP.AutoSize = true;
            this.rbMostrarP.BackColor = System.Drawing.Color.DimGray;
            this.rbMostrarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMostrarP.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F);
            this.rbMostrarP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMostrarP.Location = new System.Drawing.Point(118, 13);
            this.rbMostrarP.Name = "rbMostrarP";
            this.rbMostrarP.Size = new System.Drawing.Size(67, 24);
            this.rbMostrarP.TabIndex = 25;
            this.rbMostrarP.TabStop = true;
            this.rbMostrarP.Text = "En Pileta";
            this.rbMostrarP.UseVisualStyleBackColor = false;
            this.rbMostrarP.CheckedChanged += new System.EventHandler(this.rbMostrarP_CheckedChanged);
            // 
            // rbMostrarAA
            // 
            this.rbMostrarAA.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMostrarAA.AutoSize = true;
            this.rbMostrarAA.BackColor = System.Drawing.Color.DimGray;
            this.rbMostrarAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMostrarAA.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F);
            this.rbMostrarAA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbMostrarAA.Location = new System.Drawing.Point(11, 13);
            this.rbMostrarAA.Name = "rbMostrarAA";
            this.rbMostrarAA.Size = new System.Drawing.Size(101, 24);
            this.rbMostrarAA.TabIndex = 24;
            this.rbMostrarAA.TabStop = true;
            this.rbMostrarAA.Text = "Aguas Abiertas";
            this.rbMostrarAA.UseVisualStyleBackColor = false;
            this.rbMostrarAA.CheckedChanged += new System.EventHandler(this.rbMostrarAA_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HP Simplified Jpan", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(470, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ver listado de :";
            // 
            // gbIngreso
            // 
            this.gbIngreso.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbIngreso.Controls.Add(this.btnEliminar);
            this.gbIngreso.Controls.Add(this.btnGuardar);
            this.gbIngreso.Controls.Add(this.cboxTipo);
            this.gbIngreso.Controls.Add(this.txtDistancia);
            this.gbIngreso.Controls.Add(this.rbPileta);
            this.gbIngreso.Controls.Add(this.dateTimePicker1);
            this.gbIngreso.Controls.Add(this.rbAguasAbiertas);
            this.gbIngreso.Controls.Add(this.numupPremio);
            this.gbIngreso.Controls.Add(this.numupPrecioEntrada);
            this.gbIngreso.Controls.Add(this.txtUbicacion);
            this.gbIngreso.Controls.Add(this.txtDescripcion);
            this.gbIngreso.Controls.Add(this.txtNombre);
            this.gbIngreso.Controls.Add(this.lblModalidad);
            this.gbIngreso.Controls.Add(this.lblDistancia);
            this.gbIngreso.Controls.Add(this.label9);
            this.gbIngreso.Controls.Add(this.label8);
            this.gbIngreso.Controls.Add(this.label7);
            this.gbIngreso.Controls.Add(this.label6);
            this.gbIngreso.Controls.Add(this.label4);
            this.gbIngreso.Controls.Add(this.label3);
            this.gbIngreso.Controls.Add(this.label2);
            this.gbIngreso.Location = new System.Drawing.Point(12, 62);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(424, 289);
            this.gbIngreso.TabIndex = 27;
            this.gbIngreso.TabStop = false;
            // 
            // gbGrid
            // 
            this.gbGrid.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gbGrid.Controls.Add(this.dataGridView1);
            this.gbGrid.Controls.Add(this.rbMostrarAA);
            this.gbGrid.Controls.Add(this.rbMostrarP);
            this.gbGrid.Location = new System.Drawing.Point(463, 62);
            this.gbGrid.Name = "gbGrid";
            this.gbGrid.Size = new System.Drawing.Size(391, 289);
            this.gbGrid.TabIndex = 28;
            this.gbGrid.TabStop = false;
            // 
            // formCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(867, 418);
            this.Controls.Add(this.gbGrid);
            this.Controls.Add(this.gbIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "formCompetencias";
            this.Text = "formCompetencias";
            this.Load += new System.EventHandler(this.formCompetencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupPrecioEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupPremio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            this.gbGrid.ResumeLayout(false);
            this.gbGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAguasAbiertas;
        private System.Windows.Forms.RadioButton rbPileta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.NumericUpDown numupPrecioEntrada;
        private System.Windows.Forms.NumericUpDown numupPremio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbMostrarP;
        private System.Windows.Forms.RadioButton rbMostrarAA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbIngreso;
        private System.Windows.Forms.GroupBox gbGrid;
    }
}