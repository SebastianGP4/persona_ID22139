using persona_herencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            label4.Visible = true;
            dni_matricula.Visible = true;
            label5.Visible = true;
            carrera_puesto.Visible = true;
            label6.Visible = true;
            sueldo.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            dni_matricula.Visible = true;
            label5.Visible = true;
            carrera_puesto.Visible = true;
            label6.Visible = true;
            sueldo.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //En el botón de limpiar hace que la información se borre
            nombre_completo.Clear();
            fecha_de_nacimiento.Clear();
            edad.Clear();
            dni_matricula.Clear();
            carrera_puesto.Clear();
            sueldo.Clear();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //En el botón de salir hace que cierre la aplicación
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Guardados"); //En el botón de guardar muestra un mensaje indicando que los datos se guardaron con éxito
        }

        private void validar_Click(object sender, EventArgs e) //En el botón de Validar ayuda a identificar si el usuario es un empleado, un alumno o un docente
        {
            if (es_alumno.Checked)
            {

                string nom = nombre_completo.Text;
                string fech = fecha_de_nacimiento.Text;
                int eda = Convert.ToInt32(edad.Text);
                int mat = Convert.ToInt32(dni_matricula.Text);
                string carrera = carrera_puesto.Text;
                Alumno alumno = new Alumno(nom, eda, fech, carrera, mat);
            }
            else
            {
                if (es_empleado.Checked)
                {

                    string nom = nombre_completo.Text;
                    string fech = fecha_de_nacimiento.Text;
                    int eda = Convert.ToInt32(edad.Text);
                    int mat = Convert.ToInt32(dni_matricula.Text);
                    string puesto = carrera_puesto.Text;
                    float sueld = Convert.ToSingle(sueldo.Text);
                    Empleado empleado = new Empleado(nom, eda, fech, puesto, sueld);
                }
                else if (es_un_docente.Checked)
                {
                    string nom = nombre_completo.Text;
                    string fech = fecha_de_nacimiento.Text;
                    int eda = Convert.ToInt32(edad.Text);
                    int mat = Convert.ToInt32(dni_matricula.Text);
                    string puesto = carrera_puesto.Text;
                    float sueld = Convert.ToSingle(sueldo.Text);
                    Docente docente = new Docente(nom, eda, fech, puesto, sueld);
                }
                else
                {
                    string nom = nombre_completo.Text;
                    string fech = fecha_de_nacimiento.Text;
                    int eda = Convert.ToInt32(edad.Text);
                }
            }
        }

        private void es_alumno_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            sueldo.Visible = false;
        }

        private void es_persona_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            dni_matricula.Visible = false;
            label5.Visible = false;
            carrera_puesto.Visible = false;
            label6.Visible = false;
            sueldo.Visible = false;
        }
    }
}
