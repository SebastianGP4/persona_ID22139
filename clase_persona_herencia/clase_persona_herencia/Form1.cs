using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            nombre_completo.Text = string.Empty; //En el botón de limpiar hace que la información se borre
            fecha_de_nacimiento.Text = string.Empty;
            edad.Text = string.Empty;
            dni_matricula.Text = string.Empty;
            carrera_puesto.Text = string.Empty;
            sueldo.Text = string.Empty;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //En el botón de salir hace que cierre la aplicación
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); //En el botón de guardar muestra un mensaje indicando que los datos se guardaron con éxito
        }

        private void validar_Click(object sender, EventArgs e) //En el botón de Validar ayuda a identificar si el usuario es un empleado, un alumno o un docente
        {
            /*if ( es_empleado.Checked || es_alumno.Checked || es_un_docente.Checked ) //Para saber si la validación es correcta, se agrupa las tres opciones disponibles en un if
            {
                MessageBox.Show("Llena los datos correspondientes", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information); //La validación es correcta y permite llenar la información
            }
            else
            {
                MessageBox.Show("Error, primero elige una opción para validar", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error); //En caso de no elegir una opción, se muestra un mensaje de error
            }*/
        }

        private void es_alumno_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
