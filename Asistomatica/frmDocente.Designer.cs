namespace Asistomatica
{
    partial class frmDocente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpVerClasesDia = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu de opciones Docente";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpVerClasesDia);
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Location = new System.Drawing.Point(7, 19);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(797, 412);
            this.tcMain.TabIndex = 0;
            // 
            // tpVerClasesDia
            // 
            this.tpVerClasesDia.Location = new System.Drawing.Point(4, 22);
            this.tpVerClasesDia.Name = "tpVerClasesDia";
            this.tpVerClasesDia.Padding = new System.Windows.Forms.Padding(3);
            this.tpVerClasesDia.Size = new System.Drawing.Size(789, 386);
            this.tpVerClasesDia.TabIndex = 3;
            this.tpVerClasesDia.Text = "Clases del dia a registrar";
            this.tpVerClasesDia.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 386);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Registrar asistencia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDocente";
            this.Text = "Registro de asistencia, Docente: @nombre";
            this.groupBox1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpVerClasesDia;
        private System.Windows.Forms.TabPage tabPage1;
    }
}