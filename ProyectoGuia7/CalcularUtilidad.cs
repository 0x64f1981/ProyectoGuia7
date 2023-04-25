using System;

namespace ProyectoGuia7
{
    class CalcularUtilidad
    {
        public static double ImprimirError(double ta, double s)
        {
            double u = 0;
            if (ta <= 0 && s < 0)
                Console.WriteLine("Datos incorrectos. Porfavor, reinicie el programa.");

            if (ta < 1)
                u = s * 0.05;
            else
                if (ta < 2)
                u = s * 0.07;
            else
                if (ta < 5)
                u = s * 0.1;
            else
                if (ta <= 10)
                u = s * 0.15;
            else
                if (ta > 20)
                u = s * 0.2;
            return u;
        }
    }
}
