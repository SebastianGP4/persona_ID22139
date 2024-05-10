using clase_persona_herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona //La clase persona es la clase padre
    {
        public string Nombre //Se crean los atributos de la persona
        {
            get { return Nombre; }
            set { Nombre = value; } 
        }
        public string Edad
        {
            get { return Edad; }
            set { Edad = value; } 
        }
        public string Fechadenacimiento
        {
            get { return Fechadenacimiento; }
            set { Fechadenacimiento = value; } 
        }
        public Persona(string nombre, string fechadenacimiento, string edad) //Se crean las variables generales y sus atributos de la persona
        {
            Nombre = nombre;
            Edad = edad;
            Fechadenacimiento = fechadenacimiento;
        }
    }
    class Alumno : Persona //Se crea una clase hija, en este caso la clase se trata sobre alumnos 
    {
        public string Matricula //Se crean los atributos que debe tener un alumno
        {
            get { return Matricula; }
            set { Matricula = value; } 
        }
        public string Carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }
        public Alumno(string nombre, string edad, string fechadenacimiento, string matricula, string carrera) : base(nombre, edad, fechadenacimiento) //Se crean las variables generales y sus atributos de la persona
        {
            Matricula = matricula;
            Carrera = carrera;
        }
    }
    class Empleado : Persona //Se crea otra clase hija, en este caso la clase se trata sobre empleados
    {
        public string Puesto //Se crean los atributos que debe tener un empleado
        {
            get { return Puesto; }
            set { Puesto = value; }
        }
        public string Sueldoe 
        {
            get { return Sueldoe; }
            set { Sueldoe = value; }
        }
        public Empleado(string nombre, string edad, string fechadenacimiento, string sueldoe, string puesto) : base(nombre, edad, fechadenacimiento) //Se crean las variables para que la persona sea un empleado, ademas de juntar sus variables generales las cuales son su nombre, edad, fecha de nacimiento y sueldo
        {
            Puesto = puesto;
            Sueldoe = sueldoe;
        }
    }
    class Docente : Persona //Se crea otra clase hija, en este caso la clase se trata sobre docentes
    {
        public string Dni //Se crean los atributos que debe tener un docente
        {
            get { return Dni; }
            set { Dni = value; }
        }
        public string Sueldod
        {
            get { return Sueldod; }
            set { Sueldod = value; }
        }
        public Docente(string nombre, string edad, string fechadenacimiento, string sueldod, string dni) : base(nombre, edad, fechadenacimiento) //Se crean las variables para que la persona sea un docente, ademas de juntar sus variables generales las cuales son su nombre, edad, fecha de nacimiento y sueldo
        {
            Dni = dni;
            Sueldod = sueldod;
        }
    }
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}