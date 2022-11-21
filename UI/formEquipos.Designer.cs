
namespace UI
{
    partial class formEquipos
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
            this.cboxEquipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevoEquipo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgNadadores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEntrenador = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboxEntrenador = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgNadadores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxEquipos
            // 
            this.cboxEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEquipos.FormattingEnabled = true;
            this.cboxEquipos.Location = new System.Drawing.Point(21, 69);
            this.cboxEquipos.Name = "cboxEquipos";
            this.cboxEquipos.Size = new System.Drawing.Size(149, 21);
            this.cboxEquipos.TabIndex = 0;
            this.cboxEquipos.SelectedIndexChanged += new System.EventHandler(this.cboxEquipos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipo";
            // 
            // btnNuevoEquipo
            // 
            this.btnNuevoEquipo.BackColor = System.Drawing.Color.DimGray;
            this.btnNuevoEquipo.Font = new System.Drawing.Font("HP Simplified Hans", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNuevoEquipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoEquipo.Location = new System.Drawing.Point(27, 232);
            this.btnNuevoEquipo.Name = "btnNuevoEquipo";
            this.btnNuevoEquipo.Size = new System.Drawing.Size(138, 42);
            this.btnNuevoEquipo.TabIndex = 8;
            this.btnNuevoEquipo.Text = "Guardar ";
            this.btnNuevoEquipo.UseVisualStyleBackColor = false;
            this.btnNuevoEquipo.Click += new System.EventHandler(this.btnNuevoEquipo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(27, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre del equipo";
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(27, 120);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(138, 21);
            this.cboxCategoria.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(24, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Categoria";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("HP Simplified Hans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(171, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "Agregar Entrenador";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgNadadores
            // 
            this.dgNadadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNadadores.Location = new System.Drawing.Point(206, 69);
            this.dgNadadores.Name = "dgNadadores";
            this.dgNadadores.Size = new System.Drawing.Size(306, 117);
            this.dgNadadores.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(203, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nadadores en equipo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 42);
            this.button3.TabIndex = 22;
            this.button3.Text = "Eliminar Nadador";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Jpan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nuevo Equipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified Jpan", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Equipos Existentes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Apellido Nadador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nombre Nadador";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.checkEntrenador);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboxEntrenador);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboxCategoria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnNuevoEquipo);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 307);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // checkEntrenador
            // 
            this.checkEntrenador.AutoSize = true;
            this.checkEntrenador.Location = new System.Drawing.Point(6, 182);
            this.checkEntrenador.Name = "checkEntrenador";
            this.checkEntrenador.Size = new System.Drawing.Size(15, 14);
            this.checkEntrenador.TabIndex = 26;
            this.checkEntrenador.UseVisualStyleBackColor = true;
            this.checkEntrenador.CheckStateChanged += new System.EventHandler(this.checkEntrenador_CheckStateChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HP Simplified Jpan", 9.75F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(24, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Seleccione Entrenador";
            // 
            // cboxEntrenador
            // 
            this.cboxEntrenador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEntrenador.FormattingEnabled = true;
            this.cboxEntrenador.Location = new System.Drawing.Point(27, 179);
            this.cboxEntrenador.Name = "cboxEntrenador";
            this.cboxEntrenador.Size = new System.Drawing.Size(138, 21);
            this.cboxEntrenador.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgNadadores);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboxEquipos);
            this.groupBox2.Location = new System.Drawing.Point(329, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 307);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // formEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formEquipos";
            this.Text = "formEquipos";
            this.Load += new System.EventHandler(this.formEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNadadores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxEquipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevoEquipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgNadadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxEntrenador;
        private System.Windows.Forms.CheckBox checkEntrenador;
    }
}