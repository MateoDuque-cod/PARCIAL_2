public  class Program
{
    private static void Main(string[] args)
    {
        double nota, promedio;
        double sumatoria = 0;
        bool continuar = true;
        int estudiantes, cantidad_notas, i, n;
        string respuestas;
        int ganadores  = 0;
        int perdedores = 0;
        while (continuar)
        {
            Console.WriteLine("ingrese el numero de estudiantes");
            estudiantes = Convert.ToInt32(Console.ReadLine());

            ganadores = 0;
            perdedores = 0;


            for (i = 0; i < estudiantes; i++)
            {
                Console.WriteLine($"ingrese la cantidad de notas del estudiante numero # {i + 1}");
                cantidad_notas = Convert.ToInt32(Console.ReadLine());
                sumatoria = 0;

                for (n = 0; n < cantidad_notas; n++)
                {

                    Console.WriteLine($"ingrese la nota # {n + 1}: ");
                    nota = Convert.ToDouble(Console.ReadLine());

                    sumatoria += nota;
                }

                promedio = sumatoria/cantidad_notas*0.10;

                switch (promedio)

                {
                    case double promd when promd >= 4.5:
                        Console.WriteLine($"el estudiante #{i + 1} con el promedio {promedio} clasificado como Excelente");
                        ganadores++;
                        break;

                    case double promd when promd >= 4.0 && promd <= 4.4:
                        Console.WriteLine($"el estudiante # {i +1}con el promedio {promedio} clasificado como sobresaliente");
                        ganadores++;
                        break;

                    case double promd when promd >= 3.5 && promd <= 3.9:
                        Console.WriteLine($"el estudiante #{i +1} con el promedio {promedio} clasificado como bueno");
                        ganadores++;
                        break;

                    case double promd when promd < 3.5:
                        Console.WriteLine($"el estudiante #{i +1} con el promedio {promedio} clasificado como insuficiente");
                        perdedores++;
                        break;

                    default:
                        Console.WriteLine("el estudiante no se ecuentra en la categoria.");
                        break;
                }


            }
                Console.WriteLine();
                Console.WriteLine($"total de estudiantes que ganaron: {ganadores}");
                Console.WriteLine($"total de estudiantes que perdieron: {perdedores}");
                Console.WriteLine();
                Console.WriteLine("Desea calcular otro grupo de estudiantes si para continuar, no para terminar.");
                respuestas = Console.ReadLine().ToUpper();
            
                if (respuestas != "SI")
                {
                  Console.WriteLine("calulo terminado.");
                  continuar = false;
            }
        }
    }
}





   
