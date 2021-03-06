﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Asistomatica
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void colores()
        {
            if (txtNombreUsuario.Text.Length == 0)
            {
                txtNombreUsuario.BackColor = Color.Tomato;
            }
            if (txtContraseña.Text.Length == 0)
            {
                txtContraseña.BackColor = Color.Tomato;
            }
        }

        private void limpiarCampos()
        {
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            txtContraseña.BackColor = Color.White;
            txtNombreUsuario.BackColor = Color.White;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "" || txtNombreUsuario.Text == "")
            {
                colores();
                MessageBox.Show("faltan campos por completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //pregunta por el encargado primero
                clsEncargado objUsuario = Logica.clsEncargado.inicioSesion(txtNombreUsuario.Text, txtContraseña.Text);
                if (objUsuario != null)
                {
                    if (objUsuario.contraseña == txtContraseña.Text)
                    {
                        if (objUsuario.tipoUsuario == "E")
                        {
                            frmEncargado app = new frmEncargado();
                            this.Hide();
                            app.ShowDialog();
                            this.Close();
                        }
                    }
                }
                else
                {
                    //pregunta por los porfesores
                    clsProfesor objUsuario2 = Logica.clsProfesor.inicioSesion(txtNombreUsuario.Text, txtContraseña.Text);
                    if (objUsuario != null)
                    {
                        if (objUsuario.contraseña == txtContraseña.Text)
                        {
                            if (objUsuario.tipoUsuario == "D")
                            {
                                frmEncargado app = new frmEncargado();
                                this.Hide();
                                app.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        colores();
                    }
                }
            }

        }
    }
}
