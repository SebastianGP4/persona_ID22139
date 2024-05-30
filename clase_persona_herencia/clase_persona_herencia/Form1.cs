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
using System.Xml.Linq;
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
            string rutaImagen = "C:\\Users\\LENOVO\\Documents\\DASC\\Semestre 4\\Programación orientada a objetos 2\\POOM2_SGP\\clase_persona_herencia\\imagenes\\Empleado.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            dni_matricula.Visible = true;
            label5.Visible = true;
            carrera_puesto.Visible = true;
            label6.Visible = true;
            sueldo.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\LENOVO\\Documents\\DASC\\Semestre 4\\Programación orientada a objetos 2\\POOM2_SGP\\clase_persona_herencia\\imagenes\\Docente.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
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
            if (es_alumno.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.Icon = new Icon("C:\\Users\\LENOVO\\Downloads\\figuras_ID22139-main\\Figuras_Geometricas\\FigurasImagenes\\palomita.ico");
                MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + nombre_completo.Text + "\nFecha de Nac: " + fecha_de_nacimiento.Text
                + "\nEdad: " + edad.Text + "\nMatricula: " + dni_matricula.Text + "\nCarrera: " + carrera_puesto.Text);
            }
            else
            {
                if (es_un_docente.Checked || es_empleado.Checked)
                {
                    this.FormBorderStyle = FormBorderStyle.Fixed3D;
                    this.Icon = new Icon("C:\\Users\\LENOVO\\Downloads\\figuras_ID22139-main\\Figuras_Geometricas\\FigurasImagenes\\palomita.ico");
                    
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + nombre_completo.Text + "\nFecha de Nac: " + fecha_de_nacimiento.Text
              + "\nEdad: " + edad.Text + "\nDNI: " + dni_matricula.Text + "\nPuesto: " + carrera_puesto.Text + "\nSueldo: " + sueldo.Text);
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.Fixed3D;
                    this.Icon = new Icon("C:\\Users\\LENOVO\\Downloads\\figuras_ID22139-main\\Figuras_Geometricas\\FigurasImagenes\\palomita.ico");
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + nombre_completo.Text + "\nFecha de Nac: " + fecha_de_nacimiento.Text
               + "\nEdad: " + edad.Text);
                }

            }
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
            string rutaImagen = "C:\\Users\\LENOVO\\Documents\\DASC\\Semestre 4\\Programación orientada a objetos 2\\POOM2_SGP\\clase_persona_herencia\\imagenes\\Alumno.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = false;
            sueldo.Visible = false;
        }

        private void es_persona_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\LENOVO\\Documents\\DASC\\Semestre 4\\Programación orientada a objetos 2\\POOM2_SGP\\clase_persona_herencia\\imagenes\\Persona.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = false;
            dni_matricula.Visible = false;
            label5.Visible = false;
            carrera_puesto.Visible = false;
            label6.Visible = false;
            sueldo.Visible = false;
        }

        private void nombre_completo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
