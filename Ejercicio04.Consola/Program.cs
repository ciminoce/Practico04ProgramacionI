using ConsoleTables;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Random Numbers");
            Random r = new Random();
            var tabla = new ConsoleTable("Nro Random","Suma Parcial");
            int cantidadRandoms = 0;
            int sumaRandom = 0;
            do
            {
                //Console.WriteLine(r.Next(1, 50));
                var nroRandom = r.Next(1, 50);
                //sumaRandom=sumaRandom+nroRandom;
                //sumaRandom += nroRandom;
                //sumaRandom=SumarRandom(sumaRandom, nroRandom);
                SumarRandomAlternativo(ref sumaRandom, nroRandom, ref cantidadRandoms);
                tabla.AddRow(nroRandom, sumaRandom);

            } while (sumaRandom <= 100);
            Console.WriteLine(tabla.ToString());
            Console.WriteLine($"Se generaron {cantidadRandoms} números ramdon");
        }

        private static void SumarRandomAlternativo(ref int sumaRandom, int nroRandom, ref int cantidadRandoms)
        {
            sumaRandom += nroRandom;
            cantidadRandoms++;
        }

        private static int SumarRandom(int sumaRandom, int nroRandom)
        {
            return sumaRandom + nroRandom;
        }
    }
}
