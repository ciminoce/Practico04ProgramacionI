
namespace EjemploCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MostrarMenuCiclos();
                int opcionMenu = SeleccionarOpcion("Seleccione Opción:");
                switch (opcionMenu)
                {
                    case 1:
                        MostrarUsoDelWhile();
                        break;
                    case 2:
                        MostrarUsoDelDoWhile();
                        break;
                    case 3:
                        MostrarUsoDelFor();
                        break;
                    default:
                        break;
                }
                if (opcionMenu == 0)
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Salida del Programa");
        }

        private static void MostrarUsoDelFor()
        {
            Console.Clear();
            int numMultiplicar = 5;
            for (int multiplicador = 1; multiplicador <= 12; multiplicador++)
            {
                Console.WriteLine($"{numMultiplicar} * {multiplicador} = {numMultiplicar * multiplicador}");
            }
            EsperaTecla();
        }

        private static void MostrarUsoDelDoWhile()
        {
            Console.Clear();
            Console.WriteLine("Ejemplo Ciclo Do-While");
            int nro;
            bool seguir = true;
            do
            {
                Console.Write("Ingrese un número positivo:");
                if (!int.TryParse(Console.ReadLine(), out nro) || nro <= 0)
                {
                    Console.WriteLine("Error número no válido o mal ingresado");
                }
                else
                {
                    seguir = false;
                }
            } while (seguir);
            Console.WriteLine($"Joya...{nro} te sirve");
            EsperaTecla();
        }

        private static void MostrarUsoDelWhile()
        {
            Console.Clear();
            Console.WriteLine("Ejemplo Ciclo While");
            int nro = 0;
            while (nro == 0)
            {
                Console.Write("Ingrese un número cualquiera excepto 0:");
                if (!int.TryParse(Console.ReadLine(), out nro) || nro == 0)
                {
                    Console.WriteLine("ERROR número no válido");
                }
            }
            Console.WriteLine($"Joya... {nro} es válido");
            EsperaTecla();
        }

        private static void EsperaTecla()
        {
            Console.WriteLine("<ENTER> para continuar");
            Console.ReadLine();
        }

        private static int SeleccionarOpcion(string mensaje)
        {
            int nro;
            do
            {
                Console.Write(mensaje);
                if (!int.TryParse(Console.ReadLine(), out nro) || nro < 0 || nro > 3)
                {
                    Console.WriteLine("Error numero mal ingresado o no válido");
                }
                else
                {
                    break;
                }

            } while (true);
            return nro;
        }

        private static void MostrarMenuCiclos()
        {
            Console.Clear();
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Ejemplo While");
            Console.WriteLine("2 - Ejemplo Do-While");
            Console.WriteLine("3 - Ejemplo For");
        }
    }
}
