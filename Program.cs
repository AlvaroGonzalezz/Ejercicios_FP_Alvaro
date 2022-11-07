using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FPU3_IF_Alvaro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Manejo de estructuras selectivas 

            // Declaracion de variables
            string name, lastName, contactNumber, city, FBProfile, email;
            string user, password, passwordConfirm, codeAccess;
            byte age = 0;

            // Asignacion de variables 
            Console.WriteLine("Ingresa tu nombre: ");
            name = Console.ReadLine();

            Console.WriteLine("Ingresa tu apellido: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            age = Convert.ToByte(Console.ReadLine());


            // Estructura selectiva if 

            if (age >= 18)
            {

                // Cambiamos la personalizacion de la ventana
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.WriteLine("Completa tu registro para obtener tu código");
                Console.WriteLine("Ingresa tu numero de telefono de celular:");
                contactNumber = Console.ReadLine();
                Console.WriteLine("Ingresa tu ciudad:");
                city = Console.ReadLine();
                Console.WriteLine("Ingresa tu perfil de Facebook:");
                FBProfile = Console.ReadLine();
                Console.WriteLine("Ingresa tu email:");
                email = Console.ReadLine();


                // Solicitar credenciales de acceso

                Console.WriteLine("Ingresa tu nombre de usuario:");
                user = Console.ReadLine();
                Console.WriteLine("Ingresa tu contraseña:");
                password = Console.ReadLine();
                Console.WriteLine("Vuelve a introducir tu contraseña: ");
                passwordConfirm = Console.ReadLine();

                if (password == passwordConfirm)
                {
                    // Numeros aleatorios
                    Random rnd = new Random(); // Funcion de numeros aleatorios
                    codeAccess = rnd.Next(1000, 9999).ToString(); // guardamosa ese numero en codeAccess ya convertido en .ToString
                    Console.WriteLine("Tu codigo de acceso es: {0}", codeAccess);


                }







            }

            // Texto parpadeando
            Console.WriteLine("Saliendo...");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo...");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo...");
            Thread.Sleep(1000);
        }
    }

}

