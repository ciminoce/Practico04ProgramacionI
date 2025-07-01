namespace Ejercicio01B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //El compilador infiere el tipo de variable
            //de acuerdo a lo que está asignado a la derecha
            var contador = 1;
            var contadorMayores5 = 0;
            var sumaNumeros = 0;
            var contadorPares = 0;
            do
            {
                Console.Clear();
                Console.Write($"Ingrese {contador}º número cualquiera:");
                if (int.TryParse(Console.ReadLine(), out int nroIngresado))
                {
                    //contador = contador + 1;
                    contador++;
                    
                    ProcesarNumeroIngresado(nroIngresado, ref sumaNumeros, ref contadorPares, ref contadorMayores5);
                }
                else
                {
                    Console.WriteLine("Nro mal ingresado");
                    EsperaTecla("Presione <ENTER> para continuar");
                }
            } while (contador <= 5);
            var promedio = sumaNumeros / 5;
            Console.Clear();
            Console.WriteLine("Resultados");
            Console.WriteLine($"La suma de los nros. ingresados es :{sumaNumeros}");
            Console.WriteLine($"Se ingresaron {contadorMayores5} nros. mayores a 5");
            Console.WriteLine($"{contadorPares} de ellos fueron pares");
            Console.WriteLine($"El promedio es {promedio}");

        }

        private static void EsperaTecla(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.ReadLine();
        }

        public static bool EsPar(int nro)
        {
            return nro % 2 == 0;
        }
        public static void ProcesarNumeroIngresado(int nro, ref int sumaNumeros, ref int contadorPares, ref int contadorMayoresQue5)
        {
            sumaNumeros += nro;
            if (EsPar(nro))
            {
                contadorPares++;
            }
            if (nro > 5)
            {
                contadorMayoresQue5++;
            }

        }
    }
}
