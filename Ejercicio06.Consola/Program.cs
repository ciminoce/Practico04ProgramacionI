

using ConsoleTables;

namespace Ejercicio06.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nroMultiplicar = GetInt("Ingrese un nro. entero positivo:");
            MostrarMenuOpciones();
            var opcionSeleccionada = GetInt("Seleccione Opción:");
            switch (opcionSeleccionada)
            {
                case 1:
                    Multiplicar(nroMultiplicar,1,12);
                    break;
                case 2:
                    var extremo1 = GetInt("Ingrese un extremo para multiplicar:");
                    var extremo2 = GetInt("Ingrese el otro extremo para multiplicar");
                    Multiplicar(nroMultiplicar, extremo1, extremo2);
                    break;
                default:
                    break;
            }
        }

        //private static void Multiplicar(int nroMultiplicar, int extremo1, int extremo2)
        //{
        //    Console.Clear();
        //    var table = new ConsoleTable("Operación");
        //    //Cambiar orden de los extremos
        //    if (extremo1 > extremo2)
        //    {
        //        var auxiliar = extremo1;
        //        extremo1=extremo2;
        //        extremo2 = auxiliar;

        //    }
        //    for (int i =extremo1; i <= extremo2; i++)
        //    {
        //        string linea = $"{nroMultiplicar} x {i} = {ObtenerProducto(nroMultiplicar, i)}";
        //        table.AddRow(linea);
        //    }
        //    Console.WriteLine(table.ToString());
        //}
        private static void Multiplicar(int nroMultiplicar, int extremo1, int extremo2)
        {
            Console.Clear();
            var table = new ConsoleTable("Operación");
            //Cambiar orden de los extremos
            if (extremo1 > extremo2)
            {
                for (int i = extremo1; i >= extremo2; i--)
                {
                    string linea = $"{nroMultiplicar} x {i} = {ObtenerProducto(nroMultiplicar, i)}";
                    table.AddRow(linea);
                }

            }
            else
            {
                for (int i = extremo1; i <= extremo2; i++)
                {
                    string linea = $"{nroMultiplicar} x {i} = {ObtenerProducto(nroMultiplicar, i)}";
                    table.AddRow(linea);
                }

            }
            Console.WriteLine(table.ToString());
        }

        //private static void Multiplicar(int nroMultiplicar)
        //{
        //    Console.Clear();
        //    var table = new ConsoleTable("Operación");
        //    for (int i = 1; i <= 12; i++)
        //    {
        //        string linea = $"{nroMultiplicar} x {i} = {ObtenerProducto(nroMultiplicar, i)}";
        //        table.AddRow(linea);
        //    }
        //    Console.WriteLine(table.ToString());
        //}

        private static int ObtenerProducto(int nroMultiplicar, int i)
        {
            return nroMultiplicar * i;
        }

        private static void MostrarMenuOpciones()
        {
            Console.WriteLine("Menú de Opciones de Multiplicación");
            Console.WriteLine("1 - Multiplicación Tradicional");
            Console.WriteLine("2 - Multiplicación Alternativa");
            
        }

        public static int GetInt(string mensaje)
        {
            do
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out int nro) && nro > 0)
                {
                    return nro;
                }
                else
                {
                    Console.WriteLine("Nro mal ingresado!!!");
                }

            } while (true);

        }
    }
}
