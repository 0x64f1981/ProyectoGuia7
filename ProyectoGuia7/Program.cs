using System;

namespace ProyectoGuia7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definición de variables
            double ta, s;

            //Identificación del programa
            Console.WriteLine("Calcular utilidad de un empleado en base a los años trabajados y su salario.");

            //Entrada de datos
            Console.Write("Ingresa el tiempo trabajado en la empresa (en años): ");
            ta = double.Parse(Console.ReadLine());

            Console.Write("Ingresa tu salario (en USD): $");
            s = double.Parse(Console.ReadLine());

            //Procesamiento de datos
            double u = CalcularUtilidad.ImprimirError(ta, s);

            //Output
            PrintValues(ta, s, u);
            Console.ReadLine();
        }

        /// <summary>
        /// Se encarga de mostrar en pantalla los valores introducidos.
        /// </summary>
        /// <param name="ta">Se refiere a Tiempo trabajado en los años.</param>
        /// <param name="s">Se refiere al Salario mensual</param>
        /// <param name="u">U es la utilidad</param>
        static void PrintValues(double ta, double s, double u)
        {
            Console.WriteLine("\nTu salario mensual es de: {0}\n" +
                "Tiempo trabajado en la empresa en años: {1}\n" +
                "La utilidad del empleado es de: ${2}", s, ta, u);
        }
    }
}
