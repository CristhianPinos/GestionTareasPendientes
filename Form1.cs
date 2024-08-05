using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AgregarTarea_Click(object sender, EventArgs e)
        {
            var tarea = txt_Tarea.Text;

            if (string.IsNullOrWhiteSpace(tarea))
            {
                DialogResult dialogResult = MessageBox.Show("Introduce una tarea", "Tareas");
            }
            else
            {
                lst_Tareas.Items.Add(tarea);
                LimpiarCaja();
            }
        }

        public void LimpiarCaja()
        {
            txt_Tarea.Text = "";
        }

        private void btn_EliminarTarea_Click(object sender, EventArgs e)
        {
            if (lst_Tareas.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar esta tarea de la lista?", "Tareas", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lst_Tareas.Items.RemoveAt(lst_Tareas.SelectedIndex);
                    MessageBox.Show("Se elimino la tarea de la lista");
                }
                else
                {
                    MessageBox.Show("Operacion cancelada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una tarea de la lista");
            }
        }

        private void btn_LimpiarLista_Click(object sender, EventArgs e)
        {
            if (lst_Tareas.Items.Count == 0)
            {
                MessageBox.Show("No hay tareas en la lista");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar todas las tareas de la lista?", "Tareas", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lst_Tareas.Items.Clear();
                    MessageBox.Show("La lista ha sido limpiada");
                }
                else
                {
                    MessageBox.Show("Operacion cancelada");
                }
            }
        }
    }
}
