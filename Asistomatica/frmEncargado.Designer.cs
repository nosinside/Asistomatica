namespace Asistomatica
{
    partial class frmEncargado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncargado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcMainEncargado = new System.Windows.Forms.TabControl();
            this.tpModificaLibro = new System.Windows.Forms.TabPage();
            this.tpAbrirLibro = new System.Windows.Forms.TabPage();
            this.tpCerrarLibro = new System.Windows.Forms.TabPage();
            this.tpGeneraLibro = new System.Windows.Forms.TabPage();
            this.tpGeneraInforme = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.lvLibrosporGenerar = new System.Windows.Forms.ListView();
            this.lbllistview = new System.Windows.Forms.Label();
            this.chRutDocente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCodigoAsignatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSeccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPorcentaje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSede = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCantidadAlumnos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHoras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGeneraLibros = new System.Windows.Forms.Button();
            this.lblLeyendaBotonGeneraLibros = new System.Windows.Forms.Label();
            this.chUbicacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHoraSemana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblfechaInicio = new System.Windows.Forms.Label();
            this.lblFechaTermino = new System.Windows.Forms.Label();
            this.dpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dpFechaTermino = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.tcMainEncargado.SuspendLayout();
            this.tpAbrirLibro.SuspendLayout();
            this.tpGeneraLibro.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcMainEncargado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu de opciones Encargado asistencia";
            // 
            // tcMainEncargado
            // 
            this.tcMainEncargado.Controls.Add(this.tpModificaLibro);
            this.tcMainEncargado.Controls.Add(this.tpAbrirLibro);
            this.tcMainEncargado.Controls.Add(this.tpCerrarLibro);
            this.tcMainEncargado.Controls.Add(this.tpGeneraLibro);
            this.tcMainEncargado.Controls.Add(this.tpGeneraInforme);
            this.tcMainEncargado.Location = new System.Drawing.Point(7, 19);
            this.tcMainEncargado.Name = "tcMainEncargado";
            this.tcMainEncargado.SelectedIndex = 0;
            this.tcMainEncargado.Size = new System.Drawing.Size(797, 412);
            this.tcMainEncargado.TabIndex = 0;
            this.tcMainEncargado.Enter += new System.EventHandler(this.tcMainEncargado_Enter);
            // 
            // tpModificaLibro
            // 
            this.tpModificaLibro.Location = new System.Drawing.Point(4, 22);
            this.tpModificaLibro.Name = "tpModificaLibro";
            this.tpModificaLibro.Padding = new System.Windows.Forms.Padding(3);
            this.tpModificaLibro.Size = new System.Drawing.Size(789, 386);
            this.tpModificaLibro.TabIndex = 0;
            this.tpModificaLibro.Text = "Modificar Libros de Asistencia";
            this.tpModificaLibro.UseVisualStyleBackColor = true;
            // 
            // tpAbrirLibro
            // 
            this.tpAbrirLibro.Controls.Add(this.groupBox2);
            this.tpAbrirLibro.Location = new System.Drawing.Point(4, 22);
            this.tpAbrirLibro.Name = "tpAbrirLibro";
            this.tpAbrirLibro.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbrirLibro.Size = new System.Drawing.Size(789, 386);
            this.tpAbrirLibro.TabIndex = 1;
            this.tpAbrirLibro.Text = "Abrir libros de asistencia";
            this.tpAbrirLibro.UseVisualStyleBackColor = true;
            // 
            // tpCerrarLibro
            // 
            this.tpCerrarLibro.Location = new System.Drawing.Point(4, 22);
            this.tpCerrarLibro.Name = "tpCerrarLibro";
            this.tpCerrarLibro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCerrarLibro.Size = new System.Drawing.Size(789, 386);
            this.tpCerrarLibro.TabIndex = 2;
            this.tpCerrarLibro.Text = "Cerrar libros de asistencia";
            this.tpCerrarLibro.UseVisualStyleBackColor = true;
            // 
            // tpGeneraLibro
            // 
            this.tpGeneraLibro.Controls.Add(this.lbllistview);
            this.tpGeneraLibro.Controls.Add(this.lvLibrosporGenerar);
            this.tpGeneraLibro.Controls.Add(this.gbOpciones);
            this.tpGeneraLibro.Location = new System.Drawing.Point(4, 22);
            this.tpGeneraLibro.Name = "tpGeneraLibro";
            this.tpGeneraLibro.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneraLibro.Size = new System.Drawing.Size(789, 386);
            this.tpGeneraLibro.TabIndex = 3;
            this.tpGeneraLibro.Text = "Generar libros de Asistencia";
            this.tpGeneraLibro.UseVisualStyleBackColor = true;
            // 
            // tpGeneraInforme
            // 
            this.tpGeneraInforme.Location = new System.Drawing.Point(4, 22);
            this.tpGeneraInforme.Name = "tpGeneraInforme";
            this.tpGeneraInforme.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneraInforme.Size = new System.Drawing.Size(789, 386);
            this.tpGeneraInforme.TabIndex = 4;
            this.tpGeneraInforme.Text = "Generar informes de Asistencia";
            this.tpGeneraInforme.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 374);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.dpFechaTermino);
            this.gbOpciones.Controls.Add(this.dpFechaInicio);
            this.gbOpciones.Controls.Add(this.lblFechaTermino);
            this.gbOpciones.Controls.Add(this.lblfechaInicio);
            this.gbOpciones.Controls.Add(this.lblHoras);
            this.gbOpciones.Controls.Add(this.label2);
            this.gbOpciones.Controls.Add(this.txtHoraSemana);
            this.gbOpciones.Controls.Add(this.lblLeyendaBotonGeneraLibros);
            this.gbOpciones.Controls.Add(this.btnGeneraLibros);
            this.gbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(6, 32);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(237, 348);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // lvLibrosporGenerar
            // 
            this.lvLibrosporGenerar.AllowColumnReorder = true;
            this.lvLibrosporGenerar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombre,
            this.chSeccion,
            this.chCantidadAlumnos,
            this.chUbicacion,
            this.chSede,
            this.chHoras,
            this.chPorcentaje,
            this.chCodigoAsignatura,
            this.chRutDocente});
            this.lvLibrosporGenerar.FullRowSelect = true;
            this.lvLibrosporGenerar.GridLines = true;
            this.lvLibrosporGenerar.Location = new System.Drawing.Point(249, 39);
            this.lvLibrosporGenerar.Name = "lvLibrosporGenerar";
            this.lvLibrosporGenerar.Size = new System.Drawing.Size(534, 341);
            this.lvLibrosporGenerar.TabIndex = 1;
            this.lvLibrosporGenerar.UseCompatibleStateImageBehavior = false;
            this.lvLibrosporGenerar.View = System.Windows.Forms.View.Details;
            this.lvLibrosporGenerar.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvLibrosporGenerar_ItemSelectionChanged);
            // 
            // lbllistview
            // 
            this.lbllistview.AutoSize = true;
            this.lbllistview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistview.Location = new System.Drawing.Point(249, 18);
            this.lbllistview.Name = "lbllistview";
            this.lbllistview.Size = new System.Drawing.Size(332, 18);
            this.lbllistview.TabIndex = 2;
            this.lbllistview.Text = "Lista de Asignaturas con libros por generar";
            // 
            // chRutDocente
            // 
            this.chRutDocente.Text = "Rut Docente";
            this.chRutDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRutDocente.Width = 85;
            // 
            // chCodigoAsignatura
            // 
            this.chCodigoAsignatura.Text = "Codigo Asignatura";
            this.chCodigoAsignatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCodigoAsignatura.Width = 103;
            // 
            // chSeccion
            // 
            this.chSeccion.Text = "Seccion";
            this.chSeccion.Width = 58;
            // 
            // chPorcentaje
            // 
            this.chPorcentaje.Text = "Porcentaje libro";
            this.chPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPorcentaje.Width = 92;
            // 
            // chSede
            // 
            this.chSede.Text = "Sede";
            this.chSede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSede.Width = 52;
            // 
            // chCantidadAlumnos
            // 
            this.chCantidadAlumnos.Text = "Cantidad Alumnos";
            this.chCantidadAlumnos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCantidadAlumnos.Width = 99;
            // 
            // chHoras
            // 
            this.chHoras.Text = "Horas";
            this.chHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGeneraLibros
            // 
            this.btnGeneraLibros.Location = new System.Drawing.Point(19, 269);
            this.btnGeneraLibros.Name = "btnGeneraLibros";
            this.btnGeneraLibros.Size = new System.Drawing.Size(105, 23);
            this.btnGeneraLibros.TabIndex = 0;
            this.btnGeneraLibros.Text = "Generar Libros";
            this.btnGeneraLibros.UseVisualStyleBackColor = true;
            this.btnGeneraLibros.Click += new System.EventHandler(this.btnGeneraLibros_Click);
            // 
            // lblLeyendaBotonGeneraLibros
            // 
            this.lblLeyendaBotonGeneraLibros.AutoSize = true;
            this.lblLeyendaBotonGeneraLibros.Location = new System.Drawing.Point(16, 241);
            this.lblLeyendaBotonGeneraLibros.Name = "lblLeyendaBotonGeneraLibros";
            this.lblLeyendaBotonGeneraLibros.Size = new System.Drawing.Size(200, 13);
            this.lblLeyendaBotonGeneraLibros.TabIndex = 1;
            this.lblLeyendaBotonGeneraLibros.Text = "Generar libro de asignatura seleccionada";
            // 
            // chUbicacion
            // 
            this.chUbicacion.Text = "Ubicación";
            this.chUbicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre";
            this.chNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chNombre.Width = 158;
            // 
            // txtHoraSemana
            // 
            this.txtHoraSemana.Location = new System.Drawing.Point(112, 43);
            this.txtHoraSemana.MaxLength = 9;
            this.txtHoraSemana.Name = "txtHoraSemana";
            this.txtHoraSemana.Size = new System.Drawing.Size(100, 20);
            this.txtHoraSemana.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(16, 46);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(90, 13);
            this.lblHoras.TabIndex = 4;
            this.lblHoras.Text = "Horas Semanales";
            // 
            // lblfechaInicio
            // 
            this.lblfechaInicio.AutoSize = true;
            this.lblfechaInicio.Location = new System.Drawing.Point(16, 87);
            this.lblfechaInicio.Name = "lblfechaInicio";
            this.lblfechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblfechaInicio.TabIndex = 5;
            this.lblfechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaTermino
            // 
            this.lblFechaTermino.AutoSize = true;
            this.lblFechaTermino.Location = new System.Drawing.Point(16, 120);
            this.lblFechaTermino.Name = "lblFechaTermino";
            this.lblFechaTermino.Size = new System.Drawing.Size(78, 13);
            this.lblFechaTermino.TabIndex = 6;
            this.lblFechaTermino.Text = "Fecha Termino";
            // 
            // dpFechaInicio
            // 
            this.dpFechaInicio.CustomFormat = "dd/mm/yyyy";
            this.dpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaInicio.Location = new System.Drawing.Point(112, 81);
            this.dpFechaInicio.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dpFechaInicio.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dpFechaInicio.Name = "dpFechaInicio";
            this.dpFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dpFechaInicio.TabIndex = 9;
            this.dpFechaInicio.Value = new System.DateTime(2017, 6, 30, 0, 0, 0, 0);
            // 
            // dpFechaTermino
            // 
            this.dpFechaTermino.CustomFormat = "dd/mm/yyyy";
            this.dpFechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaTermino.Location = new System.Drawing.Point(112, 114);
            this.dpFechaTermino.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dpFechaTermino.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dpFechaTermino.Name = "dpFechaTermino";
            this.dpFechaTermino.Size = new System.Drawing.Size(100, 20);
            this.dpFechaTermino.TabIndex = 10;
            this.dpFechaTermino.Value = new System.DateTime(2017, 6, 30, 0, 0, 0, 0);
            // 
            // frmEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEncargado";
            this.Text = "Menu Encargado @Nombre";
            this.groupBox1.ResumeLayout(false);
            this.tcMainEncargado.ResumeLayout(false);
            this.tpAbrirLibro.ResumeLayout(false);
            this.tpGeneraLibro.ResumeLayout(false);
            this.tpGeneraLibro.PerformLayout();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tcMainEncargado;
        private System.Windows.Forms.TabPage tpModificaLibro;
        private System.Windows.Forms.TabPage tpAbrirLibro;
        private System.Windows.Forms.TabPage tpCerrarLibro;
        private System.Windows.Forms.TabPage tpGeneraLibro;
        private System.Windows.Forms.TabPage tpGeneraInforme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvLibrosporGenerar;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Label lbllistview;
        private System.Windows.Forms.ColumnHeader chRutDocente;
        private System.Windows.Forms.ColumnHeader chCodigoAsignatura;
        private System.Windows.Forms.ColumnHeader chSeccion;
        private System.Windows.Forms.ColumnHeader chPorcentaje;
        private System.Windows.Forms.ColumnHeader chSede;
        private System.Windows.Forms.ColumnHeader chCantidadAlumnos;
        private System.Windows.Forms.ColumnHeader chHoras;
        private System.Windows.Forms.Label lblLeyendaBotonGeneraLibros;
        private System.Windows.Forms.Button btnGeneraLibros;
        private System.Windows.Forms.ColumnHeader chUbicacion;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.Label lblFechaTermino;
        private System.Windows.Forms.Label lblfechaInicio;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoraSemana;
        private System.Windows.Forms.DateTimePicker dpFechaTermino;
        private System.Windows.Forms.DateTimePicker dpFechaInicio;
    }
}