namespace Presentacion.Forms
{
    partial class frmABMTitular
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
            this.dgvTitular = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textFechaInscrip = new System.Windows.Forms.DateTimePicker();
            this.textCorreoElectr = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textNacionalidad = new System.Windows.Forms.TextBox();
            this.textCuil = new System.Windows.Forms.TextBox();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textNroDoc = new System.Windows.Forms.TextBox();
            this.textTypeDoc = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textNroFicha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textFechaNac = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitular)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTitular
            // 
            this.dgvTitular.AllowUserToAddRows = false;
            this.dgvTitular.AllowUserToDeleteRows = false;
            this.dgvTitular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitular.Location = new System.Drawing.Point(11, 94);
            this.dgvTitular.Name = "dgvTitular";
            this.dgvTitular.ReadOnly = true;
            this.dgvTitular.Size = new System.Drawing.Size(504, 436);
            this.dgvTitular.TabIndex = 0;
            this.dgvTitular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTitular_CellClick);
            this.dgvTitular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTitular_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.button1.Location = new System.Drawing.Point(64, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Obtener Todos los Detalles ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textFechaNac);
            this.panel1.Controls.Add(this.textFechaInscrip);
            this.panel1.Controls.Add(this.textCorreoElectr);
            this.panel1.Controls.Add(this.textTelefono);
            this.panel1.Controls.Add(this.textNacionalidad);
            this.panel1.Controls.Add(this.textCuil);
            this.panel1.Controls.Add(this.textGenero);
            this.panel1.Controls.Add(this.textNroDoc);
            this.panel1.Controls.Add(this.textTypeDoc);
            this.panel1.Controls.Add(this.textNombre);
            this.panel1.Controls.Add(this.textNroFicha);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(545, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 644);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textFechaInscrip
            // 
            this.textFechaInscrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textFechaInscrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textFechaInscrip.Location = new System.Drawing.Point(182, 52);
            this.textFechaInscrip.Name = "textFechaInscrip";
            this.textFechaInscrip.Size = new System.Drawing.Size(128, 20);
            this.textFechaInscrip.TabIndex = 24;
            // 
            // textCorreoElectr
            // 
            this.textCorreoElectr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textCorreoElectr.Location = new System.Drawing.Point(134, 434);
            this.textCorreoElectr.Name = "textCorreoElectr";
            this.textCorreoElectr.Size = new System.Drawing.Size(181, 26);
            this.textCorreoElectr.TabIndex = 23;
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textTelefono.Location = new System.Drawing.Point(24, 434);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(98, 26);
            this.textTelefono.TabIndex = 22;
            // 
            // textNacionalidad
            // 
            this.textNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textNacionalidad.Location = new System.Drawing.Point(134, 286);
            this.textNacionalidad.Name = "textNacionalidad";
            this.textNacionalidad.Size = new System.Drawing.Size(178, 26);
            this.textNacionalidad.TabIndex = 21;
            // 
            // textCuil
            // 
            this.textCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textCuil.Location = new System.Drawing.Point(24, 286);
            this.textCuil.Name = "textCuil";
            this.textCuil.Size = new System.Drawing.Size(94, 26);
            this.textCuil.TabIndex = 20;
            // 
            // textGenero
            // 
            this.textGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textGenero.Location = new System.Drawing.Point(24, 359);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(98, 26);
            this.textGenero.TabIndex = 18;
            // 
            // textNroDoc
            // 
            this.textNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textNroDoc.Location = new System.Drawing.Point(131, 212);
            this.textNroDoc.Name = "textNroDoc";
            this.textNroDoc.Size = new System.Drawing.Size(181, 26);
            this.textNroDoc.TabIndex = 17;
            // 
            // textTypeDoc
            // 
            this.textTypeDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textTypeDoc.Location = new System.Drawing.Point(24, 212);
            this.textTypeDoc.Name = "textTypeDoc";
            this.textTypeDoc.Size = new System.Drawing.Size(86, 26);
            this.textTypeDoc.TabIndex = 16;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textNombre.Location = new System.Drawing.Point(24, 127);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(304, 26);
            this.textNombre.TabIndex = 15;
            // 
            // textNroFicha
            // 
            this.textNroFicha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textNroFicha.Location = new System.Drawing.Point(24, 46);
            this.textNroFicha.Name = "textNroFicha";
            this.textNroFicha.Size = new System.Drawing.Size(78, 26);
            this.textNroFicha.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label12.Location = new System.Drawing.Point(130, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Correo Electronico ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label11.Location = new System.Drawing.Point(20, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Telefono ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label10.Location = new System.Drawing.Point(127, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Nacionalidad ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label9.Location = new System.Drawing.Point(20, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "CUIL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label8.Location = new System.Drawing.Point(130, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label7.Location = new System.Drawing.Point(20, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label6.Location = new System.Drawing.Point(127, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nro. Doc. ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label5.Location = new System.Drawing.Point(20, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo Doc. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label4.Location = new System.Drawing.Point(20, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos y Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label3.Location = new System.Drawing.Point(184, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Inscripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro Ficha";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox1.Location = new System.Drawing.Point(11, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese Nro dni o Nombre para filtrar";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.button2.Location = new System.Drawing.Point(367, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.button3.Location = new System.Drawing.Point(368, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "Nuevo Titular";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textFechaNac
            // 
            this.textFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textFechaNac.Location = new System.Drawing.Point(134, 365);
            this.textFechaNac.Name = "textFechaNac";
            this.textFechaNac.Size = new System.Drawing.Size(205, 20);
            this.textFechaNac.TabIndex = 25;
            // 
            // frmABMTitular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTitular);
            this.Name = "frmABMTitular";
            this.Text = "frmABMTitular";
            this.Load += new System.EventHandler(this.frmABMTitular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitular)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTitular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textCorreoElectr;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textNacionalidad;
        private System.Windows.Forms.TextBox textCuil;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textNroDoc;
        private System.Windows.Forms.TextBox textTypeDoc;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textNroFicha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker textFechaInscrip;
        private System.Windows.Forms.DateTimePicker textFechaNac;
    }
}