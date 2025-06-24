namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Kilos");
            var contadorKilos = 0;
            var acumuladorKilos = 0;
            var mayorPesoIngresado = -1;
            do
            {
                Console.Write("Ingrese un peso en Kilogramos (0 o negativo para salir): ");
                var kilos = int.Parse(Console.ReadLine());
                if (kilos <= 0)
                {
                    break;
                }
                contadorKilos++;
                acumuladorKilos += kilos;
                if (kilos > mayorPesoIngresado)
                {
                    mayorPesoIngresado = kilos;
                }
                Console.WriteLine($"{kilos} en kilogramos equivalen a:");
                Console.WriteLine($"{ConvertirKilosLibras(kilos)} libras");
                Console.WriteLine($"{ConvertirKilosOnzas(kilos)} onzas");
                Console.WriteLine($"{ConvertirKilosStones(kilos)} Stones");

            } while (true);
            if (contadorKilos > 0)
            {
                var promedio = acumuladorKilos / contadorKilos;
                Console.WriteLine($"Se ingresaron {contadorKilos} pesos");
                Console.WriteLine($"Promedio Kilos ingresados:{promedio}");
                Console.WriteLine($"El mayor peso ingresado fue {mayorPesoIngresado}");

            }
            else
            {
                Console.WriteLine("No se registraron pesos");
            }
        }
        public static double ConvertirKilosLibras(int pesoEnKilos)
        {
            return pesoEnKilos * 2.20462;
        }
        public static double ConvertirKilosOnzas(int pesoEnKilos)
        {
            return pesoEnKilos * 35.274;
        }
        public static double ConvertirKilosStones(int pesoEnKilos)
        {
            return pesoEnKilos / 6.35029;
        }
    }
}
