using System;
namespace SegundoParcial
{
    public class CInterfaz
    {
        static CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static string DarOpcion()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*             Sistema de Gestión         *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\n[A] Registrar un empleado.");
            Console.WriteLine("\n[B] Listar todos los empleados.");
            Console.WriteLine("\n[C] Registrar un vehículo.");
            Console.WriteLine("\n[D] Listar todos los vehículos.");
            Console.WriteLine("\n[E] Registro de dotacion.");
            Console.WriteLine("\n[F] Eliminar un empleado.");
            Console.WriteLine("\n[G] Informar datos por legajo.");
            Console.WriteLine("\n[H] Informar datos por patente.");
            Console.WriteLine("\n[I] Salir de la aplicación.");
            Console.WriteLine("\n**********************************************");
            return CInterfaz.PedirDato("opción elegida");
        }
        public static string PedirDato(string nombDato)
        {
            Console.Write("[?] Ingrese " + nombDato + ": ");
            string ingreso = Console.ReadLine();
            while (ingreso == "")
            {
                Console.Write("[!] " + nombDato + "es de ingreso OBLIGATORIO:");
                ingreso = Console.ReadLine();
            }
            Console.Clear();
            return ingreso.Trim();
            //.Trim() Remueve espacios en blanco previos y posteriores.

        }
        public static void MostrarInfo(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("<Pulse Enter>");
            Console.ReadLine();
            Console.Clear();
        }
    }
}