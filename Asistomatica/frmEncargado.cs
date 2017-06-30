using System;
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
    public partial class frmEncargado : Form
    {
        public frmEncargado()
        {
            InitializeComponent();
        }

        // temporal uso recurrente
        string temp = null;

        // listviewitems Llenado

        private void llenarGrillaLibrosPorGenerar()
        {
            ListViewItem _item;
            lvLibrosporGenerar.Items.Clear();
            List<clsAsignatura> listaAsignaturas = Logica.clsAsignatura.getAsignatura();
            if(listaAsignaturas != null)
            {
                foreach (clsAsignatura Asignaturas in listaAsignaturas)
                {
                    _item = lvLibrosporGenerar.Items.Add(Convert.ToString(Asignaturas.nombre));
                    _item.SubItems.Add(Convert.ToString(Asignaturas.seccion));
                    _item.SubItems.Add(Convert.ToString(Asignaturas.cantidadAlumnos));
                    _item.SubItems.Add(Asignaturas.ubicacion);
                    _item.SubItems.Add(Asignaturas.sede);
                    _item.SubItems.Add(Convert.ToString(Asignaturas.horas));
                    _item.SubItems.Add(Convert.ToString(Asignaturas.porcentajeAsistencia));
                    _item.SubItems.Add(Convert.ToString(Asignaturas.codigo));
                    _item.SubItems.Add(Convert.ToString(Asignaturas.docente));
                }
            }
        }

        // LLenar Libros según asistencia cargada en sistema

        private void btnGeneraLibros_Click(object sender, EventArgs e)
        {
            // Suponemos que desde Marzo a Agosto, tenemos 24 semanas, con 5 dias de clases, y 
            // la clase la tenemos 2 veces por semana, lunes, y viernes (70/48), no sabemos como funciona el sistema de carga horaria.
            ListViewItem lista = lvLibrosporGenerar.SelectedItems[0];

            int horas = int.Parse(lista.SubItems[5].Text) / 24;
            clsAsignatura.UpdateAsignatura(horas,int.Parse(lista.SubItems[7].Text));

            // generamos los libros para la asignatura seleccionada

            

            clsAsignatura old = clsAsignatura.TraerAsignatura(int.Parse(lista.SubItems[7].Text));

            clsLibro nuevo = new clsLibro(,old.docente,old.codigo,dpFechaInicio.Value,dpFechaTermino.Value,old.nombre,old.porcentajeAsistencia,old.sede,old.cantidadAlumnos,,old.horas);

            // Actualizamos Grilla
            llenarGrillaLibrosPorGenerar();


        }


        // Entrada a tabs
        private void tcMainEncargado_Enter(object sender, EventArgs e)
        {
            llenarGrillaLibrosPorGenerar();
            btnGeneraLibros.Enabled = false;
        }

        // Eventos Tabs

        private void lvLibrosporGenerar_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(lvLibrosporGenerar.SelectedItems.Count > 0)
            {
                ListViewItem lista = lvLibrosporGenerar.SelectedItems[0];
                btnGeneraLibros.Enabled = true;
            }
            else
            {
                btnGeneraLibros.Enabled = false;
            }
            
        }
    }
}
