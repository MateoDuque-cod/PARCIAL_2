using System.Diagnostics.CodeAnalysis;

public class Program
{
    private static void Main(string[] args)
    {
        int jugadores, intento, aleatorio = 0;
        bool continuar = true;
        Random rand = new Random();
        string salir;
        int i = 0;

        do
        {
            Console.WriteLine("ingrese el numero de jugadores min 2 max 4");
            jugadores = int.Parse(Console.ReadLine());

            if (jugadores < 2 || jugadores > 4)
            {
                Console.WriteLine("error,deben haber min 2, max 4 jugadores");
            }
        }
        while (jugadores < 2 || jugadores > 4);
            switch (jugadores)
            {

                case 2:
                    aleatorio = rand.Next(0, 51);
                    break;

                case 3:
                    aleatorio = rand.Next(0, 101);
                    break;

                case 4:

                    aleatorio = rand.Next(0, 201);
                    break;

            }

            Console.WriteLine("¡EL JUEGO HA INICIADO!");

            while (continuar)
            {
            i++;
            
            if (i > jugadores)
            {
                i = 1;
            }
                Console.Write($"jugador # {i}, ingrese un numero:");
                intento = int.Parse(Console.ReadLine());

                switch (intento)
                {
                    case int n when n < aleatorio:
                        Console.WriteLine("MAYOR!!");
                        break;
                    case int n when n > aleatorio:
                        Console.WriteLine("MENOR!!");
                        break;
                    case int n when n == aleatorio:
                        Console.WriteLine($"jugador # {i},acertaste.");
                        Console.WriteLine(" _____________ ");
                        Console.WriteLine("|¡¡ GANADOR !!|");
                        Console.WriteLine("|_____________|");
                        continuar = false;
                        break;
                }
               /*  Console.WriteLine("Desea seguir jugando?  si para continuar, no para finalizar");
                salir = Console.ReadLine().ToUpper();

                if (salir != "SI")
                {
                    Console.WriteLine("FIN DEL JUEGO, GRACIAS POR JUGAR!");

                    continuar = false;
                }*/      
            }
             Console.WriteLine("Desea seguir jugando?  si para continuar, no para finalizar");
              salir = Console.ReadLine().ToUpper();

             if (salir != "SI")
             {
            Console.WriteLine("FIN DEL JUEGO, GRACIAS POR JUGAR!");

            continuar = false;
             }
    }
}