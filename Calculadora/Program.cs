using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        bool CalculadoraUso = true, ResultadoOperacion, ResultadoFinal;
        string opcion, operando;
        double result;
        int operar;
        Calculadora MiCalculadora = new Calculadora();
        while (CalculadoraUso)
        {
            do
            {
                Console.WriteLine("Ingrese la operacion que desea realizar");
                Console.WriteLine("1-Suma\n2-Resta\n3-Multiplicacion\n4-Division\n5-Limpiar\n6-Salir");
                opcion = Console.ReadLine();
            } while (string.IsNullOrEmpty(opcion));
            ResultadoOperacion = int.TryParse(opcion, out operar);
            if (ResultadoOperacion && 1 <= operar && operar <= 5)
            {
                switch (operar)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Ingrese el valor");
                            operando = Console.ReadLine();
                        } while (string.IsNullOrEmpty(operando));
                        ResultadoFinal = double.TryParse(operando, out result);
                        if (ResultadoFinal)
                        {
                            MiCalculadora.Sumar(result);
                        }
                        else
                        {
                            Console.WriteLine("error al ingresar valor");
                        }
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Ingrese el operando:");
                            operando = Console.ReadLine();
                        } while (String.IsNullOrEmpty(operando));

                        ResultadoFinal = double.TryParse(operando, out result);

                        if (ResultadoFinal)
                        {
                            MiCalculadora.Restar(result);
                        }
                        else
                        {
                            Console.WriteLine("Sintax error");
                        }
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Ingrese el operando:");
                            operando = Console.ReadLine();
                        } while (String.IsNullOrEmpty(operando));

                        ResultadoFinal = double.TryParse(operando, out result);

                        if (ResultadoFinal)
                        {
                            MiCalculadora.Multiplicar(result);
                        }
                        else
                        {
                            Console.WriteLine("Sintax error");
                        }
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("Ingrese el operando:");
                            operando = Console.ReadLine();
                        } while (String.IsNullOrEmpty(operando));

                        ResultadoFinal = double.TryParse(operando, out result);

                        if (ResultadoFinal)
                        {
                            MiCalculadora.Dividir(result);
                        }
                        else
                        {
                            Console.WriteLine("Sintax error");
                        }
                        break;
                    case 5:
                        MiCalculadora.Limpiar();
                        break;
                }
                if (operar != 5)
                {
                    Console.WriteLine("Resultado:" + MiCalculadora.Resultado + "\n");
                }
            }else
            {
                if (operar == 6)
                {
                    CalculadoraUso = false;
                    Console.WriteLine("Saliendo");
                }
                else
                {
                    Console.WriteLine("Operacion incorrecta");
                }
            }
        }
    }
}