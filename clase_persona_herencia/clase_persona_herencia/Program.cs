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
        public string Nombre { get; set; } //Se crean los atributos de la persona
        public string Edad { get; set; }
        public string Fechadenacimiento { get; set; }
        public string Sueldo { get; set; }
         public Persona(string nombre, string fechadenacimiento, string edad, string sueldo) //Se crean las variables generales y sus atributos de la persona
         {
            Nombre = nombre;
            Edad = edad;
            Fechadenacimiento = fechadenacimiento;
            Sueldo = sueldo;
         }
        public void MostrarInfo() //Se crean los métodos se puede realizar sin tener un cargo en específico
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad {Edad}, Fecha de nacimiento {Fechadenacimiento}");
        }
        public void Saludar()
        {
            Console.WriteLine("La persona saluda");
        }
        public void Socializar()
        {
            Console.WriteLine("La persona socializa con los demas");
        }
        public void Despedir()
        {
            Console.WriteLine("La persona se despide");
        }
    }
    class Alumno : Persona //Se crea una clase hija, en este caso la clase se trata sobre alumnos 
    {
        public string Matricula { get; set; } //Se crean los atributos que debe tener un alumno
        public string Carrera { get; set; }
        public Alumno(string nombre, string edad, string fechadenacimiento, string sueldo, string matricula, string carrera) : base(nombre, edad, fechadenacimiento, sueldo) //Se crean las variables para que la persona sea un alumno, ademas de juntar sus variables generales las cuales son su nombre, edad, fecha de nacimiento y sueldo
        {
            Matricula = matricula;
            Carrera = carrera;
        }
        public void Estudiar() //En esta parte se crean los métodos específicos para un alumno
        {
            Console.WriteLine("El alumno estudia");
        }
        public void Aprobar()
        {
            Console.WriteLine("El alumno aprueba la materia");
        }
        public void Reprobar()
        {
            Console.WriteLine("El alumno Reprueba la materia");
        }
    }
    class Empleado : Persona //Se crea otra clase hija, en este caso la clase se trata sobre empleados
    {
        public string Puesto { get; set; } //Se crean los atributos que debe tener un empleado
        public Empleado(string nombre, string edad, string fechadenacimiento, string sueldo, string puesto) : base(nombre,edad, fechadenacimiento, sueldo) //Se crean las variables para que la persona sea un empleado, ademas de juntar sus variables generales las cuales son su nombre, edad, fecha de nacimiento y sueldo
        {
            Puesto = puesto;
        }
        public void Trabajar() //En esta parte se crean los métodos específicos para un empleado
        {
            Console.WriteLine("El empleado trabaja");
        }
        public void Asistir()
        {
            Console.WriteLine("El empleado asiste al trabajo");
        }
        public void Faltar()
        {
            Console.WriteLine("El empleado falta al trabajo");
        }
    }

    class Docente : Persona //Se crea otra clase hija, en este caso la clase se trata sobre docentes
    {
        public string Dni { get; set; } //Se crean los atributos que debe tener un docente
        public Docente(string nombre, string edad, string fechadenacimiento, string sueldo, string dni) : base(nombre, edad, fechadenacimiento, sueldo) //Se crean las variables para que la persona sea un docente, ademas de juntar sus variables generales las cuales son su nombre, edad, fecha de nacimiento y sueldo
        {
            Dni = dni;
        }
        public void Enseñar() //En esta parte se crean los métodos específicos para un docente
        {
            Console.WriteLine("El docente enseña un nuevo tema a sus alumnos");
        }
        public void Calificar()
        {
            Console.WriteLine("El docente califica los examenes de sus alumnos");
        }
        public void Revisar()
        {
            Console.WriteLine("El docente revisa las tareas de sus alumnos");
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
