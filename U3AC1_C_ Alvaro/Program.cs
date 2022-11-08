using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3AC1_C__Alvaro
{
    class Program
    {
        static void Main(string[] args)
        {

            // Aplicacion de acredicion del alumno

            //Personalizar la ventana
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
 

            // Declaracion de variables como el nombre, apellidos, matricula, fecha de nacimiento, edad, nombre del curso, calificacion
            string nombre, apPaterno, apMaterno, matricula, nombreCurso;
            Byte calificacion;

            // Pedir los datos al usuario de manera dinamica

            Console.WriteLine("APLICACION DE SABER SI ACREDITASTE O NO EL CURSO \n");
            Console.WriteLine("Introduce tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu apellido paterno: ");
            apPaterno = Console.ReadLine();
            Console.WriteLine("Introduce tu apellido materno: ");
            apMaterno = Console.ReadLine();
            Console.WriteLine("Introduce tu matricula: ");
            matricula = Console.ReadLine();
            Console.WriteLine("Introduce el nombre del curso: ");
            nombreCurso = Console.ReadLine();
            Console.WriteLine("Introduce tu calificacion: ");
            calificacion = Convert.ToByte(Console.ReadLine());


            // Hacemos el proceso de saber si acredito o no usando if

            if (calificacion >= 70)
            {
                // Mostramos la informacion del alumno
                Console.WriteLine("Nombre del alumno: {0}{1}{2}.", nombre, apPaterno, apMaterno);
                Console.WriteLine("Matricula: {0}", matricula);
                Console.WriteLine("Nombre del curso: ", nombreCurso);
                Console.WriteLine("¡Felicidades, acreditaste el curso!");
            }
            else
            {
                // Si su calificacion es menor que 70 le mandamos mensaje que no acredito
                Console.WriteLine(" \n Lo siento, no acreditaste el curso, necesitas volver a cursar la asignatura.");
            }


            Console.ReadKey();
        }
    }
}
