namespace Asistomatica
{
    partial class frmDocente2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocente2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcMainEncargado = new System.Windows.Forms.TabControl();
            this.tpModificaLibro = new System.Windows.Forms.TabPage();
            this.tpAbrirLibro = new System.Windows.Forms.TabPage();
            this.tpCerrarLibro = new System.Windows.Forms.TabPage();
            this.tpGeneraLibro = new System.Windows.Forms.TabPage();
            this.tpGeneraInforme = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tcMainEncargado.SuspendLayout();
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
    }
}