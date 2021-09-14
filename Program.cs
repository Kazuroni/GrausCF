using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double ansC;
            double resF;

            Console.ForegroundColor=ConsoleColor.DarkBlue;

            Console.WriteLine("digite um grau em celsius para saber em Fahrenheit");
            Console.WriteLine();

            Console.ResetColor();


            Console.Write("digite os Graus em Celsius °C aqui: ");
            ansC = double.Parse(Console.ReadLine());


            resF = ansC * 9/5 + 32;

            Console.ForegroundColor=ConsoleColor.DarkBlue;

            Console.WriteLine();
            Console.WriteLine($"Conversão para Fahrenheit = {resF}°F");
            
            Console.ResetColor();

           
            Console.WriteLine();

            Console.WriteLine("Aperte qualquer tecla para Finalizar...");
            Console.ReadKey();
        }
    }
}
