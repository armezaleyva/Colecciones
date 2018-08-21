using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones {
    class Program {
        static void Main(string[] args) {
            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan Perez";
            alumno.Matricula = "194536";
            var random = new Random();
            var nombres = new List<string>{
                "Juan Perez",
                "Maria Lopez",
                "Jose Sanchez",
                "Josefina Salazar",
                "Pepe Smith"};
            var materias = new List<string>{
                "Matematicas",
                "Historia",
                "Estructura de Datos",
                "Programacion Hipermedia"};

            List<Alumno> alumnos = new List<Alumno>();
            for (int i = 0; i < 4; i++) {   
                alumnos.Add(new Alumno());
                int index = random.Next(nombres.Count);
                alumnos[i].Nombre = nombres[index];
            }
            foreach (Alumno estudiante in alumnos) {
                for (int i = 0; i < 3; i++) {
                    estudiante.Materias.Add(new Materia());
                    int index = random.Next(materias.Count);
                    estudiante.Materias[i].Nombre = materias[index];
                }
            }

            foreach (Alumno estudiante in alumnos) {
                Console.WriteLine("\nAlumno: " + estudiante.Nombre);
                foreach (Materia materia in estudiante.Materias) {
                    Console.WriteLine("Materia: " + materia.Nombre);
                }
            }

            Console.ReadKey();
        }
    }
}
