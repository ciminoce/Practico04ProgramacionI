

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int nroTabla = 2; nroTabla <=7; nroTabla++)
            {
                Console.Clear();
                Console.WriteLine($"Mostrando la tabla de Multiplicar del {nroTabla}");
                MostrarTabla( nroTabla );
                EsperaTecla("<ENTER> para continuar");
            }
        }

        private static void EsperaTecla(string mensaje)
        {
            Console.WriteLine($"{mensaje}");
            Console.ReadKey();
        }

        private static void MostrarTabla(int nroTabla)
        {
            for (int i = 1; i < 10; i++)
            {
                string linea = $"{nroTabla} x {i} = {nroTabla * i}";
                Console.WriteLine(linea);
            }
        }
    }
}
